using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Arrays
    {
        public void Randomarray()
        {
            Random rnd = new Random();

            int[] a = new int[20];

            for (int i=0; i < 20; i++)
            {
                a[i] = rnd.Next(0, 100);
                Console.Write($"{a[i]}  ");
            }
        }
    }
}
