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

			await decanatSystem.Run();
		}	
	}
}