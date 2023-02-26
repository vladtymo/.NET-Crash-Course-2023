using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseStructure
{
    internal class Factory
    {
        public string Name { get; set; }
        public Employee[] Employees { get; set; }
        public Product[] Products { get; set; }

        public decimal AvgSalary => Employees.Average(e => e.Salary);
        public decimal TotalSalary => Employees.Sum(e => e.Salary);
        public decimal GDP => ProductHeaderValue.Sum(p => p.Price) / Employees.Length;
        public int EmpCount => Employees.Length;

        public override string ToString()
        {
            return $"Factory Name: {Name}, Employees: {EmpCount}, AvgSalary: {AvgSalary}, Total Salary: {TotalSalary}, GDP: {GDP}";

        }
    }
}