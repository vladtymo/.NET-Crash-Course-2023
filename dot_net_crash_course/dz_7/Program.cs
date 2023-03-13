namespace dz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory f1 = new Factory()
            {
                Name= "ATB Corp",
            };

            f1.SetEmployers();
            f1.GetEmployers();

            f1.SetProducts();
            f1.GetProducts();

            Console.WriteLine(f1.TotalSalary);
            Console.WriteLine(f1.AvgSalary);
            Console.WriteLine(f1.GDP);
            Console.WriteLine(f1.EmpCount);
        }
    }
}