using Exam_Task.Database.Entities;

namespace Exam_Task.Services.LecturerServices
{
	public interface ILecturerService
	{
		Task Create(LecturerEntity lecturer);
		Task Update(LecturerEntity subject);
		Task<bool> Delete(int Id);
		Task<List<LecturerEntity>> GetAll();
		Task<List<LecturerEntity>> GetAllAvaliable();
		Task<LecturerEntity> GetById(int id);
		Task<List<LecturerEntity>> GetByStudentId(int studentId);
		Task<bool> AddLecturerToTheSubject(int subjectId, int lecturerId);
	}
}
