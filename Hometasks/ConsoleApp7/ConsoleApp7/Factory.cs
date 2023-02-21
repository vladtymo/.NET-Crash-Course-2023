using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Factory
    {
        private string Name { get; set; }
        public List<int> Employees;
        public List<decimal> Products;

        Employee emp = new Employee();
        Product prod = new Product();
        private decimal AvgSalary
        {
            get
            {
                return emp.EmployAllSalary () / Employees.Count;
            }

        }

        private decimal TotalSalary
        {
            get
            {
                return emp.EmployAllSalary();
            }
        }

        private double GPD 
        {
            get
            {
                return ((double)(prod.Prod_all_price()/Employees.Count));
            }
        }

        private int EmpCount { 
            get
            {
                return Employees.Count;
            } 
        }

        public void Fact()
        {

        }
    }
}
