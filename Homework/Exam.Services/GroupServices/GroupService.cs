using Exam_Task.Database;
using Exam_Task.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exam_Task.Services.GroupServices
{
	public class GroupService : IGroupService
	{
		private readonly ApplicationDbContext _dbContext;
		public GroupService(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task Create(GroupEntity group)
		{
			await _dbContext.Groups.AddAsync(group);
			await _dbContext.SaveChangesAsync();
		}

		public async Task<List<GroupEntity>> GetAll()
		{
			List<GroupEntity> dbRecord = await _dbContext.Groups
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
			GroupEntity dbRecord = await _dbContext.Groups
				.FindAsync(id);

			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public async Task Update(GroupEntity group)
		{
			_dbContext.Groups.Update(group);
			await _dbContext.SaveChangesAsync();
		}
	}
}
