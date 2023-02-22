using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._2
{
    struct Product
    {
        public string Name { get; set; }

        public readonly DateTime ManufactureDate;
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }

        public enum CategoryType
        {
            First =1,
            Second,
            Third
        }

        public Product(string Name, DateTime ManufactureDate, CategoryType Category, decimal Price)
        {
            this.Name = Name;
            this.ManufactureDate = ManufactureDate;
            this.Category = Category;
            this.Price = Price;
        }

        public override string ToString()
        {
            return $"Name: {Name}. ManufactureDate: {ManufactureDate.ToString("yyyy/MM/dd")}, Category: {Category}, Price: {Price.ToString()}";
        }
    }
}
