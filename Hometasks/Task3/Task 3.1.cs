using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжину лінії");


            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                Console.Write("-");
            }
        }
    }
}
