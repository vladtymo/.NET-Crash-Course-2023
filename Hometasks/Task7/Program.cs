using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введiть назву завода:");
            string factoryName = Console.ReadLine();





            Console.WriteLine("Введiть к-ть працівників:");
            int empls = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[empls];

            for (int i = 0; i < empls; i++)
            {
                Console.WriteLine($"Вкажiть iм'я працiвника №{i+1}");
                string name = Console.ReadLine();

                Console.WriteLine($"Вкажiть прiзвище працiвника №{i + 1}");
                string surname = Console.ReadLine();

                Console.WriteLine($"Вкажiть дату народження працiвника №{i + 1}");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine($"Вкажiть зарплату працiвника №{i+1}");
                decimal salary = decimal.Parse(Console.ReadLine());

                employees[i] =new Employee(name, surname, birthDate, salary);
            }

            



            Console.WriteLine("Введiть к-ть продуктів:");
            int prod = int.Parse(Console.ReadLine());
            Product[] products = new Product[prod];

            for (int i = 0; i < prod; i++)
            {
                Console.WriteLine($"Вкажiть назву продукту №{i + 1}");
                string name = Console.ReadLine();

                Console.WriteLine($"Вкажiть дату створення продукту №{i + 1}");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine($"Вкажiть тип продукту №{i + 1}\n" +
                    $"1-Food\n" +
                    $"2-Clothing\n" +
                    $"3-Electronics");
                CategoryType tup = Enum.Parse<CategoryType>(Console.ReadLine());

                Console.WriteLine($"Вкажiть ціну продукту №{i + 1}");
                decimal salary = decimal.Parse(Console.ReadLine());

                products[i] = new Product(name, birthDate, tup, salary);
            }
            Factory factory = new Factory(factoryName,employees,products);


            factory.InfoFactory();
            Console.WriteLine();
            Console.WriteLine("Середня ЗП: "+ factory.AvgSalary);
            Console.WriteLine("Сумарна ЗП: " + factory.TotalSalary);
            Console.WriteLine("Валовий дохiд / 1 працiвник: " + factory.GDP);
            Console.WriteLine("К-ть працiвникiв: " + factory.EmpCount);
        }
    }
}
