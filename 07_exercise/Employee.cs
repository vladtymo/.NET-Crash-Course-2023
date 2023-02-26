using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseStructure
{

    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Birth Date: {BirthDate}, Salary: {Salary}";
        }
    }
}