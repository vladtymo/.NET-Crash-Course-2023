namespace lessonTask_properties
{
    internal class Factory
    {
        public string Name { get; set; }
        public Employes[] employes;
        public Product[] products;
        public decimal TotalSalary { 
            get {
                decimal sum = 0;
                foreach (Employes employe in employes)
                {
                    sum += employe.Salary;
                }
                return sum; 
            } 
        }
        public decimal AvgSalary { get => TotalSalary / employes.Length; }
        public decimal GDP
        {
            get
            {
                decimal sum = 0;
                foreach (Product oneProduct in products)
                {
                    sum += oneProduct.Price;
                }
                return sum / employes.Length;
            }
        }
        public int EmpCount { get => employes.Length; }
        public Factory(int countEmployes, int countProducts)
        {
            employes = new Employes[countEmployes];
            products = new Product[countProducts];

            //Додавання даних про працівників
            Console.WriteLine("Введіть дані своїх працівників!");
            for(int i = 0; i < EmpCount; i++)
            {
                employes[i] = new Employes();
                Console.WriteLine("----Працівник №" + i + "----");
                Console.Write("Ім'я: ");
                employes[i].Name = Console.ReadLine();
                Console.Write("Прізвище: ");
                employes[i].Surname = Console.ReadLine();
                Console.Write("Дата народження у форматі \"DD.MM.YYYY\": ");
                employes[i].BirthDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Зарплата працівника: ");
                employes[i].Salary = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Успішно додано!");
                Console.WriteLine(new String('-', 25) + "\n");
            }
            //Додавання даних про продукти
            Console.WriteLine("Введіть дані про продукти!");
            for (int i = 0; i < products.Length; i++)
            {
                //----зчитування даних
                Console.WriteLine("----Продукт №" + i + "----");
                Console.Write("Назва продукту: ");
                string name = Console.ReadLine();
                Console.Write("Дата виготовлення: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Ціна: ");
                decimal price = decimal.Parse(Console.ReadLine());

                //----створення об'єкта
                products[i] = new Product(date);
                products[i].Name = name;
                products[i].Price = price;
                Console.WriteLine("Успішно додано!");
                Console.WriteLine(new String('-', 25) + "\n");
            }
        }
        public override string ToString()
        {
            return $"Name: {Name}\nCount Empoyers: {EmpCount}\n" +
                $"Average Salary: {AvgSalary}\nGDP: {GDP}";
        }

    }
}
