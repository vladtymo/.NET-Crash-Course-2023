using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    class Factory
    {
        public string Name { get; set; }
        public string[] Employees { get; set; }
        public string[] Products { get; set; }
        public double AvgSalary { get; }
        public double TotalSalary { get; }
        public double GDP { get; }
        public int EmpCount { get; }
        public void showInfo()
        {
            Console.WriteLine($" Name: {Name} Employees: {emEmployeesReturn()} ");
        }

        private string productsReturn()
        {

            foreach (string items in Products)
            {
                return items;
            }
            return null;
        }
        private string emEmployeesReturn()
        {
            foreach(var items in Employees)
            {
                return items;
            }
            return null;
        }
    }
}
