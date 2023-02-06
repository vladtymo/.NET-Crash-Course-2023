using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int y;
            y = Convert.ToInt32(Console.ReadLine());

            if (y % 4 == 0)
            {
                Console.WriteLine($"В {y} році 366 днів ");
            }
            else
            {
                Console.WriteLine($"В {y} році 365 днів ");
            }

        }
    }
}
