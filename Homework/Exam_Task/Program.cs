using Exam_Task.Database;
using Exam_Task.Database.Entities;
using Exam_Task.Database.GenericRepository;
using Exam_Task.Services.GroupServices;
using Exam_Task.Services.LecturerServices;
using Exam_Task.Services.StudentServices;
using Exam_Task.Services.SubjectServices;

namespace Exam_Task
{
	public class Program
	{
		private static ApplicationDbContext dbContext;
		private static IGenericRepository<GroupEntity> groupRepository;
		private static IGenericRepository<StudentEntity> studentRepository;
		private static IGenericRepository<SubjectEntity> subjectRepository;
		private static IGenericRepository<LecturerEntity> lecturerRepository;

		private static ISubjectService subjectService;
		private static IGroupService groupService;
		private static IStudentService studentService;
		private static ILecturerService lecturerService;
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
			groupRepository = new GenericRepository<GroupEntity>(dbContext);
			studentRepository = new GenericRepository<StudentEntity>(dbContext);
			subjectRepository = new GenericRepository<SubjectEntity>(dbContext);
			lecturerRepository = new GenericRepository<LecturerEntity>(dbContext);

			studentService = new StudentService(studentRepository,groupRepository);
			lecturerService = new LecturerService(lecturerRepository,subjectRepository);
			subjectService = new SubjectService(subjectRepository,studentService);
			groupService = new GroupService(groupRepository);


			//dbContext.Groups.AddRange(groups);
			//dbContext.SaveChanges();
			//List<GroupEntity> entities = await groupService.GetAll();
			//List<StudentEntity> students = await studentService.GetAll();
			//List<SubjectEntity> subjects = await subjectService.GetAll();
			//lecturerService.Create(new LecturerEntity("Savuch", "Josan", "fdff@gmail.com", "31414", DateTime.Now, "Profesor", "FIT"));
			//List<LecturerEntity> lecturers = await lecturerService.GetAllAvaliable();

			//GroupEntity group = await groupService.GetById(1);

			//StudentEntity student = await studentService.GetById(1);
			//SubjectEntity subject = await subjectService.GetById(1);
			//LecturerEntity lecturer = await lecturerService.GetById(1);
			//subjectService.EnterMark(22,10, 5);

			//StudentEntity student = new("Olegus","Redkus","olegus@gmail.com","24242424",DateTime.Now,null);
			//await studentService.Create(student);
			//await studentService.AddStudentToTheGroup(1, 31);

			//SubjectEntity subject = new SubjectEntity("France",null,null);
			//await subjectService.Create(subject);
			//await subjectService.AddSubjectToTheStudent(31, 36);

			//LecturerEntity lecturer = new LecturerEntity("Vovik", "Bidok", "vovan@gmail.com", "3142525", DateTime.Now, "Master", "FIT");
			//await lecturerService.Create(lecturer);
			await lecturerService.AddLecturerToTheSubject(30, 36);//Додати перевірку на те чи вже має ФК
			Console.WriteLine("Done");
			Console.ReadKey();
		}
	}
}