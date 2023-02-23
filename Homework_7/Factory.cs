using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Factory
    {
        public string Name { get; set; }
        //private string[] Eployees;
        //private string[] Products;
        List<Employee> employees = new List<Employee>();
        List<Product> products = new List<Product>();

        public void AddEmployee(string Name, string Surname, DateTime BirthDay, decimal Salary)
        {
            Employee employee = new Employee(Name, Surname, BirthDay, Salary);
            employees.Add(employee);
        }
        public void AddProduct(string Name, DateTime ManufactureDate, decimal Price)
        {
            Product product = new Product(Name, ManufactureDate, Price);
            products.Add(product);
        }

        public decimal AvgSalary 
        { get 
            { 
                decimal sum = 0;
                foreach(var i in employees)
                {
                    sum += i.Salary;
                }
                return (sum /employees.Count);
            } 
        }

        public decimal SumSalary 
        { 
            get
            {
                decimal sum = 0;
                foreach (var i in employees)
                {
                    sum += i.Salary;
                }
                return (sum);
            }
        }

        public decimal GDP
        {
            get
            {
                decimal sumPrice = 0;
                decimal countEmp = employees.Count;
                foreach (var i in products)
                {
                    sumPrice += i.Price;
                }
                return (sumPrice / countEmp);
            }
        }
        public int EmpCount
        {
            get
            {
                return employees.Count;
            }
        }
        public Factory(string name) 
        { 
            this.Name = name;

        }
        public override string ToString()
        {
            return $"Name:{Name}, AvgSalary:{AvgSalary}, SumSalary:{SumSalary}, GDP:{GDP}, EmpCount:{EmpCount}";
        }
    }
}
