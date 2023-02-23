using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_OOP_Prop
{
    internal class Factory
    {
        public string Name { get; set; }

        private Product[] products = { };

        private Employee[] employees = { };

        public int AvgSalary
        {
            get
            {
                int avgSalary = 0;

                for (int i = 0; i < employees.Length; i++)
                {
                    avgSalary += (int)employees[i].Salary;
                }

                return avgSalary / employees.Length;
            }
        }

        public int TotalSalary
        {
            get 
            {
                int totalSalary = 0;
                for (int i = 0; i < employees.Length; i++)
                {
                    totalSalary += (int)employees[i].Salary;
                }

                return totalSalary;
            }
        }

        public int GDP
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < products.Length; i++)
                {
                    sum += (int)products[i].Price;
                }

                return sum / employees.Length;
            }
        }
        
        public int EmpCount 
        {
            get
            {
                return employees.Length;
            }
        }

        public Factory(Product[] products, Employee[] employees)
        {
            this.products = products;
            this.employees = employees;
            Name = "No name";
        }

        public void ToString()
        {
            Console.WriteLine("\nFactory information");
            Console.Write($"Name: {Name}\n");

            Console.WriteLine("All products");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{products[i].Category}: {products[i].Name} | {products[i].Price}\n" +
                    $"---------------------------------------------");
            }

            Console.WriteLine("All employees");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"{employees[i].Name} {employees[i].Surname} | {employees[i].Salary} | {employees[i].DateBirth}\n" +
                    $"---------------------------------------------");
            }

        }
    }
}
