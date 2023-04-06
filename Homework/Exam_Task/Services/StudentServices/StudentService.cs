using Exam_Task.Database.Entities;
using Exam_Task.Database.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Exam_Task.Services.StudentServices
{
	public class StudentService : IStudentService
	{
		private readonly IGenericRepository<StudentEntity> _studentRepository;
		private readonly IGenericRepository<GroupEntity> _groupRepository;
		public StudentService(IGenericRepository<StudentEntity> studentRepository, IGenericRepository<GroupEntity> groupRepository)
		{
			_studentRepository = studentRepository;
			_groupRepository = groupRepository;
		}
		public async Task Create(StudentEntity student)
		{
			await _studentRepository.Create(student);
		}
		public async Task Update(StudentEntity student)
		{
			await _studentRepository.Update(student);
		}
		public async Task<List<StudentEntity>> GetAll()
		{
			List<StudentEntity> dbRecord = await _studentRepository.Table
				.Include(subj => subj.Subjects)
				.ThenInclude(lect => lect.Lecturer)
				.ToListAsync();

			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}
		public async Task<StudentEntity> GetById(int id)
		{
			StudentEntity dbRecord = await _studentRepository.Table
				.Include(subj => subj.Subjects)
				.ThenInclude(lect => lect.Lecturer)
				.FirstOrDefaultAsync(stud => stud.Id == id);

			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}
		public async Task<bool> AddStudentToTheGroup(int groupId, int studentId)
		{
			var group = await _groupRepository.GetById(groupId);
			if (group == null)
			{
				return false;
			}
			var student = await GetById(studentId);
			if (student == null)
			{
				return false;
			}
			else
			{
				student.GroupFK = group.Id;
				await _studentRepository.SaveChangesAsync();
				return true;
			}
		}

		public Task<bool> Delete(int Id)
		{
			throw new NotImplementedException();
		}
	}
}
