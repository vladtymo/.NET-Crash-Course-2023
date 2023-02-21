using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    struct Product
    {
        private string Name { get; set; }
        private readonly DateTime ManufactureDate { get;}
        private decimal Price { get; set; }
        public enum CategoryType
        {
            First,
            Second,
            Third
        }

        Factory fact = new Factory();

        public class CategoryClass
        {
            public CategoryType Category { get; set; }
        }

        public void Prod_info()
        {

        }

        public void Prod_price()
        {
            fact.Products.Add(Price);
        }

        public decimal Prod_all_price()
        {
            decimal all_price = 0;
            foreach (var item in fact.Products)
            {
                all_price += item;
            }
            return all_price;
        }
    }
}
