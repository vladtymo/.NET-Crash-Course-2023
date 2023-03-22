using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c1
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t\tВирахування площі кола");

            Console.Write("Radius: ");
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine($"Площа = {Math.PI * radius * radius}");
        }


    }
}
