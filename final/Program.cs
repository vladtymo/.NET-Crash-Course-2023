using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace final{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            KrustyKrab krustyKrab = new KrustyKrab();
            //krustyKrab.SaveMenu();
            krustyKrab.LoadMenu();
            krustyKrab.ShowMenu();

            krustyKrab.AddEmployee(new Chef("SpongeBob",20,5000.01m,new DateTime(2003,1,1)));
            krustyKrab.AddEmployee(new Cashier("Squidward",30,2000.00m,new DateTime(2001,2,3)));
            //krustyKrab.SaveEmployees();
            
            //krustyKrab.Order();
            // krustyKrab.SaveMenu();krustyKrab.SaveMenu();
            // krustyKrab.LoadMenu();
            // krustyKrab.Sort(new CompareByName());
            // krustyKrab.Sort(new CompareByPrice());
            krustyKrab.RemoveItem();
            krustyKrab.ShowMenu();
        }
    }
}