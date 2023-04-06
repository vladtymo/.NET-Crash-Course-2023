using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Final_Task
{
    internal class Teacher: Person,ITeacher
    {
        public string AcademicStatus { get; set; }

        public int Salary { get; set; }

        List<Subject> subjects = new List<Subject>();
        List<StudentGroup> studentGroups = new List<StudentGroup>();
        public Teacher(string firstName, string lastName,string email, string academicStatus,int salary )
            :base(firstName,lastName,email)
        {
            this.AcademicStatus = academicStatus;
            this.Salary = salary;
        }

        public override void DoWork()
        {
            Console.WriteLine("I teach students");
        }
        public override void PrintInfo()
        {
            Console.WriteLine(new String('#',25));
            base.PrintInfo();
            Console.WriteLine($"The {AcademicStatus} has a salary of UAH {Salary}");
        }
        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
            Console.WriteLine($"\"{subject.Name}\" has been added for {AcademicStatus} {LastName}");
        }
        public void RemoveSubject(Subject subject)
        {
            subjects.Remove(subject);
            Console.WriteLine($"\"{subject.Name}\" has been remove for {AcademicStatus} {LastName}");
        }
        public void GetSubjects()
        {
            Console.WriteLine($"{AcademicStatus} {FirstName} {LastName} teaches:");
            for(int i=0;i<subjects.Count;++i)
            {
                Console.WriteLine($"{i + 1}.{subjects[i]}");
            }
        }
        public void AddStudentGroup(StudentGroup group)
        {
            studentGroups.Add(group);
            Console.WriteLine($"{AcademicStatus} {LastName} teaches group {group.Name}");
        }
        public void RemoveStudentGroup(StudentGroup group)
        {
            studentGroups.Remove(group);
            Console.WriteLine($"{AcademicStatus} {LastName} don`t teaches group {group.Name}");
        }
        public void GetStudentGroups()
        {
            Console.WriteLine($"{AcademicStatus} {FirstName} {LastName} teaches:");
            foreach(var group in studentGroups)
            {
                Console.WriteLine($"{AcademicStatus} {LastName} teaches {group}");
            }
        }
    }
}
