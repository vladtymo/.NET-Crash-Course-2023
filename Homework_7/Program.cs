namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Factory factory = new Factory("Factory");
            factory.AddEmployee("Bob", "Marley", new DateTime(2000,12,2), 10000);
            factory.AddEmployee("Lol", "Kek", new DateTime(2000, 2, 2), 8000);
            factory.AddProduct("Cola", new DateTime(2023, 12, 12), 35);
            factory.AddProduct("Meat", new DateTime(2023, 10, 22), 200);

            Console.WriteLine(factory.ToString());   
        }
    }
}