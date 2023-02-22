
using Task7;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Name: ");
        string nk = Console.ReadLine();
        Console.WriteLine("Eployees count: ");
        int ec = int.Parse(Console.ReadLine());
        Console.WriteLine("Product count");
        int pc = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        Factory factory = new Factory(ec, pc)
        {
            Name = nk,
            employees = new Employee[ec],
            products = new Product[pc],
        };
    }
}