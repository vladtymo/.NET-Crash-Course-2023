using ConsoleApp7._2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write info about your company.");

            Console.Write("Factory name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Write info about your employees.");

            Console.WriteLine("How many people work in your factory: ");
            int empcount = int.Parse(Console.ReadLine());
            Employee[] Employees = new Employee[empcount];

            if (empcount < 0) 
            {
                Console.WriteLine("You dont cant have negative count of employ");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (empcount == 0) 
            {
                Console.WriteLine("If you dont have emloy, i dont help you.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            for(int i =0; i < empcount; i++)
            {
                Console.WriteLine("Name of employ: ");
                string empname = Console.ReadLine();

                Console.WriteLine("Surname of employ: ");
                string empsurname = Console.ReadLine();

                Console.WriteLine("Birthdate of employ(format: `yyyY/MM/DD`: ");
                DateTime BirthDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Which salary have employ: ");
                decimal empsalary = decimal.Parse(Console.ReadLine());

                Employees[i] = new Employee(empname, empsurname, BirthDate, empsalary);
                Console.WriteLine();

            }
            Console.WriteLine();


            Console.WriteLine("Okey, write info about your product?");

            Console.WriteLine("How many products you have: ");
            int prodcount = int.Parse(Console.ReadLine());
            Product[] Products = new Product[prodcount];
            if (prodcount < 0)
            {
                Console.WriteLine("You dont cant have negative count of product");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (prodcount == 0)
            {
                Console.WriteLine("If you dont have product, i dont help you.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine();

            for (int i = 0; i < prodcount; i++)
            {
                Console.WriteLine("Name of product: ");
                string prodname = Console.ReadLine();

                Console.WriteLine("Product Manufacture Date: ");
                DateTime manufacturedate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Product category(First, Second, Third): ");
                Product.CategoryType prodcategory = (Product.CategoryType)Enum.Parse(typeof(Product.CategoryType), Console.ReadLine());

                Console.WriteLine("Price of your product: ");
                decimal prodprice = decimal.Parse(Console.ReadLine());

                Products[i] = new Product(prodname, manufacturedate, prodcategory, prodprice);
                Console.WriteLine();

            }

            Factory company = new Factory(name, Employees, Products);

            Console.WriteLine("Company info:");
            Console.WriteLine(company.ToString());

            Console.WriteLine("Employee info:");
            foreach(Employee employee in company.Employees)
            {
                Console.WriteLine(employee.ToString());
            }

            Console.WriteLine("Product info:");
            foreach (Product product in company.Products)
            {
                Console.WriteLine(product.ToString());
            }

            Console.WriteLine($"Average of salary: {company.AvgSalary.ToString()}");
            Console.WriteLine($"Total salary: {company.TotalSalary.ToString()}");
            Console.WriteLine($"GDP: {company.GDP.ToString()}");
            Console.WriteLine($"Employ count: {company.EmpCount.ToString()}");
        }
    }
}