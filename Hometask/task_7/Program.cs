using static task_7.Product;

namespace task_7
{
    struct Product
    {
        public enum CategoryType {Sport = 1, Cloth, IT}
        readonly private DateTime manufactureDate;

        public string Name { get; set; }
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }


        public Product(string name,DateTime manufactureDate, CategoryType category, decimal price)
        {
            this.manufactureDate = manufactureDate;
            Category = category;
            Name = name;
            Price = price;
        }


        public override string ToString() => $"Name: {Name} \n manufacture date: {manufactureDate} \n price: {Price}";

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name your factory: ");
            string nameFactory = Console.ReadLine();

            Console.WriteLine("Enter employee count: ");
            int employeeCount = int.Parse(Console.ReadLine());
                if(employeeCount <=0)
                {
                    Console.WriteLine("Invalid value!");
                    Environment.Exit(0);
                }

            Console.WriteLine("Enter product count: ");
            int productCount = int.Parse(Console.ReadLine());
                if (productCount <= 0) 
                {
                    Console.WriteLine("Invalid value!");
                    Environment.Exit(0); 
                }
            Employee[] employees = new Employee[employeeCount];
            Product[] products = new Product[productCount];
            //___________Employee______________
            for (int i=0; i<employeeCount; i++) 
            {
                Console.WriteLine("Enter name employee: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter surname employee: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Enter birth date employee: ");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter salary employee: ");
                decimal selary = decimal.Parse(Console.ReadLine());
            }
            //___________Product_______________
            for (int i = 0; i < productCount; i++)
            {
                Console.WriteLine("Enter name product: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter price product: ");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter manufacture date: ");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());
                for(int j=1; j<=3;j++) 
                {
                    Console.WriteLine($"Enter category type {j}: ");
                    Product.CategoryType category = (Product.CategoryType)Enum.Parse(typeof(Product.CategoryType), Console.ReadLine());
                }        
            }

            Factory factory = new Factory(nameFactory, employees, products);

            factory.ToString();
            foreach (Product product in products)
                Console.WriteLine(product.ToString());
            foreach (Employee employee in employees)
                Console.WriteLine(employee.ToString());
            
            Console.WriteLine($"Averege salary: {factory.AvgSalary}");
            Console.WriteLine($"Employees count: {factory.EmpCount}");
            Console.WriteLine($"GDP per employees: {factory.GDP}");
            Console.WriteLine($"Total salary: {factory.TotalSalary}");


        }
    }

}