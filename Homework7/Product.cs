using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07_classes
{
    enum CategoryType{ Meat,Fish,Drinks,Sweets }
    internal class Product
    {
        public string Name { get; set; }
        private readonly DateTime manufactureDate;
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }
        public Product(string name, DateTime manufactureDate, decimal price)
        {
            this.Name = name;
            this.manufactureDate = manufactureDate;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"Name: {Name}, ManufactureDate: {manufactureDate}, Category: {Category}, Price: {Price} ";
        }

    }
}
