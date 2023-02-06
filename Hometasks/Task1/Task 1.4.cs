using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {






            int sec, H, M;

            sec = Convert.ToInt32(Console.ReadLine());

            H = sec / 3600;
            sec = sec - H * 3600;
            M = sec / 60;
            sec = sec - M * 60;

            Console.WriteLine($"{H}:{M}:{sec}");



        }
    }
}
