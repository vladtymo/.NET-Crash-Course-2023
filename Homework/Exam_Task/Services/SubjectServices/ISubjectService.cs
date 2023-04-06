using Exam_Task.Database.Entities;

namespace Exam_Task.Services.SubjectServices
{
	public interface ISubjectService
	{
		Task Create(SubjectEntity subject);
		Task Update (SubjectEntity subject);
		Task<bool> Delete(int Id);
		Task<List<SubjectEntity>> GetAll();
		Task<SubjectEntity> GetById(int id);
		Task<bool> EnterMark(int studentId, int subjectId, int mark);
		Task<bool> AddSubjectToTheStudent(int studentId, int subjectId);
	}
}
