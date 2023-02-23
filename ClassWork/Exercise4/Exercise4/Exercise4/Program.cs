namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть назву підприємства: ");
            string factoryName = Console.ReadLine();

            Console.Write("Введіть кількість працівників: ");
            int employeeCount = int.Parse(Console.ReadLine());

            Console.Write("Введіть кількість продуктів: ");
            int productCount = int.Parse(Console.ReadLine());

            // Створюємо об'єкт підприємства
            Factory factory = new Factory(factoryName, employeeCount, productCount);

            // Вводимо інформацію про кожного працівника
            for (int i = 0; i < employeeCount; i++)
            {
                Console.WriteLine($"Введіть інформацію про працівника {i + 1}:");
                Console.Write("Ім'я: ");
                string name = Console.ReadLine();
                Console.Write("Прізвище: ");
                string surname = Console.ReadLine();
                Console.Write("Дата народження (у форматі dd/MM/yyyy): ");
                DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.Write("Зарплата: ");
                decimal salary = decimal.Parse(Console.ReadLine());

                // Додаємо працівника до підприємства
                factory.AddEmployee(new Employee(name, surname, birthDate, salary));
            }

            // Вводимо інформацію про кожен продукт
            for (int i = 0; i < productCount; i++)
            {
                Console.WriteLine($"Введіть інформацію про продукт {i + 1}:");
                Console.Write("Назва: ");
                string name = Console.ReadLine();
                Console.Write("Дата виготовлення (у форматі dd/MM/yyyy): ");
                DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.Write("Категорія (Food, Clothes, Electronics): ");
                CategoryType category = (CategoryType)Enum.Parse(typeof(CategoryType), Console.ReadLine());
                Console.Write("Ціна: ");
                decimal price = decimal.Parse(Console.ReadLine());

                // Додаємо продукт до підприємства
                factory.AddProduct(new Product(name, manufactureDate, category, price));
            }

            // Виводимо інформацію про підприємство
            Console.WriteLine(factory.ToString());
        }
    }
}

