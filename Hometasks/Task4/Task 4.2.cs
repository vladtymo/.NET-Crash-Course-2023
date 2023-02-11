using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть рядок");
            string ryad = Console.ReadLine();

            string probil = " ";
            int k = 0;
            for (int i = 0; i < ryad.Length; i++)
            {
                if (ryad[i] == probil[0])
                {
                    ++k;
                }
            }

            Console.WriteLine($"В рядку {k} пробілів");
        }
    }
}
