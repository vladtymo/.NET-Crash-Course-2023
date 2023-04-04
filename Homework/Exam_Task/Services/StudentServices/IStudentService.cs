using Exam_Task.Database.Entities;

namespace Exam_Task.Services.StudentServices
{
	public interface IStudentService
	{
		Task Create(StudentEntity student);
		Task Update(StudentEntity student);
		Task<List<StudentEntity>> GetAll();
		Task<StudentEntity> GetById(int id);
		Task<bool> AddStudentToTheGroup(int groupId, int studentId);
	}
}
