using Exam_Task.Database;
using Exam_Task.Database.Entities;
using Exam_Task.Services.GroupServices;
using Exam_Task.Services.SubjectServices;

namespace Exam_Task
{
	public class Program
	{
		private static ApplicationDbContext dbContext;
		private static ISubjectService subjectService;
		private static IGroupService groupService;
		static async Task Main(string[] args)
		{

			//List<LecturerEntity> lectures = new List<LecturerEntity>();

			//lectures.Add(new LecturerEntity("Michael", "Smith", $"qwe@gmail.com", "32434234", DateTime.UtcNow, "Rector", "FIT"));
			//lectures.Add(new LecturerEntity("Angelina", "Smitanth", $"qwe313@gmail.com", "32434234", DateTime.UtcNow, "Rector", "FIT"));
			//lectures.Add(new LecturerEntity("Roger", "Federer", $"qwefffff@gmail.com", "32434234", DateTime.UtcNow, "Rector", "FIT"));


			//List<SubjectEntity> subjects = new List<SubjectEntity>();

			//subjects.Add(new SubjectEntity("OOP", null, lectures[0]));
			//subjects.Add(new SubjectEntity("Math", null, lectures[0]));
			//subjects.Add(new SubjectEntity("Ukranian", null, lectures[1]));
			//subjects.Add(new SubjectEntity("English", null, lectures[2]));

			//List<StudentEntity> students = new List<StudentEntity>();
			//for (int i = 0; i < 10; i++)
			//{
			//	students.Add(
			//		new StudentEntity(
			//			$"Jonas_{i + 1}",
			//			$"Rogers_{i + 1}",
			//			$"quartus{i}@gmail.com",
			//			"3804232",
			//			DateTime.Now,
			//			new List<SubjectEntity>()
			//			{
			//				new SubjectEntity("OOP", null,new LecturerEntity("Michael", "Smith", $"qwe@gmail.com", "32434234", DateTime.UtcNow, "Rector", "FIT")
			//				),
			//				new SubjectEntity("Math", null, new LecturerEntity("Angelina", "Smitanth", $"qwe313@gmail.com", "32434234", DateTime.UtcNow, "Rector", "FIT")
			//				),
			//				new SubjectEntity("Ukranian", null, new LecturerEntity("Roger", "Federer", $"qwefffff@gmail.com", "32434234", DateTime.UtcNow, "Rector", "FIT")
			//				),
			//			}));
			//}// для кожного студента додати предмети окремо
			//List<GroupEntity> groups = new List<GroupEntity>
			//{
			//	new GroupEntity("KH-13-1", 3, students)
			//};
			dbContext = new ApplicationDbContext();
			subjectService = new SubjectService(dbContext);
			groupService = new GroupService(dbContext);
			//dbContext.Groups.AddRange(groups);
			//dbContext.SaveChanges();
			List<GroupEntity> entities = await groupService.GetAll();
			Console.WriteLine("Done");
			Console.ReadKey();
		}
	}
}