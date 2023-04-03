using Exam_Task.Database.Entities;
using Exam_Task.Database.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Exam_Task.Services.StudentServices
{
	public class StudentService : IStudentService
	{
		private readonly IGenericRepository<StudentEntity> _studentRepository;
		public StudentService(IGenericRepository<StudentEntity> studentRepository)
		{
			_studentRepository = studentRepository;
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
				.FirstOrDefaultAsync(stud => stud.Id == id);

			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}
	}
}
