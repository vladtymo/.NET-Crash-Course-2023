using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    enum CategoryType { Meat, Seafood, Dairy, Bakery, Fruit, Vegetable, Drink, Confectionery, Oil, Frozen, Canned, Cereals, Alcohol, Spice, Extracts, Dietary, Organic, NoType }
    internal struct Product
    {
        public string Name { get; set; }
        public readonly DateTime ManufactureDate;
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
            Name = "NoName";
            ManufactureDate = DateTime.Now;
            Category = CategoryType.NoType;
            Price = 0;
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
            return $"{Name}:\nManufacture Date: {ManufactureDate};\nCategory: {Category};\nPrice: {Price}.\n";
        }
    }
}
