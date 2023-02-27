using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Factory
    {
        public string Name { get; set; }
        public Employee[] Employees { get; set; }
        public Product[] Products { get; set; }




        public Factory (string name, Employee[] em, Product[] pr)
        {
            Name = name;
            Employees = em;
            Products = pr;
        }

        public decimal AvgSalary 
        {
            get
            {
                decimal sum=0;
                foreach (var i in this.Employees)
                {
                    sum += i.Salary;
                }

                return sum/Employees.Length;
            } 
        }

        public decimal TotalSalary
        {
            get
            {
                decimal sum = 0;
                foreach (var i in this.Employees)
                {
                    sum += i.Salary;
                }

                return sum ;
            }
        }

        public decimal GDP
        {
            get
            {
                decimal sum = 0;
                foreach (var i in this.Products)
                {
                    sum += i.Price;
                }

                return sum/Employees.Length;
            }
        }

        public int EmpCount
        {
            get
            {
                
                return Employees.Length;
            }
        }


       

        public void InfoFactory()
        {
            Console.WriteLine($"Завод: {Name}");
            Console.WriteLine();
            Console.WriteLine($"Працiвники:");
            Console.WriteLine();
            int i = 0;
            foreach (Employee item in Employees)
            {
                
                Console.WriteLine($"Працiвник №{i + 1}: {item.PrintEmloyee()}");
                i++;
            }
            //for (int i = 0; i < this.Employees.Length; i++)
            //{
            //    Console.WriteLine($"Працiвник №{i + 1}: {this.Employees[i].PrintEmloyee()}");
            //}

            Console.WriteLine();
            Console.WriteLine($"Продукти:");
            Console.WriteLine();
            int k = 0;
            foreach (Product item in Products)
            {
                Console.WriteLine($"Працiвник №{k + 1}: {item.PrintProdact()}");
                k++;
            }
            //for (int i = 0; i < this.Products.Length; i++)
            //{
            //    Console.WriteLine($"Продукт №{i + 1}: {this.Products[i].PrintProdact()}");
            //}

        }
    }


    
}
