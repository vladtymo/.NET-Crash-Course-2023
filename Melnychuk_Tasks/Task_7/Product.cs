using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClass
{

    enum CategoryType
    {
        type_1 = 1, type_2, type_3, type_4, type_5, type_6
    }
    internal struct Product
    {
        public string Name { get; set; }
        public readonly DateTime ManufactureDate;
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }

        public Product(string Name, DateTime ManufactureDate, CategoryType Category, decimal Price)
        {
            this.Name = Name;
            this.ManufactureDate = ManufactureDate;
            this.Category = Category;
            this.Price = Price;
        }
    }
}
