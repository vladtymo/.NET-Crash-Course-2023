namespace Exam_Task.Database.Entities
{
	public class SubjectEntity
	{
		public SubjectEntity() { }
		public SubjectEntity(string name, int? mark, LecturerEntity lecturer)
		{
			Name = name;
			Mark = mark;
			Lecturer = lecturer;
		}
		public int Id { get; set; }
		public string Name { get; set; }
		public int? Mark { get; set; }
		public LecturerEntity Lecturer { get; set; }

		public int? StudentFK { get; set; }
		public StudentEntity Student { get; set; }
	}
}
