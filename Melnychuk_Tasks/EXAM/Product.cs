using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class Product : IEditor
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public void Edit()
        {
            PrintInfo();
            Console.Write("\n\t\tВведіть нове ім'я: ");
            Name = Console.ReadLine();
            Console.Write("\n\t\tВведіть нову варітсть: ");
            Price = int.Parse(Console.ReadLine());
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\t| Price: {Price}\t| ");
        }
    }
}
