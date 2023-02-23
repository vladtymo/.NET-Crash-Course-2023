using System;

namespace Exercise4
{
    enum CategoryType { Electronics, Food, Clothing, Home, Beauty }

    struct Product
    {
        public string Name { get; set; }
        public DateTime ManufactureDate { get; set; }
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Product name: {Name}, Manufacture date: {ManufactureDate.ToShortDateString()}, Category: {Category}, Price: {Price}";
        }
    }
}