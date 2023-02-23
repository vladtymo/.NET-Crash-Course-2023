using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeClass;
using ProductClass;

namespace FactoryClass
{
    internal class Factory
    {
        public string Name { get; set; }
        Product[] products;
        Employee[] employees;
        public int AvgSalary {
            get
            {              
                int sum = 0;
                for (int i = 0; i < employees.Length; i++)
                {
                    sum += (int)employees[i].Salary;
                }

                return sum/employees.Length;
            }
        }

        public int TotalSalary
        {
            get 
            {
                int sum = 0;
                for (int i = 0; i < employees.Length; i++)
                {
                    sum += (int)employees[i].Salary;
                }

                return sum;
            }
        }

        public double GDP
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < products.Length; i++)
                {
                    sum += (double)products[i].Price;
                }

                return sum/employees.Length;

            }
        }

        public int EmpCount
        {
            get { return employees.Length; }
        }


        public Factory(string Name,ref Product[] products,ref Employee[] employees)
        {
            this.products = products;
            this.employees = employees;
        }
    }
}
