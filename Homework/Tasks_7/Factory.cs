using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_7
{
	class Factory
	{
		public string Name { get; set; }
	    public List<Employee> Employees { get; set; } = new List<Employee>();
		public List<Product> Products { get; set; } = new List<Product>();
		public decimal AvgSalary { get=>Employees.Average(e => e.Salary); }
		public decimal TotalSalary => Employees.Sum(e => e.Salary);
		public decimal GDP => Products.Sum(p => p.Price) / Employees.Count;
		public int EmpCount {get=>Employees.Count;}
		public void Add(Employee employee) => Employees.Add(employee);
		public void Add(Product product)=> Products.Add(product);
		public void AddRange(List<Employee> employees) => Employees.AddRange(employees);
		public void AddRange(List<Product> products)=> Products.AddRange(products);
		public override string ToString()
		{
			return 
				$"Name of factory - {Name}\n" +
				$"Number of employees on factory - {EmpCount}\n" +
				$"Number of products on factory - {Products.Count}\n" +
				$"Avarage Salary - {AvgSalary}\n" +
				$"Total Salary - {TotalSalary}\n" +
				$"GDP - {GDP}\n" +
				$"{new string('`',50)}";
		}
	}
}
