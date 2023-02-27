using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }


        public Employee(string name,string surname,DateTime birthdate, decimal saluru)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthdate;
            Salary = saluru;
        }

        public string PrintEmloyee()
        {
            return $"{Name} {Surname}, Дата народження: {BirthDate.ToString("d")}, Зарплата: {Salary}";
        }
    }
}
