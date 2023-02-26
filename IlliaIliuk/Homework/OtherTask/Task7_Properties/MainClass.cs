internal class MainClass
{/*
    static void Main()
    {
        
        Product product1 = new(DateTime.Now, "Mars", CategoryType.Food, 20);
        Product product2 = new(DateTime.Now, "Mars", CategoryType.Food, 20);
        Product product3 = new(DateTime.Now, "Mars", CategoryType.Food, 20);
        Product product4 = new(DateTime.Now, "Mars", CategoryType.Food, 20);
        Product[] products = { product1, product2, product3, product4 };

        Employee employee1 = new("Charles", "Mars", DateOnly.MaxValue, 2500);
        Employee employee2 = new("Illya", "Charles", DateOnly.MinValue, 500);
        Employee employee3 = new("Stas", "Burov", DateOnly.MaxValue, 5590);
        Employee[] employees = { employee1, employee2, employee3 };

        Factory factory1 = new("Coins", employees, products);

        Console.WriteLine(employee1);

        Console.WriteLine(factory1.GDP);
        Console.WriteLine(factory1.AvgSalary);
        Console.WriteLine(factory1.TotalSalary);
        Console.WriteLine(factory1.EmpCount);
        Console.WriteLine(factory1.ToString());
        Console.WriteLine("\n");
        
        Factory factory2 = new();
        String name, surname;
        decimal salary, price;
        DateOnly dateOnly;
        int day, months, year;
        DateTime dateTime;
        CategoryType category;


        Console.Write("\nEnter Factory name: ");
        String factoryName = Console.ReadLine();
        factory2.Name = factoryName;

        Console.Write("\nEnter Employee count: ");
        int employeeCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < employeeCount; i++)
        {
            Console.Write($"\nEnter {i} Employee name: ");
            name = Console.ReadLine();
            Console.Write($"\nEnter {i} Employee surname: ");
            surname = Console.ReadLine();

            Console.Write($"\nEnter {i} Employee BirthDate day: ");
            day = int.Parse(Console.ReadLine());
            dateOnly.AddDays(day);

            Console.Write($"\nEnter {i} Employee BirthDate month: ");
            months = int.Parse(Console.ReadLine());
            dateOnly.AddMonths(months);

            Console.Write($"\nEnter {i} Employee BirthDate year: ");
            year = int.Parse(Console.ReadLine());
            dateOnly.AddYears(year);

            Console.Write($"\nEnter {i} Employee salary: ");
            salary = decimal.Parse(Console.ReadLine());


            factory2.AddEmployee(name, surname, dateOnly, salary);
        }

        Console.Write("\nEnter Product count: ");
        int productCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < productCount; i++)
        {
            dateTime = DateTime.Now;
            Console.Write($"\nEnter {i} Product name: ");
            name = Console.ReadLine();

            Console.Write($"\nEnter {i} Product CategoryType: ");
            category = (CategoryType)int.Parse(Console.ReadLine());

            Console.Write($"\nEnter {i} Employee price: ");
            price = decimal.Parse(Console.ReadLine());


            factory2.AddProduct(dateTime, name, category, price);
        }

        Console.WriteLine("===============");
        Console.WriteLine(factory2.GDP);
        Console.WriteLine(factory2.AvgSalary);
        Console.WriteLine(factory2.TotalSalary);
        Console.WriteLine(factory2.EmpCount);
        Console.WriteLine(factory2.ToString());
        Console.WriteLine("\n");
      
    }*/
}
