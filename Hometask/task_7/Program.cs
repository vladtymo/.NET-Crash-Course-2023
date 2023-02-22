namespace task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee employee = new Employee("Ivan", "Baggi", 12345, DateTime.Now);
            Console.WriteLine(employee);
        }
    }

    struct Product
    {
        public enum CategoryType { Sport = 1, Electronics, ForHome, Clothes }
        readonly private DateTime manufactureDate;
        private string name;
        private decimal price;
        public string Name { get; set; }
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }

    }
}