using Exam_Task.Base;
using System.Security.Cryptography.X509Certificates;

namespace Exam_Task.Database.Entities
{
	public class LecturerEntity : Human
	{
		public LecturerEntity() { }
		public LecturerEntity(string firstName, string lastName, string email, string phone, DateTime birthDate, string rank, string department)
		: base(firstName, lastName, email, phone, birthDate)
		{
			AcademicRank = rank;
			Department = department;
		}
		public int Id { get; set; }
		public string AcademicRank { get; set; }
    	public string Department { get; set; }

		public int? SubjectFK { get; set; }
		public SubjectEntity Subject { get; set; }
	}
}