
public class Factory
{
    public string Name { get; set; }
    public Employee[] Employees { get; set; }
    public Product[] Products { get; set; }
    public decimal AvgSalary { 
        get{
            decimal salary = 0;
            foreach (var employee in this.Employees){
                salary+=employee.Salary;
            }
            return salary/this.Employees.Length;
        }
    }
    public decimal TotalSalary{ 
        get{
            decimal salary = 0;
            foreach (var employee in this.Employees){
                salary+=employee.Salary;
            }
            return salary;
        }
    }
    public decimal GDP{ 
        get{
            decimal sum = 0;
            foreach (var product in this.Products){
                sum+=product.Price;
            }
            return sum/this.Employees.Length;
        }
    }
    public decimal EmpCount{ 
        get{
            return this.Employees.Length;
        }
    }

    public void showInfo(){
        Console.WriteLine("Ours Employees:");
        foreach (var employee in this.Employees)
        {
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Surname: {employee.Surname}");
            Console.WriteLine($"Birth Date: {employee.BirthDate.ToShortDateString()}");
            Console.WriteLine($"Salary: {employee.Salary}");
            Console.WriteLine("--------------");
        }
        Console.WriteLine("Ours Products:");
        foreach (var product in this.Products)
        {
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"ManufactureDate: {product.ManufactureDate.ToShortDateString()}");
            Console.WriteLine($"CategoryType: {product.Category}");
            Console.WriteLine($"Price: {product.Price}");
            Console.WriteLine("--------------");
        }
    }
}