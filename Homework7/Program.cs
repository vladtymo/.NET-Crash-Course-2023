namespace lab_07_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory("Factory1");
            factory.AddEmployee("Nick", "White", new DateTime(1998, 4, 12), 13000);
            factory.AddProduct("Meat", new DateTime(2023, 2, 10), 150);
            factory.AddProduct("Coffee", new DateTime(2022, 12, 28), 45);
            factory.AddEmployee("Amanda", "Rose", new DateTime(2000, 7, 2), 7500);

            Console.WriteLine(factory.ToString());
        }
    }
}