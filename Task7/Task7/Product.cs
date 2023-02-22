
using System.ComponentModel;

namespace Task7
{
    internal class Product
    {

        public string Name { get; set; }
        private readonly DateTime ManufactureDate;
        public enum CategoryType {toys = 1, guitars, clothes};
       public CategoryType Category { get; set; }
        public decimal Price { get; set; }
    }
   
}
