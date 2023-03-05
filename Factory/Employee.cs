using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Surname: {Surname}\n" +
                   $"BirthDate: {BirthDate}\n" +
                   $"Salary: {Salary}";
        }
        public Employee(string name,string surname,DateTime birthDate,decimal salary)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Salary = salary;

        }

    }
}
