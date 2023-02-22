using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._2
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public Employee(string Name, string Surname, DateTime BirthDate, decimal Salary)
        {
            this.Name= Name;
            this.Surname= Surname;
                this.BirthDate= BirthDate;
            this.Salary= Salary;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, BirthDate: {BirthDate.ToString("yyyy/MM/dd")}, Salary: {Salary.ToString()}";
        }
    }
}
