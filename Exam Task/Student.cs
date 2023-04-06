using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task
{
    internal class Student : Person , IStudent
    {
        public bool IsFullDayEducation { get; set; }
        public int Course { get; set; }
        List<Subject> subjects = new List<Subject>();
        Dictionary<Subject,int> examGrades = new Dictionary<Subject,int>();
        public Student(string firstName, string lastName, string email,bool isFullDayEducation, int course) 
            : base(firstName, lastName, email)
        {
            this.IsFullDayEducation = isFullDayEducation;
            this.Course = course;
        }

        public override void PrintInfo()
        {
            Console.WriteLine(new String('*', 25));
            base.PrintInfo();
            Console.WriteLine( $"Student equcation form:{((IsFullDayEducation) ? "full-day" : "extramual")} course: {Course}");
        }

        public override void DoWork() => Console.WriteLine("I am studying");

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
            Console.WriteLine($"\"{subject.Name}\" has been added for Student {FirstName} {LastName}");
        }
        public void RemoveSubject(Subject subject)
        {
            subjects.Remove(subject);
            Console.WriteLine($"\"{subject.Name}\" has been remove for Student {FirstName} {LastName}");
        }
        public void GetSubjects()
        {
            Console.WriteLine($"Student {FirstName} {LastName} studies:");
            for (int i = 0; i < subjects.Count; ++i)
            {
                Console.WriteLine($"{i + 1}.{subjects[i]}");
            }
        }
        public void AddExemGrade(Subject subject,int examGrade)
        {
            if (subjects.Contains(subject))
            {
                if (examGrade > 0 && examGrade <= 5) { examGrades.Add(subject, examGrade); }
                else Console.WriteLine("The grade for the exam must be >1 and <=5");
            }
            else Console.WriteLine($"Student {LastName} {FirstName} does not study the subject \"{subject}\"");
        }
        public void GetExamGrades()
        {
            Console.WriteLine($"Student`s exam grasdes {FirstName} {LastName} :");
            foreach (KeyValuePair<Subject, int> kvp in examGrades)
            {
                Console.WriteLine($"{kvp.Key} Exam grade :{kvp.Value}"); 
            }
            Console.WriteLine();
        }
        public void GetExamGradeBySubject(Subject subject)
        {
            if (examGrades.ContainsKey(subject)) Console.WriteLine($"{subject} exam grade {examGrades[subject]}");
            else Console.WriteLine($"Student {LastName} {FirstName} does not study the subject \"{subject}\"");
        }
    }
    
}
