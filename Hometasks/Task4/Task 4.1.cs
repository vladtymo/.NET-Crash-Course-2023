using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть рядок");

            string ryad = Console.ReadLine();

            string[] words = ryad.Split(" ");
            Array.Reverse(words);
            string newRyad = String.Join(" ", words);
            Console.WriteLine(newRyad);
        }
    }
}
