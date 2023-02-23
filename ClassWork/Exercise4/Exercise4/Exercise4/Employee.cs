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

        public override string ToString()
        {
            return $"Employee name: {Name} {Surname}, Birth date: {BirthDate.ToShortDateString()}, Salary: {Salary}";
        }
    }
}
