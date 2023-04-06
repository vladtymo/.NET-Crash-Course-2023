using Exam_Task.Database.Entities;
using Exam_Task.Database.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Exam_Task.Services.GroupServices
{
	public class GroupService : IGroupService
	{
		private readonly IGenericRepository<GroupEntity> _groupRepository;
		public GroupService(IGenericRepository<GroupEntity> groupRepository)
		{
			_groupRepository = groupRepository;
		}
		public async Task Create(GroupEntity group)
		{
			await _groupRepository.Create(group);
		}
		public async Task<bool> Delete(int Id)
		{
			GroupEntity dbRecord = await _groupRepository.Table
				.FirstOrDefaultAsync(group=>group.Id==Id);
			if (dbRecord == null)
			{
				return false;
			}
			await _groupRepository.Delete(dbRecord);
			return true;
		}
		public async Task<List<GroupEntity>> GetAll()
		{
			List<GroupEntity> dbRecord = await _groupRepository.Table
				.Include(student => student.Students)
				.ThenInclude(subj => subj.Subjects)
				.ThenInclude(lect => lect.Lecturer)
				.ToListAsync();

			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public async Task<GroupEntity> GetById(int id)
		{
			GroupEntity dbRecord = await _groupRepository.Table
				.Include(student => student.Students)
				.ThenInclude(subj => subj.Subjects)
				.ThenInclude(lect => lect.Lecturer)
				.FirstOrDefaultAsync(group => group.Id == id);

			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public async Task Update(GroupEntity group)
		{
			await _groupRepository.Update(group);
		}
	}
}
