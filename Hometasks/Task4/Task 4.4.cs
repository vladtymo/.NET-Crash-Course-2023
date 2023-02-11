using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть словосполучення");
            string ryad = Console.ReadLine();
            string ryad1 = ryad.Trim();

            string ryad2 = ryad1.ToUpper();


            string probil = " ";
            string abr = ryad2[0].ToString();

            for (int i = 0; i < ryad2.Length; i++)
            {
                if (ryad2[i] == probil[0])
                {
                    abr = new string(abr + ryad2[i + 1]);

                }
            }

            Console.WriteLine(abr);



        }
    }
}
