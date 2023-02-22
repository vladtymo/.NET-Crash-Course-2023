using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace Tasks_7
{
/*     
Завдання 1:
Створити набір класів, які описують структуру підприємства:
1. Клас Factory, що містить:
• авто-властивість string Name;
• масив Employees[];
• масив Products[].
3. Клас Employee, що містить:
• авто-властивість string Name;
• авто-властивість string Surname;
• авто-властивість DateTime BirthDate;
• авто-властивість decimal Salary.
4. Структуру Product, що містить:
• авто-властивість string Name;
• поле DateTime ManufactureDate;
• авто-властивість CategoryType Category (enum);
• авто-властивість decimal Price.
Класи потрібно розмістити в окремих файлах з відповідними назвами.
Поле «ManufactureDate» для продукта зробити readonly, яке буде
встановлюватися у конструкторі.
*Для кожного класа/структури перевизначити метод ToString(), який 
буде повертати основну інформацію про об’єкт.

Завдання 2:
Додати 4-и властивості для класа «Factory»:
1. AvgSalary { get } - повертає середню ЗП по підприємству
Платформа Microsoft .NET і мова програмування C#
2. TotalSalary { get } – повертає сумарну ЗП
3. GDP { get } - повертає валовий дохід на 1-го працівника – сума 
вартості всіх товарів / на кількість працівників
4. EmpCount { get } - повертає загальну кількості працюючих

*Завдання 3:
Надати функціонал по створенню нового підприємства. Всі дані 
користувач вводить з клавіатури.
Для створення масиву об'єктів користувач спочатку вводить його розмір, 
а потім характеристики для кожного елемента
*/
	internal class Program
	{
		static void Display<T>(List<T> list,string message)
		{
			Console.WriteLine(new string('=', 50));
			Console.WriteLine("\t\t" + message);
			Console.WriteLine(new string('=', 50));
			foreach (T e in list) Console.WriteLine(e.ToString());
		} 
		static void Main(string[] args)
		{
			List<Employee> employees = new List<Employee>();
			List<Product> products = new List<Product>();		
			Console.Write("Enter name of company :");
			Factory factory = new Factory
			{
				Name = Console.ReadLine()
			};
			int num = 0;
			do
			{
				Console.Write("Enter number of Products on factory: ");
				if (!int.TryParse(Console.ReadLine(), out num) || num < 1)
				{
					Console.WriteLine("Invalid number.");
				}
				else break;
		    } while (true);
			for (int i = 1; i <= num; i++)
			{
				Console.WriteLine($"Product #{i}/{num}");
				Console.Write("Enter name of Product: ");
				string nameProd = Console.ReadLine();
				Product.CategoryType category;
				do
				{
					Console.Write("Enter the product category (SportsEquipment = 1, Toys = 2, Clothing = 3, Household = 4, Furniture = 5): ");
					if (!Enum.TryParse<Product.CategoryType>(Console.ReadLine(),out category) || (int)category < 1 || (int)category > 5)
					{
						Console.WriteLine("Invalid category.");
					}
					else break;
				} while (true);
				decimal price = 0;
				do
				{
					Console.Write("Enter the price of product :");
					if (!decimal.TryParse(Console.ReadLine(),out price) || price < 1)
					{
						Console.WriteLine("Invalid price.");
					}
					else break;
				} while (true);
				products.Add(new Product
				{
					Name = nameProd,
					Category = category,
					Price = price
				});
			}
			Console.WriteLine();
			do
			{
				Console.Write("Enter number of Employees on factory: ");
				if (!int.TryParse(Console.ReadLine(), out num)|| num < 0)
				{
					Console.WriteLine("Invalid number.");
				}
				else break;
			} while (true);
			for (int i=1; i <= num; i++) 
			{ 
				Console.WriteLine("Employee #" + i);
				Console.Write("Enter name: ");
				string nameEmp = Console.ReadLine();
				Console.Write("Enter surname: ");
				string surname = Console.ReadLine();
				DateTime dateTime;
				do
				{
                  Console.Write("Enter birthdate (dd MM yyyy): ");
					if (!DateTime.TryParse(Console.ReadLine(), out dateTime))
					{
						Console.WriteLine("Enter a correct date");
					}
					else break;
				} while (true);
				decimal salary = 0; 
				do
				{
					Console.Write("Enter salary: ");
					if (!decimal.TryParse(Console.ReadLine(),out salary) || salary < 1)
					{
						Console.WriteLine("Invalid salary.");
					}
					else break;
				} while (true);
				employees.Add(new Employee
				{
					Name = nameEmp,
					Surname = surname,
					BirthDate = dateTime, 
					Salary = salary
				});
			}
            factory.AddRange(products);
			factory.AddRange(employees);
            Console.WriteLine(new string('=', 50));
			Console.WriteLine("\t\tFactory");
			Console.WriteLine(new string('=', 50));
			Console.WriteLine(factory.ToString());
			Display(products,"Products");
			Display(employees,"Employees");
			Console.ReadKey();
		}
	}
}