using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_OOP_Prop
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly DateBirth { get; set; }
        public decimal Salary { get; set; }

        public void ToString()
        {
            Console.WriteLine("\nEmployee information");
            Console.Write($"Full name: {Name} {Surname}\n" +
                $"Date of birth: {DateBirth}\n" +
                $"Salary: {Salary}\n");
        }
    }
}
