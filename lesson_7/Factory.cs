using System;

namespace Structure{
    class Factory{
        public string Name { get; set; }
        public Employee[] Employees { get; set; }
        public Product[] Products { get; set; }
        public decimal AvgSalary{
            get{
                decimal totalSalary = 0;
                foreach (Employee employee in Employees){
                    totalSalary += employee.Salary;
                }
                return totalSalary / Employees.Length;
            }
        }
        public decimal TotalSalary{
            get{
                decimal totalSalary = 0;
                foreach (Employee employee in Employees){
                    totalSalary += employee.Salary;
                }
                return totalSalary;
            }
        }
        public decimal GDP{
            get{
                decimal totalCost = 0;
                foreach (Product product in Products){
                    totalCost += product.Price;
                }
                return totalCost / Employees.Length;
            }
        }
        public int EmpCount{
            get{
                return Employees.Length;
            }
        }
        public Factory(string name, Employee[] employees, Product[] products){
            Name = name;
            Employees = employees;
            Products = products;
        }
        public override string ToString(){
            return $"Factory: {Name}";
        }
    }
}

