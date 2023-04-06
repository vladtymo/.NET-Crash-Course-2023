using Exam_Task.Database;
using Exam_Task.Database.Entities;
using Exam_Task.Database.GenericRepository;
using Exam_Task.Services.DecanatServices;
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

		private static IDecanatSystem decanatSystem;
		static async Task Main(string[] args)
		{

			dbContext = new ApplicationDbContext();
			groupRepository = new GenericRepository<GroupEntity>(dbContext);
			studentRepository = new GenericRepository<StudentEntity>(dbContext);
			subjectRepository = new GenericRepository<SubjectEntity>(dbContext);
			lecturerRepository = new GenericRepository<LecturerEntity>(dbContext);

			studentService = new StudentService(studentRepository,groupRepository);
			lecturerService = new LecturerService(lecturerRepository,subjectRepository,studentRepository,studentService);
			subjectService = new SubjectService(subjectRepository,studentService);
			groupService = new GroupService(groupRepository);

			decanatSystem = new DecanatService(groupService, studentService,subjectService,lecturerService);

			Console.WriteLine("<============> Decanat System <============>");
			while (true)
			{
				Console.WriteLine("1. Add new Entity");
				Console.WriteLine("2. Delete Entity by Id");
				Console.WriteLine("3. Show Entity from Db");
				Console.WriteLine("4. Edit Entites");
				Console.WriteLine("5. Exit\n");
				Console.Write("Make choice: ");
				int choice = int.Parse(Console.ReadLine());

				switch(choice)
				{
					case 1:
						await decanatSystem.Add();
						break;
					case 2:
						await decanatSystem.Delete();
						break;
					case 3:
						await decanatSystem.Show();
						break;
					case 4:
						await decanatSystem.EditEntities();
						break;
					case 5:
						return;
					default:
						Console.WriteLine("Not right choose. Try again.");
						break;
				}
			}
		}
		
	}
}