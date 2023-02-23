using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string surname, DateTime birthDate, decimal salary)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Employee: {Name} {Surname}, BirthDate: {BirthDate.ToString("dd/MM/yyyy")}, Salary: {Salary}";
        }
    }
}
