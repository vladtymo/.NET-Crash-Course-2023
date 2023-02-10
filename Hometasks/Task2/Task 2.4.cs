using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число");
            string x = Console.ReadLine();

            char[] xx = x.ToCharArray();
            Array.Reverse(xx);
            string xxx = new string(xx);

            if (x == xxx)
            {
                Console.WriteLine("Число поліндром");
            }
            else
            {
                Console.WriteLine("Число не поліндром");
            }

        }
    }
}
