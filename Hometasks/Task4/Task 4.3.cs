using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть рядок");
            string ryad = Console.ReadLine();
            int Up = 0, Doun = 0;

            for (int i = 0; i < ryad.Length; i++)
            {
                if (Char.IsUpper(ryad[i]))
                {
                    ++Up;
                }

                if (Char.IsLower(ryad[i]))
                {
                    ++Doun;
                }
            }

            double X, x;
            X = Up / (double)ryad.Length * 100;
            x = Doun / (double)ryad.Length * 100;

            Console.WriteLine("Відсоток букв верхньго регістру: " + X + "%");
            Console.WriteLine("Відсоток букв нижнього регістру: " + x + "%");

        }
    }
}
