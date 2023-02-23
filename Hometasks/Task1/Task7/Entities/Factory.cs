namespace Task7.Entities
{
    public class Factory
    {
        public string Name { get; set; }
        public Employee[] Employees { get; set; }
        public Product[] Products { get; set; }

        public float AvgSalary
        {
            get
            {
                return Employees.Average(x => x.Salary);
            }
        }

        public float TotalSalary
        {
            get
            {
                return Employees.Sum(x => x.Salary);
            }
        }

        public double GDP
        {
            get
            {
                return Products.Sum(x => x.Price) / Employees.Length;
            }
        }

        public int EmpCount
        {
            get
            {
                return Employees.Length;
            }
        }
    }
}