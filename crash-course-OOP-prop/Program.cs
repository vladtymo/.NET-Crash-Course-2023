namespace crash_course_OOP_Prop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreateNewFactory();
        }

        static void CreateNewFactory()
        {
            Console.WriteLine("Creating your new factory");
           
            Console.WriteLine("Enter count of employees");
            int employeeCounter = int.Parse(Console.ReadLine()!);
            Employee[] employees = new Employee[employeeCounter];


            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine("Employee information(Name, Surname, Salary, DateBirth):");
                employees[i] = new Employee()
                { 
                    Name= Console.ReadLine()!,
                    Surname= Console.ReadLine()!,
                    Salary= decimal.Parse(Console.ReadLine()!),
                    DateBirth=DateOnly.Parse(Console.ReadLine()!),
                };
            }

            Console.WriteLine("Enter count of products");
            int productsCounter = int.Parse(Console.ReadLine()!);
            Product[] products = new Product[productsCounter];

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Product information(Manufacture date, Name, Price, \n " +
                    "Category: Laptop = 1, Smartphone = 2, HouseholdAppliances = 3):");

                DateOnly manDate = DateOnly.Parse(Console.ReadLine()!);
                products[i] = new Product(manDate)
                {
                    Name = Console.ReadLine()!,
                    Price = decimal.Parse(Console.ReadLine()!),
                    Category = Enum.Parse<CategoryType>(Console.ReadLine()!)
                   
                };
                Console.WriteLine();
            }

            Factory factory = new Factory(products, employees);
            Console.WriteLine("Set name to your factory");
            factory.Name = Console.ReadLine()!;

            factory.ToString();
        }
    }
}