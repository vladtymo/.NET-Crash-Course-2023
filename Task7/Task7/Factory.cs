
namespace Task7
{
    internal class Factory
    {

        public string Name { get; set; }
        public Employee[] employees;
        public Product[] products;

        public decimal TotalSallary
        {
            get
            {
                return TTLS();
            }
        }
        public decimal AvgSalary { 
            get
            { 
                return TTLS() / employees.Length;
            } 
        }

        public decimal GDP
        {
            get
            {
                decimal sum = 0;
                foreach (Product p in products)
                {
                    sum += p.Price;
                }
                return sum / employees.Length;
            }
        }

        public int EmpCount { get => employees.Length; }

        public decimal TTLS()
        {
            decimal sum = 0;
            foreach (Employee e in employees)
            {
                sum += e.Salary;
            }
            return sum;
        }
        public Factory(int ec, int pc)
        {
            employees = new Employee[ec];
            products = new Product[pc];
            for (int i = 0; i < EmpCount; i++)
            {
                employees[i] = new Employee();
                Console.WriteLine("Employee " + i);
                Console.WriteLine("Name: ");
                employees[i].Name = Console.ReadLine();
                Console.WriteLine("Surname: ");
                employees[i].Surname = Console.ReadLine();
                Console.WriteLine("BirthDate(dd/mm/yyyy): ");
                employees[i].BirthDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Salary: ");
                employees[i].Salary = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Employee added successfully!");
            }


            for (int i = 0; i < products.Length; i++)
            {
                products[i] = new Product();
                Console.WriteLine("Product " + i);
                Console.WriteLine("Name: ");
                products[i].Name = Console.ReadLine();
                Console.WriteLine("Price: ");
                products[i].Price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Product added successfully!");
            }
        }
    }
}
