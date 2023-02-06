using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {


            double a, b, P, S;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            P = a + a + b + b;
            S = a * b;
            Console.WriteLine($"P= {P}");
            Console.WriteLine($"S= {S}");

           

        }
    }
}
