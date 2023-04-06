using Exam_Task.Base;

namespace Exam_Task.Database.Entities
{
	public class StudentEntity : Human
	{
		public StudentEntity() { }
		public StudentEntity(string firstName, string lastName, string email, string phone, DateTime birthDate, List<SubjectEntity> subjects)
			: base(firstName, lastName, email, phone, birthDate)
		{
			Subjects = subjects;
		}
		public int Id { get; set; }
		public IList<SubjectEntity> Subjects { get; set; }

		public int? GroupFK { get; set; }
		public GroupEntity Group { get; set; }
		public override string ToString()
		{
			return
				$"ID[{Id}] of Student\n" +
				base.ToString() + "\n";
		}
	}
}
