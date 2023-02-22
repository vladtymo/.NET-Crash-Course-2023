using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._2
{
    class Factory
    {
        public string Name { get; set; }
        public Employee[] Employees { get; set; }
        public Product[] Products { get; set; }

        public Factory(string Name, Employee[] Employees, Product[] Products)
        {
            this.Name = Name;
            this.Employees = Employees;
                this.Products = Products;
        }

        public decimal AvgSalary
        {
            get
            {
                decimal suma = 0;
                foreach (Employee emp in Employees)
                {
                    suma += emp.Salary;
                }
                return suma / Employees.Length;
            }
        }

        public decimal TotalSalary
        {
            get
            {
                decimal suma = 0;
                foreach(Employee emp in Employees)
                {
                    suma += emp.Salary;
                }
                return suma;
            }
        }

        public decimal GDP
        {
            get
            {
                decimal suma = 0;
                foreach(Product prod in Products)
                {
                    suma += prod.Price;
                }
                return suma;
            }
        }

        public int EmpCount
        {
            get
            {
                return Employees.Length;
            }
        }

        public override string ToString()
        {
            return $"Factory: {Name}\n" +
                $"Average of Salary: {AvgSalary.ToString()}\n" +
                $"Total Salary: {TotalSalary.ToString()}\n" +
                $"GDP: {GDP.ToString()}\n" +
                $"Employee count: {EmpCount.ToString()}";

        }

    }
}
