using System.Security.Cryptography.X509Certificates;

namespace Exam_Task
{
	//abstract class Human
	//{
	//	public string FirstName { get; set; }
	//	public string LastName { get; set; }
	//	public string Email { get; set; }
	//	public string Phone { get; set; }
	//	public DateTime BirthDate { get; set; }
	//}
	//class Student : Human
	//{	
	//	public Group Group { get; set; }
	//	public Student(string firstName, string lastName, string email, string phone, DateTime birthDate, Group group)
	//	{
	//		FirstName = firstName;
	//		LastName = lastName;
	//		Email = email;
	//		Phone = phone;
	//		BirthDate = birthDate;
	//		Group = group;
	//	}
	//}
	//class Subject
	//{
	//	public string Name { get; set; }
	//	public Lecturer Lecturer { get; set; }
	//}
	//class Lecturer : Human
	//{
	//    public string Rank { get; set; }
	//	public string Department { get; set; }
	//}
	//class Group
	//{
	//	public string GroupAbbreviation { get; set; }
	//	public int Course { get; set; }
	//	public ICollection<Subject> Subjects { get; set; }
	//}
	abstract class Human
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public DateTime BirthDate { get; set; }
	}
	class Student : Human
	{
		//public Group Group { get; set; }
		public Student(string firstName, string lastName, string email, string phone, DateTime birthDate, List<Subject> subjects)
		{
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Phone = phone;
			BirthDate = birthDate;
			Subjects = subjects;
		}
		public ICollection<Subject> Subjects { get; set; }
	}
	class Subject
	{
		public string Name { get; set; }
		public Lecturer Lecturer { get; set; }
	}
	class Lecturer : Human
	{
		public string Rank { get; set; }
		public string Department { get; set; }
	}
	class Group
	{
		public Group(string groupAbbreviation, int course, ICollection<Student> students)
		{
			GroupAbbreviation = groupAbbreviation;
			Course = course;
			Students = students;
		}

		public string GroupAbbreviation { get; set; }
		public int Course { get; set; }
		public ICollection<Student> Students { get;private set; }
	}
	public class Program
	{
		private static List<Student> students;
		private static List<Subject> subjects;
		private static List<Lecturer> lectures;
		private static List<Group> groups;
		static void Main(string[] args)
		{


			subjects = new List<Subject>();
			for(int i=0; i<1; i++)
			{
				subjects.Add(new Subject()
				{
					Name = "OOP",
					Lecturer = new Lecturer()
					{
						FirstName = "Savenko",
						BirthDate = DateTime.UtcNow,
						Department = "FIT",
						LastName = "Jour",
						Email = "savenko@gmail.com",
						Phone = "32434234",
						Rank = "Rector",
					}
				}
				);
			}
			students = new List<Student>();
			for (int i = 0; i < 100; i++)
			{
				students.Add(
					new Student(
						$"Oleg_{i + 1}",
						$"Red_{i + 1}",
						$"olegredko4{i}@gmail.com",
						"380954232", DateTime.Now,
						new Group() { Course = 2, GroupAbbreviation = "KI2-21-1",
							Subjects = subjects }));
			}
		}
	}
}