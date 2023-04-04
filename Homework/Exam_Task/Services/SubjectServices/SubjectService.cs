using Exam_Task.Database.Entities;
using Exam_Task.Database.GenericRepository;
using Exam_Task.Services.StudentServices;
using Microsoft.EntityFrameworkCore;

namespace Exam_Task.Services.SubjectServices
{
	public class SubjectService : ISubjectService
	{
		private readonly IGenericRepository<SubjectEntity> _subjectRepository;
		private readonly IStudentService _studentService;
		public SubjectService(IGenericRepository<SubjectEntity> subjectRepository, IStudentService studentService)
		{
			_subjectRepository = subjectRepository;
			_studentService = studentService;
		}
		public async Task Create(SubjectEntity subject)
		{
			await _subjectRepository.Create(subject);
		}
		public async Task Update(SubjectEntity subject)
		{
			await _subjectRepository.Update(subject);
		}

		public async Task<List<SubjectEntity>> GetAll()
		{
			List<SubjectEntity> dbRecord = await _subjectRepository.Table
				.Include(lect => lect.Lecturer)
				.ToListAsync();

			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}
		public async Task<List<SubjectEntity>> GetAllEmpty()
		{
			List<SubjectEntity> dbRecord = await _subjectRepository.Table
				.Include(lect => lect.Lecturer)
				.Where(subj => subj.Mark.HasValue)
				.ToListAsync();
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}
		public async Task<SubjectEntity> GetById(int id)
		{
			SubjectEntity dbRecord = await _subjectRepository.Table	
				.Include(lect => lect.Lecturer)
				.FirstOrDefaultAsync(subj => subj.Id == id);

			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}
		public async Task<bool> EnterMark(int studentId, int subjectId, int mark)
		{
			var student = await _studentService.GetById(studentId); //_subjectRepository.Table.FindAsync(studentId);
			if (student == null)
			{
				Console.WriteLine($"Student with id [{subjectId}] does not exist.");
				return false;
			}
			var subject = await GetById(subjectId);
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
					await _subjectRepository.SaveChangesAsync();
					return true;
				}
				Console.WriteLine("Such Student does not contains such subject.");
				return false;
			}
		}
		public async Task<bool> AddSubjectToTheStudent(int studentId, int subjectId)
		{
			var student = await _studentService.GetById(studentId);
			if (student == null)
			{
				return false;
			}
			var subject = await GetById(subjectId);
			if (subject == null)
			{
				return false;
			}
			else
			{
				subject.StudentFK = student.Id;
				await _subjectRepository.SaveChangesAsync();
				return true;
			}
		}
	}
}
