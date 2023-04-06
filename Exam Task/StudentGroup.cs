using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task
{
    internal class StudentGroup
    {
        public string Name { get; set; }
        List<Student> students =new List<Student>();
        List<Subject> subjects = new List<Subject>();
        public StudentGroup(string name)
        {
            this.Name = name;
        }
        public void AddStudent(Student student)
        {
            students.Add(student);  
        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
            for(int i=0;i<students.Count();++i)
            {
                students[i].AddSubject(subject);
            }
            Console.WriteLine($"{subject.Name} has been added for group {Name}");
        }
        public void RemoveSubject(Subject subject)
        {
            subjects.Remove(subject);
            for (int i = 0; i < students.Count(); ++i)
            {
                students[i].RemoveSubject(subject);
            }
            Console.WriteLine($"{subject.Name} has been remove for group {Name}");
        }
        public void GetStudents()
        {
            Console.WriteLine($"Group {Name} :");
            int k = 1;
            for (int i=0;i< students.Count;++i)
            {                
                Console.WriteLine($"{k}.{students[i].LastName} {students[i].FirstName} email:{students[i].Email}");
                ++k;
            }
        }
        public void GetSubjects()
        {
            Console.WriteLine($"Group {Name} studies:");
            int k = 1;
            for (int i = 0; i < subjects.Count; ++i)
            { 
                Console.WriteLine($"{k}.{subjects[i]}");
                ++k;
            }
        }
        public override string ToString()
        { return $"Group {Name}"; }
    }
}
