namespace Exam_Task.Database.Entities
{
	public class GroupEntity
	{
		GroupEntity() { }
		public GroupEntity(string groupAbbreviation, int course, List<StudentEntity> students)
		{
			this.GroupAbbreviation = groupAbbreviation;
			this.Course = course;
			Students = students;
		}
		public int Id { get; set; }
		public string GroupAbbreviation { get; set; }
		public int Course { get; set; }
		public ICollection<StudentEntity> Students { get; set; }
	}
}
