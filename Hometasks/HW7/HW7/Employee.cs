using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    internal class Employee
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {
            Name = "NoName";
            SurName = "NoSurName";
            BirthDate = DateTime.Now;
            Salary = 0;
        }

        public Employee(string name, string surName, DateTime birthDate, decimal salary)
        {
            Name = name;
            SurName = surName;
            BirthDate = birthDate;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name} {SurName}:\nBirth Date: {BirthDate};\nSalary: {Salary}.\n";
        }
    }
}
