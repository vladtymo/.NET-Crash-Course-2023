using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public void showInfo()
        {
            Console.WriteLine($" Name: {Name} surname: {Surname} birthDate: {BirthDate} and the salary: {Salary}");
        }

        public Employee()

        {
            Console.WriteLine("Enter name");
            Name = Console.ReadLine();

            Console.WriteLine("Enter surname");
            Surname = Console.ReadLine();
            Console.WriteLine("Enter year,mouth,day");

            BirthDate = new DateTime(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter salary");

            Salary = int.Parse(Console.ReadLine());
            


        }
    }
}
