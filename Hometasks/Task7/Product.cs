using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum CategoryType { Food=1, Clothing=2, Electronics=3 }
    class Product
    {
        public string Name { get; set; }
        public readonly DateTime ManufactureDate;
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }

        public Product(string name, DateTime manufacturedate,CategoryType category,decimal price)
        {
            Name = name;
            ManufactureDate = manufacturedate;
            Category = category;
            Price = price;
        }

        public string PrintProdact()
        {
            return $"{Name}, Дата створення: {ManufactureDate.ToString("d")},Тип: {Category}, Цiна: {Price}";
        }
    }
}
