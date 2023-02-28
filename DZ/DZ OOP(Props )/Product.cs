using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    struct Product
    {
        public string Name { get; set; }
        public readonly DateTime ManufactureDate { get; }
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }
        public void showInfo()
        {
            Console.WriteLine($"Name: {Name} ManufactureDate {ManufactureDate} Category: {Category} and the prize is {Price}");
        }
    }

    public enum CategoryType
    {
        Sport,
        Clothing,
        Home
    }
}
