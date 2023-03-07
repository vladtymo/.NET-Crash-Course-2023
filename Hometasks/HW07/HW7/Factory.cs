using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    internal class Factory
    {
        public string Name { get; set; }
        List<Employee> Employees;
        List<Product> Products;
        public decimal AvgSalary { get { decimal employeeSalary = 0; foreach (Employee employee in Employees) employeeSalary += employee.Salary; return employeeSalary / Employees.Count; } }
        public decimal TotalSalary { get { decimal employeeSalary = 0; foreach (Employee employee in Employees) employeeSalary += employee.Salary; return employeeSalary; } }
        public decimal GDP { get { decimal productsPrice = 0; foreach (Product product in Products) productsPrice += product.Price; return productsPrice / Employees.Count; } }
        public decimal EmpCount { get { return Employees.Count; } }

        public Factory()
        {
            Name = "NoName";
            Employees = new List<Employee>();
            Products = new List<Product>();
        }

        public Factory(string name, List<Employee> employees, List<Product> products)
        {
            Name = name;
            Employees = employees;
            Products = products;
        }

        public override string ToString()
        {
            return $"{Name}:\nEmployees: {PrintEmployees}\nProducts: {PrintProducts}";
        }

        public string PrintEmployees()
        {
            string printEmployees = "";
            foreach (Employee employee in Employees)
                printEmployees += employee.ToString();
            return printEmployees;
        }

        public string PrintProducts()
        {
            string printProducts = "";
            foreach (Product product in Products)
                printProducts += product.ToString();
            return printProducts;
        }
    }
}
