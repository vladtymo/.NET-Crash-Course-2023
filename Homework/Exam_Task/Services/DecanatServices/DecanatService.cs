using Exam_Task.Database.Entities;
using Exam_Task.Services.GroupServices;
using Exam_Task.Services.LecturerServices;
using Exam_Task.Services.StudentServices;
using Exam_Task.Services.SubjectServices;
using System.ComponentModel;

namespace Exam_Task.Services.DecanatServices
{
	public class DecanatService : IDecanatSystem
	{
		private readonly IGroupService groupService;
		private readonly IStudentService studentService;
		private readonly ISubjectService subjectService;
		private readonly ILecturerService lecturerService;
	    public DecanatService(IGroupService _groupService,IStudentService _studentService,ISubjectService _subjectService,ILecturerService _lecturerService)
		{
            groupService = _groupService;
			studentService = _studentService;
			subjectService = _subjectService;
			lecturerService = _lecturerService;
		}
		private async Task GiveMark()
		{
			while (true)
			{
				Console.WriteLine("1. Give Mark for Student");
				Console.WriteLine("2. Back\n");
				Console.Write("Make choice: ");
				int choice = int.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:
						Console.Write("Enter Student Id: ");
						int studentId = int.Parse(Console.ReadLine());
						StudentEntity student = await studentService.GetById(studentId);
						if (student != null)
						{
							List<LecturerEntity> lecturers = await lecturerService.GetByStudentId(student.Id);
							Console.WriteLine($"Studet {student.FirstName} has such subjects: ");
							int count = 1;
							foreach (SubjectEntity subject in student.Subjects)
							{
								Console.WriteLine($"\nSubject #{count}");
								Console.WriteLine($"{subject.ToString()}");
								count++;
							}

							Console.Write("Enter Subject Id: ");
							int subjectId = int.Parse(Console.ReadLine());
							Console.Write("Enter Mark: ");
							int mark = int.Parse(Console.ReadLine());
							await subjectService.EnterMark(studentId, subjectId, mark);
						Console.WriteLine("Done");
						}
						break;
					case 2:
						return;
					default:
						Console.WriteLine("Not right choose. Try again.");
						break;
				}
			}
		}
		private async Task ShowStudentsSubject()
		{
			while (true)
			{
				Console.WriteLine("1. Show by Id");
				Console.WriteLine("2. Back\n");
				Console.Write("Make choice: ");
				int choice = int.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:
						Console.Write("Enter Student Id: ");
						int Id = int.Parse(Console.ReadLine());
						StudentEntity student = await studentService.GetById(Id);
						if (student != null)
						{
							List<LecturerEntity> lecturers = await lecturerService.GetByStudentId(student.Id);
							Console.WriteLine($"Student {student.FirstName} has such subjects: ");
							if (student.Subjects.Count != 0)
							{
								int count = 1;
								foreach (SubjectEntity subject in student.Subjects)
								{
									Console.WriteLine($"\nSubject #{count}");
									Console.WriteLine($"{subject.ToString()}");
									if (subject.Lecturer != null)
									{
										Console.WriteLine($"Lecturer:");
										Console.WriteLine($"{subject.Lecturer.ToString()}");
									}
									else
									{
										Console.WriteLine("Such subject doesn`t has any Lecturer");
									}
									count++;
								}
							}
							else
							{
								Console.WriteLine("Such Student doesn`t has any Subjects");
							}
						}
						break;
					case 2:
						return;
					default:
						Console.WriteLine("Not right choose. Try again.");
						break;
				}
			}
		}
		public async Task Show()
		{
			while (true)
			{
				Console.WriteLine("1. Display Groups");
				Console.WriteLine("2. Display Students");
				Console.WriteLine("3. Display Subjects");
				Console.WriteLine("4. Display Lecturers");
				Console.WriteLine("5. Back\n");
				Console.Write("Make choice: ");
				int choice = int.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:
						await DisplayGroups();
						break;
					case 2:
						await DisplayStudents();
						break;
					case 3:
						await DisplaySubjects();
						break;
					case 4:
						await DisplayLecturers();
						break;
					case 5:
						return;
					default:
						Console.WriteLine("Not right choose. Try again.");
						break;
				}
			}

		}
		private async Task DisplayLecturers()
		{
			while (true)
			{
				Console.WriteLine("1. Display all Lecturers");
				Console.WriteLine("2. Display Lecturers by Student Id");
				Console.WriteLine("3. Display all avaliable");
				Console.WriteLine("4. Display Lecturer by Id");
				Console.WriteLine("5. Back\n");
				Console.Write("Make choice: ");
				int choiceStudent = int.Parse(Console.ReadLine());

				switch (choiceStudent)
				{
					case 1:
						foreach (LecturerEntity lecturer in await lecturerService.GetAll()) Console.WriteLine(lecturer.ToString());
						break;
					case 2:
						Console.Write("Enter Student Id: ");
						int studentId = int.Parse(Console.ReadLine());
						List<LecturerEntity> lctr = await lecturerService.GetByStudentId(studentId);
						if (lctr != null)
						{
							foreach (LecturerEntity lecturer in lctr) Console.WriteLine(lecturer.ToString());
						}
						else
						{
							Console.WriteLine("Such Student doesn`t has lecturers");
						}
						break;
					case 3:
						foreach (LecturerEntity lect in await lecturerService.GetAllAvaliable()) Console.WriteLine(lect.ToString());
						break;
					case 4:
						Console.Write("Enter Lecturer Id: ");
						int lecId = int.Parse(Console.ReadLine());
						LecturerEntity let = await lecturerService.GetById(lecId);
						if (let != null)
						{
							Console.WriteLine(let.ToString());
						}
						break;
					case 5:
						return;
					default:
						Console.WriteLine("Not right choose. Try again.");
						break;
				}
			}
		}
		private async Task DisplayGroups()
		{
			while (true)
			{
				Console.WriteLine("1. Display all Groups");
				Console.WriteLine("2. Display Group by Id");
				Console.WriteLine("3. Back\n");
				Console.Write("Make choice: ");
				int choiceStudent = int.Parse(Console.ReadLine());

				switch (choiceStudent)
				{
					case 1:
						foreach (GroupEntity group in await groupService.GetAll()) Console.WriteLine(group.ToString());
						break;
					case 2:
						Console.Write("Enter Group Id: ");
						int groupId = int.Parse(Console.ReadLine());
						GroupEntity grp = await groupService.GetById(groupId);
						if(grp!= null)
						Console.WriteLine(grp.ToString());
						break;
					case 3:
						return;
					default:
						Console.WriteLine("Not right choose. Try again.");
						break;
				}
			}
		}
		private async Task DisplayStudents()
		{
			while (true)
			{
				Console.WriteLine("1. Display all Students");
				Console.WriteLine("2. Display Student by Id");
				Console.WriteLine("3. Back\n");
				Console.Write("Make choice: ");
				int choiceStudent = int.Parse(Console.ReadLine());

				switch (choiceStudent)
				{
					case 1:
						foreach (StudentEntity student in await studentService.GetAll()) Console.WriteLine(student.ToString());
						break;
					case 2:
						Console.Write("Enter Student Id: ");
						int studentId = int.Parse(Console.ReadLine());
						StudentEntity stud= await studentService.GetById(studentId);
						if(stud != null)
						Console.WriteLine(stud.ToString());
						break;
					case 3:
						return;
					default:
						Console.WriteLine("Not right choose. Try again.");
						break;
				}
			}
		}
		private async Task DisplaySubjects()
		{
			while (true)
			{
				Console.WriteLine("1. Display all Subjects");
				Console.WriteLine("2. Display all Subjects with Mark");
				Console.WriteLine("3. Display all Subjects with no Mark");
				Console.WriteLine("4. Display Subject by Id");
				Console.WriteLine("5. Display Student`s Subjects");
				Console.WriteLine("6. Back\n");
				Console.Write("Make choice: ");
				int choiceSubject = int.Parse(Console.ReadLine());

				switch (choiceSubject)
				{
					case 1:
						foreach (SubjectEntity subject in await subjectService.GetAll()) Console.WriteLine(subject.ToString());
						break;
					case 2:
						foreach (SubjectEntity subject in await subjectService.GetAllRated()) Console.WriteLine(subject.ToString());
						break;
					case 3:
						foreach (SubjectEntity subject in await subjectService.GetAllEmpty()) Console.WriteLine(subject.ToString());
						break;
					case 4:
						Console.Write("Enter Subject Id: ");
						int subjectId = int.Parse(Console.ReadLine());
						SubjectEntity subj = await subjectService.GetById(subjectId);
						if(subj != null)
						Console.WriteLine(subj.ToString());
						break;
					case 5:
						await ShowStudentsSubject();
						break;
					case 6:
						return;
					default:
						Console.WriteLine("Not right choose. Try again.");
						break;
				}
			}
		}
		public async Task Delete()
		{
			while (true)
			{
				Console.WriteLine("1. Delete Group");
				Console.WriteLine("2. Delete Student");
				Console.WriteLine("3. Delete Subject");
				Console.WriteLine("4. Delete Lecturer");
				Console.WriteLine("5. Back\n");
				Console.Write("Make choice: ");
				int choice = int.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:
						Console.Write("Enter Group Id: ");
						int groupId = int.Parse(Console.ReadLine());
						await groupService.Delete(groupId);
						Console.WriteLine("Done");
						break;
					case 2:
						Console.Write("Enter Student Id: ");
						int studentId = int.Parse(Console.ReadLine());
						await studentService.Delete(studentId);
						Console.WriteLine("Done");
						break;
					case 3:
						Console.Write("Enter Subject Id: ");
						int subjectId = int.Parse(Console.ReadLine());
						await subjectService.Delete(subjectId);
						Console.WriteLine("Done");
						break;
					case 4:
						Console.Write("Enter Lecturer Id: ");
						int lectId = int.Parse(Console.ReadLine());
						await lecturerService.Delete(lectId);
						Console.WriteLine("Done");
						break;
					case 5:
						return;
					default:
						Console.WriteLine("Not right choose. Try again.");
						break;
				}
			}
		}
		public async Task EditEntities()
		{
			while (true)
			{
				Console.WriteLine("1. Add Student to the Group");
				Console.WriteLine("2. Add Subject to the Student");
				Console.WriteLine("3. Add Lecturer to the Subject");
				Console.WriteLine("4. Give Mark to the Subject");
				Console.WriteLine("5. Back\n");
				Console.Write("Make choice: ");
				int choice = int.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:
						Console.Write("Enter Group Id: ");
						int groupId = int.Parse(Console.ReadLine());
						Console.Write("Enter Student Id: ");
						int studId = int.Parse(Console.ReadLine());

						await studentService.AddStudentToTheGroup(groupId, studId);
						Console.WriteLine("Done");
						break;
					case 2:
						Console.Write("Enter Student Id: ");
						int studentId = int.Parse(Console.ReadLine());
						Console.Write("Enter Subject Id: ");
						int subjectId = int.Parse(Console.ReadLine());

						await subjectService.AddSubjectToTheStudent(studentId, subjectId);
						Console.WriteLine("Done");
						break;
					case 3:
						Console.Write("Enter Student Id: ");
						int lectId = int.Parse(Console.ReadLine());
						Console.Write("Enter Subject Id: ");
						int subjId = int.Parse(Console.ReadLine());

						await lecturerService.AddLecturerToTheSubject(subjId, lectId);
						Console.WriteLine("Done");
						break;
					case 4:
						await GiveMark();
						break;
					case 5:
						return;
					default:
						Console.WriteLine("Not right choose. Try again.");
						break;
				}
			}
		}
		public async Task Add()
		{
			while (true)
			{
				Console.WriteLine("1. Add new Group");
				Console.WriteLine("2. Add new Student");
				Console.WriteLine("3. Add new Subject");
				Console.WriteLine("4. Add new Lecturer");
				Console.WriteLine("5. Back\n");
				Console.Write("Make choice: ");
				int choice = int.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:
						Console.Write("Enter group abbreviation: ");
						string name = Console.ReadLine();
						Console.Write("Enter course number: ");
						int course = int.Parse(Console.ReadLine());
						await groupService.Create(new GroupEntity(name, course, null));
						break;
					case 2:
						Console.Write("Enter FirstName: ");
						string firstName = Console.ReadLine();
						Console.Write("Enter LastName: ");
						string lastName = Console.ReadLine();
						Console.Write("Enter Email: ");
						string email = Console.ReadLine();
						Console.Write("Enter Phone: ");
						string phone = Console.ReadLine();
						Console.Write("Enter Date of Birth (yyyy.MM.dd): ");
						DateTime dateTime = DateTime.Parse(Console.ReadLine());
						await studentService.Create(new StudentEntity(firstName, lastName, email, phone, dateTime, null));
						break;
					case 3:
						Console.Write("Enter Subject Name: ");
						string subjectName = Console.ReadLine();
						await subjectService.Create(new SubjectEntity(subjectName, null, null));
						break;
					case 4:
						Console.Write("Enter FirstName: ");
						string firstNameLecturer = Console.ReadLine();
						Console.Write("Enter LastName: ");
						string lastNameLecturer = Console.ReadLine();
						Console.Write("Enter Email: ");
						string emailLecturer = Console.ReadLine();
						Console.Write("Enter Phone: ");
						string phoneLecturer = Console.ReadLine();
						Console.Write("Enter Date of Birth (yyyy.MM.dd): ");
						DateTime dateTimeLecturer = DateTime.Parse(Console.ReadLine());
						Console.Write("Enter Rank: ");
						string rank = Console.ReadLine();
						Console.Write("Enter Department: ");
						string department = Console.ReadLine();
						LecturerEntity lecturer = new LecturerEntity(firstNameLecturer, lastNameLecturer, emailLecturer, phoneLecturer, dateTimeLecturer, rank, department);
						await lecturerService.Create(lecturer);
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
