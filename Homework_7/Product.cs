using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Task
{
    public enum Category { Drinks, Meat, Sweets }
    internal class Product
    {
        public string Name { get; set; }
        private readonly DateTime ManufactureDate;
        Category privateCategory;
        public Category pCategory { get { return privateCategory; } set { privateCategory = value; } }
        public decimal Price { get; set; }

        public Product(string name, DateTime mfd, decimal price) 
        { 
            this.Name = name;
            this.ManufactureDate= mfd;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"Name:{Name}, ManufactureDate:{ManufactureDate}, Category:{pCategory}, Price:{Price}";
        }
    }

}
