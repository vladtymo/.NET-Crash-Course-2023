namespace dz7{


internal class Program
{

    private static void Main(string[] args)
    {
        
        Factory factory = new Factory();
        factory.Name = "GentelCat";
        factory.Employees = new Employee[]
        {
            new Employee
            {
                Name = "Murchik",
                Surname = "Jobs",
                BirthDate = new DateTime(2010, 1, 1),
                Salary = 5000.00m
            },
            new Employee
            {
                Name = "Puma",
                Surname = "Britny",
                BirthDate = new DateTime(2011, 2, 2),
                Salary = 5000.01m
            }
        };
        factory.Products = new Product[]
        {
            new Product("Xiomi Readmi Note", new DateTime(2021, 1, 14), CategoryType.Electronics, 1199.99m),
            new Product("Nike Air Max 90", new DateTime(2020, 12, 1), CategoryType.Clothing, 149.99m),
            new Product("Nutella", new DateTime(2022, 5, 1), CategoryType.Food, 4.99m)
        };

        factory.showInfo();

        Console.WriteLine(factory.AvgSalary);
        Console.WriteLine(factory.TotalSalary);
        Console.WriteLine(factory.GDP);
        Console.WriteLine(factory.EmpCount);
    }
}
}