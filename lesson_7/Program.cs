using System;

namespace Structure{
    class Program{
        static void Main(string[] args){
            Console.Write("Enter factory name: ");
            string factoryName = Console.ReadLine();
            Console.Write("Enter number of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[numEmployees];
                for (int i = 0; i < numEmployees; i++){
                    Console.Write($"Enter name for employee {i + 1}: ");
                    string name = Console.ReadLine();
                    Console.Write($"Enter surname for employee {i + 1}: ");
                    string surname = Console.ReadLine();
                    Console.Write($"Enter birthdate for employee {i + 1} (YYYY-MM-DD): ");
                    DateTime birthdate = DateTime.Parse(Console.ReadLine());
                    Console.Write($"Enter salary for employee {i + 1}: ");
                    decimal salary = decimal.Parse(Console.ReadLine());
                    employees[i] = new Employee(name, surname, birthdate, salary);
    }
    Console.Write("Enter number of products: ");
    int numProducts = int.Parse(Console.ReadLine());
    Product[] products = new Product[numProducts];
    for (int i = 0; i < numProducts; i++){
        Console.Write($"Enter name for product {i + 1}: ");
        string name = Console.ReadLine();
        Console.Write($"Enter manufacture date for product {i + 1} (YYYY-MM-DD): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
        Console.Write($"Enter category type for product {i + 1} (A/B/C): ");
        CategoryType category = (CategoryType)Enum.Parse(typeof(CategoryType), Console.ReadLine());
        Console.Write($"Enter price for product {i + 1}: ");
        decimal price = decimal.Parse(Console.ReadLine());
        products[i] = new Product(name, manufactureDate, category, price);
    }
    Factory factory = new Factory(factoryName, employees, products);
    Console.WriteLine(factory.ToString());
    Console.WriteLine("Employees:");
    foreach (Employee employee in employees){
        Console.WriteLine(employee.ToString());
    }
    Console.WriteLine("Products:");
    foreach (Product product in products){
        Console.WriteLine(product.ToString());
    }
    Console.WriteLine($"Average salary: {factory.AvgSalary:C}");
    Console.WriteLine($"Total salary: {factory.TotalSalary:C}");
    Console.WriteLine($"GDP per employee: {factory.GDP:C}");
    Console.WriteLine($"Employee count: {factory.EmpCount}");
    Console.ReadKey();

    }
}