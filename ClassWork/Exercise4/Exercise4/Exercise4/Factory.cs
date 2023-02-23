using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Factory
    {
        public string Name { get; set; }
        public Employee[] Employees { get; set; }
        public Product[] Products { get; set; }
        public decimal AvgSalary
        {
            get
            {
                if (Employees == null || Employees.Length == 0)
                {
                    return 0;
                }

                decimal totalSalary = 0;
                foreach (var employee in Employees)
                {
                    totalSalary += employee.Salary;
                }

                return totalSalary / Employees.Length;
            }
        }

        public decimal TotalSalary
        {
            get
            {
                if (Employees == null || Employees.Length == 0)
                {
                    return 0;
                }

                return Employees.Sum(e => e.Salary);
            }
        }

        public decimal GDP
        {
            get
            {
                if (Employees == null || Employees.Length == 0 || Products == null || Products.Length == 0)
                {
                    return 0;
                }

                decimal totalValue = Products.Sum(p => p.Price);
                return totalValue / Employees.Length;
            }
        }

        public int EmpCount
        {
            get
            {
                if (Employees == null)
                {
                    return 0;
                }

                return Employees.Length;
            }
        }

        public override string ToString()
        {
            return $"Factory name: {Name}, Number of employees: {Employees.Length}, Number of products: {Products.Length}";
        }
    }
}
