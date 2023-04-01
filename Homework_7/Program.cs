namespace Factory
{
    class Factory
    {
        public string? Name { get; set; }
        public Employee[] Employees;
        public Product[] Products;
        public Factory(string name, Employee[] employees, Product[] products)
        {
            Name = name;
            Employees = employees;
            Products = products;
        }
        public void totalWorkerCount()
        {
            int totalCount = 0;
            for (int i = 0; i < Employees.Length; i++) { totalCount += i; }
            Console.WriteLine($"Total count of workers = {totalCount}");
        }
    }
    class Employee
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public void employeeInfo()
        {
            Console.WriteLine($"Name - {Name}\n" +
                $"Surname - {Surname}\n" +
                $"BirthDate - {BirthDate}\n" +
                $"Salary - {Salary}\n");
        }

    }
    enum Category {Electronics = 1,Products = 2, Wear};
    class Product
    {
        public string? Name { get; set;}
        public DateTime ManufactureDate;
        public Category Category { get; set; }
        public decimal Price { get; set;}
        public void productInfo()
        {
            Console.WriteLine($"Name - {Name}\n" +
                $"Manufacture Date - {ManufactureDate}\n"+
                $"Category - {Category}\n" +
                $"Price - {Price}\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee {
                Name = "John",
                Surname = "Wick",
                BirthDate = new DateTime(1990, 01, 01),
                Salary = new decimal(15000)
            };
            Employee employee2 = new Employee {
                Name = "John",
                Surname = "Dou",
                BirthDate = new DateTime(1995, 5, 3),
                Salary = new decimal(20000)
            };
            Employee employee3 = new Employee
            {
                Name = "James",
                Surname = "Martines",
                BirthDate = new DateTime(1999, 12, 5),
                Salary = new decimal(22341),
            };
            Employee employee4 = new Employee
            {
                Name = "Mikola",
                Surname = "Hvilyoviy",
                BirthDate = new DateTime(1977, 9, 29),
                 Salary = new decimal(31213)

            };

            Product Tshirts = new Product
            {
                Name = "T-shirts",
                ManufactureDate = new DateTime(2023, 04, 01, 12, 34, 00),
                Category = Category.Wear,
                Price = new decimal(150)
            };
            Product tv = new Product
            {
                Name = "TV",
                ManufactureDate = new DateTime(2023, 03, 15),
                Price = new decimal(23000),
                Category = Category.Electronics,
            };
            Product bread = new Product
            {
                Name = "Bread",
                Category = Category.Products,
                ManufactureDate = new DateTime(2023, 03, 01),
                Price = new decimal(22)
            };
            Tshirts.productInfo();
            Factory fabric = new Factory
            (
                "Fabrica",
                new Employee[] { employee1, employee2, employee3, employee4 },
                new Product[] { Tshirts, tv, bread }
            );
            fabric.totalWorkerCount();
        }
    }
}
