using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Employee
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private DateTime BirthDate { get; set; }
        private decimal Salary { get; set; }
        private int people = 0;

        public List<decimal> EmployeesSalary = new List<decimal>();

        public void EmployCount()
        {
            Factory fac = new Factory();
            fac.Employees.Add(people++);
        }

        public void EmploySalary()
        {
            EmployeesSalary.Add(Salary);
        }

        public decimal EmployAllSalary()
        {
            decimal salary = 0;
            for(int i =0; i<EmployeesSalary.Count; i++)
            {
                salary+= EmployeesSalary[i];
            }
            return salary;
        }
    }
}
