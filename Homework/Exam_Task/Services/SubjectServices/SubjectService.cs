using Exam_Task.Database;
using Exam_Task.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exam_Task.Services.SubjectServices
{
	public class SubjectService : ISubjectService
	{
		private readonly ApplicationDbContext _dbContext;
		public SubjectService(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task Create(SubjectEntity subject)
		{
			await _dbContext.Subjects.AddAsync(subject);
			await _dbContext.SaveChangesAsync();
		}

		public async Task<ICollection<SubjectEntity>> GetAll()
		{
			ICollection<SubjectEntity> dbRecord = await _dbContext.Subjects
				.ToListAsync();
			
			if(dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public async Task<SubjectEntity> GetById(int id)
		{
			SubjectEntity dbRecord = await _dbContext.Subjects
				.FindAsync(id);
			
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public async Task<bool> EnterMark(int studentId, int subjectId, int mark)
		{
			var student = await _dbContext.Students.FindAsync(studentId);
			if(student == null)
			{
				Console.WriteLine($"Student with id [{subjectId}] does not exist.");
				return false;
			}
			var subject = await _dbContext.Subjects.FindAsync(subjectId);
			if (subject == null)
			{
				Console.WriteLine($"Subject with id [{subjectId}] does not exist.");
				return false;
			}
			else
			{
				if (student.Subjects.Contains(subject))
				{
					subject.Mark = mark;
					await _dbContext.SaveChangesAsync();
					return true;
				}
				Console.WriteLine("Such Student does not contains such subject.");
				return false;
			}
		}

		public async Task Update(SubjectEntity subject)
		{
			_dbContext.Subjects.Update(subject);
			await _dbContext.SaveChangesAsync();
		}
	}
}
