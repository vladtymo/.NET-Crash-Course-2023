using System;

namespace Structure{
    enum CategoryType { A, B, C };
    struct Product{
        public string Name { get; set; }
        public readonly DateTime ManufactureDate;
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }
        public Product(string name, DateTime manufactureDate, CategoryType category, decimal price){
            Name = name;
            ManufactureDate = manufactureDate;
            Category = category;
            Price = price;
        }
        public override string ToString(){
            return $"Product: {Name} ({Category}), manufactured on {ManufactureDate.ToShortDateString()}";
        }
    }
}
