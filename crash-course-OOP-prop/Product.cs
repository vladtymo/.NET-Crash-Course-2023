using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_OOP_Prop
{
    public enum CategoryType { Laptop = 1, Smartphone, HouseholdAppliances };

    struct Product
    {
       
        private readonly DateOnly manufactureDate;
        public string Name { get; set; }
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }

        public Product(DateOnly manufactureDate)
        {
            this.manufactureDate = manufactureDate;
        }

        public void ToString()
        {
            Console.WriteLine("Product information");
            Console.Write($"Product: {Name}\n" +
                $"Price: {Price} \n" +
                $"Category: {Category} \n" +
                $"Date of manufactured: {manufactureDate} \n");
        }

    }
}
