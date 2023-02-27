using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07_classes
{
    internal class Factory
    {
        public string Name { get; set; }
        List<Employee> employees = new List<Employee>();
        List<Product> products = new List<Product>();

        public override string ToString()
        {
            return $"Name: {Name}, AvgSalary: {AvgSalary}, SumSalary: {SumSalary}, GDP: {GDP}, EmployeeCount:{EmployeeCount} ";
        }
        public void AddEmployee(string Name,string Surname,DateTime BirthDay,decimal Salary)
        {
            Employee employee=new Employee(Name,Surname,BirthDay,Salary);
            employees.Add(employee);
        }
        public void AddProduct(string Name,DateTime manufactureDate, decimal Price)
        {
            Product product = new Product(Name, manufactureDate, Price);
            products.Add(product);
        }
        public decimal AvgSalary
        {
            get 
            {
                decimal sum = 0;
                foreach(var el in employees)
                {
                    sum += el.Salary;
                }
                return (sum/employees.Count);
            }
        }
        public decimal SumSalary
        {
            get
            {
                decimal sum = 0;
                foreach(var el in employees)
                {
                    sum+= el.Salary;
                }
                return sum;
            }
        }

        public decimal GDP
        {
            get
            {
                decimal sumPrice = 0;
                decimal countEmployee = employees.Count;
                foreach(var el in products)
                {
                    sumPrice+= el.Price;
                }
                return sumPrice / countEmployee;
            }
        }
        
        public int EmployeeCount
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

    }
}
