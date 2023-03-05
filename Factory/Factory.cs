namespace Factory
{
    internal class Factory
    {
        public string Name { get; set; }
        public Employee[] Employees;
        public Product[] Products;
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Employees:\n {ShowEmployees}\n" +
                $"Products:\n {ShowProducts}\n";
        }
        public void ShowEmployees()
        {
            int i = 0;
            foreach (Employee e in Employees)
            {
                i++;
                Console.WriteLine($"{i}"+ e.ToString());
                Console.WriteLine();
            }
        }
        public void ShowProducts()
        {
            int i = 0;
            foreach (Product p in Products)
            {
                i++;
                Console.WriteLine($"{i}" + p.ToString());
                Console.WriteLine();
            }
        }
        public Factory(string name, Employee[] employees, Product[] products)
        {
            Name = name;
            Employees = employees;
            Products = products;
        }

        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Ivan", "Duchik", new DateTime(2004, 03, 21), 2000.54M);
            Console.WriteLine(employee1.ToString());
            Employee employee2 = new Employee("Daria", "Guk", new DateTime(2002, 01, 12), 1900.68M);
            Console.WriteLine(employee2.ToString());
            Factory factory = new Factory("Roshen", 
                new Employee[] { employee1, employee2 },
                new Product[] { new Product("Chocolat", new DateTime(2022, 02, 21), CategoryType.Chocolate, 22.5M), new Product("Sugar-Candy", new DateTime(2022, 02, 13), CategoryType.Сandy, 12.5M)}) ;
            Console.WriteLine(factory.ToString());
        }
    }
}