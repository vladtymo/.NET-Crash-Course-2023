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

			dbContext = new ApplicationDbContext();
			groupRepository = new GenericRepository<GroupEntity>(dbContext);
			studentRepository = new GenericRepository<StudentEntity>(dbContext);
			subjectRepository = new GenericRepository<SubjectEntity>(dbContext);
			lecturerRepository = new GenericRepository<LecturerEntity>(dbContext);

			studentService = new StudentService(studentRepository,groupRepository);
			lecturerService = new LecturerService(lecturerRepository,subjectRepository,studentRepository);
			subjectService = new SubjectService(subjectRepository,studentService);
			groupService = new GroupService(groupRepository);

			Console.WriteLine("<============> Decanat System <============>");
			while (true)
			{
				Console.WriteLine("1. Add new Entity");
				Console.WriteLine("2. Delete Entity by Id");
				Console.WriteLine("3. Show Entity from Db");
				Console.WriteLine("4. Show Student subjects");
				Console.WriteLine("5. Give Mark");
				Console.WriteLine("6. Exit\n");
				Console.Write("Make choice: ");
				int choice = int.Parse(Console.ReadLine());

				switch(choice)
				{
					case 1:
						Add();
						break;
					case 2:
						Delete();
						break;
					case 3:
						await Show();
						break;
					case 4:
						await ShowStudentsSubject();
						break;
					case 5:
						await GiveMark();
						break;
					case 6:
						return;
					default:
						Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
						break;
				}
			}

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
			//await lecturerService.AddLecturerToTheSubject(30, 36);//Додати перевірку на те чи вже має ФК
			Console.WriteLine("Done");
			Console.ReadKey();
		}
		
	}
}