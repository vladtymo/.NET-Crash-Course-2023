using Exam_Task.Database.Entities;
using Exam_Task.Database.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Exam_Task.Services.LecturerServices
{
	public class LecturerService : ILecturerService
	{
		private readonly IGenericRepository<LecturerEntity> _lecturerRepository;
		public LecturerService(IGenericRepository<LecturerEntity> lecturerRepository)
		{
			_lecturerRepository = lecturerRepository;
		}
		public async Task Create(LecturerEntity lecturer)
		{
			await _lecturerRepository.Create(lecturer);
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

	}
}
