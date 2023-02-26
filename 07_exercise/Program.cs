using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter factory name:");
            string factoryName = Console.ReadLine();

            Console.WriteLine("Enter number of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[numEmployees];
            for(int i = 0; i < numEmployees; i++)
            {
                Console.WriteLine($"Enter employee {i + 1} name: ");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter employee {i + 1} surname: ");
                string surname = Console.ReadLine();

                Console.WriteLine($"Enter employee {i + 1} birth date (yyyy-mm-dd):");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine($"Enter employee {i + 1} salary:");
                decimal salary = decimal.Parse(Console.ReadLine());

                employees[i] = new Employee { Name = name, Surname = surname, BirthDate = birthDate, Salary = salary };
            }

            Console.WriteLine("Enter number of products:");
            int numProducts = int.Parse(Console.ReadLine());

            Product[] products = new Product[numProducts];
            for (int i = 0; i < numProducts; i++)
            {
                Console.WriteLine($"Enter product {i + 1} name:");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter product {i + 1} manufacture date (yyyy-mm-dd):");
                DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine($"Enter employee {i + 1} salary:");
                decimal salary = decimal.Parse(Console.ReadLine());
            }
        }
    }
}
