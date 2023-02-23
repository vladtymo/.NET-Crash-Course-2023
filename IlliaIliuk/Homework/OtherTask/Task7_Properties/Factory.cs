using System.Xml.Linq;

internal class Factory
{
    private Employee[] employees;
    private Product[] products;
    public String? Name { get; set; }

    public Factory() { }
    public Factory(string? name, Employee[] employees, Product[] products)
    {
        Name = name;
        this.employees = employees;
        this.products = products;
    }

    public decimal AvgSalary => EmployeesSalary() / employees.Length;
    public decimal TotalSalary => EmployeesSalary();
    public decimal GDP => ProductsCost() / employees.Length;
    public int EmpCount => employees.Length;

    public void AddEmployee(string? name, string? surname, DateOnly birthDate, decimal salary) 
    {
        if (employees == null)
        {
            Employee[] tempEmployees = new Employee[1];
            tempEmployees[0] = new Employee(name, surname, birthDate, salary);
            this.employees = tempEmployees;
        }
        else
        {
            Employee[] tempEmployees = new Employee[employees.Length + 1];
            Array.Copy(employees, tempEmployees, employees.Length);
            tempEmployees[tempEmployees.Length - 1] = new Employee(name, surname, birthDate, salary);
            this.employees = tempEmployees;
        }
    }
    public void AddProduct(DateTime manufactureDate, string? name, CategoryType category, decimal price)
    {
        if (products == null)
        {
            Product[] tempProduct = new Product[1];
            tempProduct[0] = new Product(manufactureDate, name, category, price);
            this.products = tempProduct;
        }
        else
        {
            Product[] tempProduct = new Product[products.Length + 1];
            Array.Copy(products, tempProduct, products.Length);
            tempProduct[tempProduct.Length - 1] = new Product(manufactureDate, name, category, price);
            this.products = tempProduct;
        }
    }

    public override String ToString() => $"Factory \"{Name}\": {employees.Length} employees, {products.Length} products."; 
    private decimal EmployeesSalary()
    {
        decimal avgSalary = 0;
        for (int i = 0; i < employees.Length; i++)
        {
            avgSalary += employees[i].Salary;
        }
        return avgSalary;
    }
    private decimal ProductsCost()
    {
        decimal productsCost = 0;
        for (int i = 0; i < products.Length; i++)
        {
            productsCost += products[i].Price;
        }
        return productsCost;
    }
}