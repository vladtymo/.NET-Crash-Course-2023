namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the factory:");
            string factoryName = Console.ReadLine();

            Console.WriteLine("Enter the number of employees:");
            int empCount = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[empCount];
            for (int i = 0; i < empCount; i++)
            {
                Console.WriteLine($"Enter details for employee #{i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Surname: ");
                string surname = Console.ReadLine();
                Console.Write("Birth date (YYYY-MM-DD): ");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());

                employees[i] = new Employee
                {
                    Name = name,
                    Surname = surname,
                    BirthDate = birthDate,
                    Salary = salary
                };
            }

            Console.WriteLine("Enter the number of products:");
            int prodCount = int.Parse(Console.ReadLine());

            Product[] products = new Product[prodCount];
            for (int i = 0; i < prodCount; i++)
            {
                Console.WriteLine($"Enter details for product #{i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Manufacture date (YYYY-MM-DD): ");
                DateTime manufDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Category (1-Food, 2-Clothing, 3-Electronics): ");
                CategoryType category = (CategoryType)int.Parse(Console.ReadLine());
                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                products[i] = new Product
                {
                    Name = name,
                    ManufactureDate = manufDate,
                    Category = category,
                    Price = price
                };
            }

            Factory factory = new Factory
            {
                Name = factoryName,
                Employees = employees,
                Products = products
            };

            Console.WriteLine("New factory created:");
            Console.WriteLine(factory);
            Console.WriteLine($"Average salary: {factory.AvgSalary:C}");
            Console.WriteLine($"Total salary: {factory.TotalSalary:C}");
            Console.WriteLine($"GDP per employee: {factory.GDP:C}");
        }
    }
}
