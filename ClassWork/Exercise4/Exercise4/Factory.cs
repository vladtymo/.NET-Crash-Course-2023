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
        public List<Employee> Employees { get; set; }
        public List<Product> Products { get; set; }

        // нові властивості
        public decimal AvgSalary
        {
            get
            {
                if (Employees.Count == 0) return 0;
                decimal totalSalary = 0;
                foreach (var emp in Employees)
                {
                    totalSalary += emp.Salary;
                }
                return totalSalary / Employees.Count;
            }
        }

        public decimal TotalSalary
        {
            get
            {
                decimal totalSalary = 0;
                foreach (var emp in Employees)
                {
                    totalSalary += emp.Salary;
                }
                return totalSalary;
            }
        }

        public decimal GDP
        {
            get
            {
                decimal totalProductValue = 0;
                foreach (var product in Products)
                {
                    totalProductValue += product.Price;
                }
                if (Employees.Count == 0) return 0;
                return totalProductValue / Employees.Count;
            }
        }

        public int EmpCount
        {
            get { return Employees.Count; }
        }

        public Factory(string name, int employeeCount, int productCount)
        {
            Name = name;
            Employees = new List<Employee>();
            Products = new List<Product>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public override string ToString()
        {
            return $"Factory {Name} with {EmpCount} employees and {Products.Count} products.";
        }
    }
}
