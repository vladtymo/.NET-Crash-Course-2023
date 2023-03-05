using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    enum CategoryType {Bake, Chocolate,Сandy }
    internal class Product
    {
        public string Name { get; set; }
        public DateTime ManufectureDate { get; }
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"ManufectureDate: {ManufectureDate}\n" +
                   $"Category: {Category}\n" +
                   $"Price: {Price}";
        }
        public Product(string name,DateTime manufectureDate,CategoryType category,decimal price)
        {
            Name = name;
            ManufectureDate = manufectureDate;
            Category = category;
            Price = price;                
        }
    }
}
