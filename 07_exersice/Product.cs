using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseStructure
{
    enum CategoryType { Electronics, Food, Clothing, Home }
    internal class Product
    {
        public string Name { get; set; }
        public DateTime ManufactureDate { get; }
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }

        public Product(string name, DateTime manufactureDate, CategoryType category, decimal price)
        {
            Name = name;
            ManufactureDate = manufactureDate;
            Category = category;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Manufacture Date: {ManufactureDate}, Category: {Category}, Price: {Price}";
        }
    }
}