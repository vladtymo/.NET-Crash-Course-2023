using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string Surname, DateTime birthday, decimal salary) 
        {  
            this.Name = name;
            this.Surname = Surname; 
            this.BirthDay = birthday;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"Name:{Name}, Surname:{Surname}, Birthday:{BirthDay}, Salary:{Salary}";
        }
    }
}
