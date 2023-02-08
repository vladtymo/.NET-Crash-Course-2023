using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Line
    {
        public void Lines()
        {
            Console.WriteLine("Enter lenght of your line:");
            int Linelenght = int.Parse(Console.ReadLine());

            for (int i =0; i<=Linelenght; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }
    }
}
