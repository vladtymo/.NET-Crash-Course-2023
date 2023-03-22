using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t\t Вирахування площі та переметру");

            Console.Write("First side: ");
            int f_side = int.Parse(Console.ReadLine());
            Console.Write("Second side: ");
            int s_side = int.Parse(Console.ReadLine());

            Console.WriteLine($"perimeter = {f_side * 2 + s_side * 2} | square = {f_side * s_side}");
        }
    }
}
