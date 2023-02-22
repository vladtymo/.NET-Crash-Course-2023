using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_7
{
	struct Product
	{
		public enum CategoryType { SportsEquipment = 1, Toys, Clothing, Household, Furniture }
		public CategoryType Category { get; set; }
		public string Name { get; set; }
		readonly DateTime ManufactureDate;
		public decimal Price { get; set; }
		public Product()
		{
			ManufactureDate = DateTime.Now;
		}
		public override string ToString()
		{
			return
				$"Name of product - {Name}\n" +
				$"Date of Manufacturing - {ManufactureDate}\n" +
				$"Category - {Category}\n" +
				$"Price - {Price}$\n" +
				$"{new string('`',50)}";
		}
	}
}
