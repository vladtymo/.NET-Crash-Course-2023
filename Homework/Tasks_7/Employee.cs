using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_7
{
	class Employee
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime BirthDate { get; set; }
		public decimal Salary { get; set; }
		public override string ToString()
		{
			return 
				$"Full name of employee - {Name} {Surname}\n" +
				$"Birth Date - {BirthDate.ToString("dd.MM.yyyy")}\n" +
				$"Salary - {Salary}\n" +
				$"{new string('`',50)}";
		}
	}
}
