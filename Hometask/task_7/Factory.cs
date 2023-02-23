
namespace task_7
{
    internal class Factory
    {
        public Employee[] Employees { get; set; }
        public Product[] Products { get; set; }
        public string Name { get; set; }

        public Factory(string name, Employee[] employee, Product[] product)
        {
            Name = name;
            Employees = employee;
            Products = product;
        }

        public decimal AvgSalary
        {
            get
            {
                return Employees.Sum(Employee=> Employee.Salary) / Employees.Length;
            }
        }

        public decimal GDP
        {
            get { return Products.Sum(Product => Product.Price) / Employees.Length; }
        }

        public decimal TotalSalary
        {
            get { return Employees.Sum(Employee => Employee.Salary); }
        }

        public int EmpCount
        {
            get { return Employees.Length; }
        }
        public override string ToString() => Name;
            
    }
}
