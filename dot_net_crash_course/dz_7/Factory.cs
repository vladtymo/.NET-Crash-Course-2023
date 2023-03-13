namespace dz_7
{
    internal class Factory
    {
        public string Name { get; set; }
        Employee[] Employers = { };
        Product[] Products = { };

        public decimal AvgSalary
        {
            get
            {
                return TotalSalary / (decimal)Employers.Length;
            }
        }

        public decimal TotalSalary
        {
            get
            {
                decimal sum = 0;
                foreach (Employee employer in Employers)
                {
                    sum += employer.Salary;
                }
                return sum;
            }
        }

        public decimal GDP
        {
            get
            {
                decimal sum = 0;
                foreach (Product product in Products)
                {
                    sum += product.Price;
                }
                 return sum / (decimal)Employers.Length;
            }
        }

        public int EmpCount
        {
            get
            {
                return Employers.Length;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}\n";
        }

        public void SetEmployers()
        {
            Console.WriteLine("Enter the number of employers: ");
            int count = int.Parse(Console.ReadLine());
            Employers = new Employee[count];

            for (int i=0; i < count; i++)
            {
                Console.WriteLine($"Employer {i + 1}: ");
                Employee employer = new Employee();

                Console.Write("Name = ");
                employer.Name = Console.ReadLine();
                Console.Write("Surname = ");
                employer.Surname = Console.ReadLine();
                Console.Write("BirthDate = ");
                employer.BirthDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Salary = ");
                employer.Salary = decimal.Parse(Console.ReadLine());
                
                Employers[i] = employer;
            }
        }

        public void GetEmployers()
        {
            foreach (Employee employer in Employers)
            {
                Console.WriteLine(employer.ToString());
            }
        }

        public void SetProducts()
        {
            Console.WriteLine("Enter the number of products: ");
            int count = int.Parse(Console.ReadLine());
            Products = new Product[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Product {i+1}: ");
                Product product = new Product();

                Console.Write("Name = ");
                product.Name = Console.ReadLine();
                Console.Write("CategoryType = ");
                product.Category = Enum.Parse<CategoryType>(Console.ReadLine());
                Console.Write("Price = ");
                product.Price = decimal.Parse(Console.ReadLine());

                Products[i] = product;
            }
        }

        public void GetProducts()
        {
            foreach (Product product in Products)
            {
                Console.WriteLine(product.ToString()); 
            }
        }



    }
}
