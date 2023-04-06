using Exam_Task.Database.Entities;
using Exam_Task.Database.GenericRepository;
using Exam_Task.Services.StudentServices;
using Exam_Task.Services.SubjectServices;
using Microsoft.EntityFrameworkCore;

namespace Exam_Task.Services.LecturerServices
{
	public class LecturerService : ILecturerService
	{
		private readonly IGenericRepository<LecturerEntity> _lecturerRepository;
		private readonly IGenericRepository<SubjectEntity> _subjectRepository;
		private readonly IGenericRepository<StudentEntity> _studentRepository;
		private readonly IStudentService _studentService;
		public LecturerService(IGenericRepository<LecturerEntity> lecturerRepository, IGenericRepository<SubjectEntity> subjectRepository, IGenericRepository<StudentEntity> studentRepository,IStudentService studentService)
		{
			_lecturerRepository = lecturerRepository;
			_subjectRepository= subjectRepository;
			_studentRepository = studentRepository;
			_studentService = studentService;
		}
		public async Task Create(LecturerEntity lecturer)
		{
			await _lecturerRepository.Create(lecturer);
		}
		public async Task<bool> Delete(int Id)
		{
			LecturerEntity dbRecord = await _lecturerRepository.Table
				.FirstOrDefaultAsync(g => g.Id == Id);
			if (dbRecord == null)
			{
				return false;
			}
			await _lecturerRepository.Delete(dbRecord);
			return true;
		}
		public async Task Update(LecturerEntity subject)
		{
			await _lecturerRepository.Update(subject);
		}
		public async Task<List<LecturerEntity>> GetAll()
		{
			List<LecturerEntity> dbRecord = await _lecturerRepository.Table
				.ToListAsync();

			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}
		public async Task<List<LecturerEntity>> GetByStudentId(int studentId)
		{
			StudentEntity student = await _studentService.GetById(studentId);
			if(student == null)
			{
				return null;
			}
			List<LecturerEntity> lecturers = new List<LecturerEntity>();
			if (student.Subjects != null)
			{
				foreach (SubjectEntity subject in student.Subjects)
				{
					LecturerEntity lecturer = await _lecturerRepository.GetById(subject.Lecturer.Id);
					if (lecturer != null)
					{
						lecturers.Add(lecturer);
					}
				}
			}

			return lecturers;
		}
		public async Task<List<LecturerEntity>> GetAllAvaliable()
		{
			List<LecturerEntity> dbRecord = await _lecturerRepository.Table
				.Where(lect=>lect.SubjectFK == null)
				.ToListAsync();

			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}
		public async Task<LecturerEntity> GetById(int id)
		{
			LecturerEntity dbRecord = await _lecturerRepository.Table
				.FirstOrDefaultAsync(lectur => lectur.Id == id);

			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public async Task<bool> AddLecturerToTheSubject(int subjectId, int lecturerId)
		{
			var group = await _subjectRepository.GetById(subjectId);
			if (group == null)
			{
				return false;
			}
			var student = await GetById(lecturerId);
			if (student == null)
			{
				return false;
			}
			else
			{
				student.SubjectFK = group.Id;
				await _lecturerRepository.SaveChangesAsync();
				return true;
			}
		}

	}
}
