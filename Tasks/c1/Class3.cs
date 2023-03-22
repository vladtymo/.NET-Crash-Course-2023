using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c1
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість секунд : ");
            int second_count = int.Parse(Console.ReadLine());

            int hours = second_count / 3600;
            second_count -= hours * 3600;
            int minutes = second_count / 60;
            second_count -= minutes * 60;
            int seconds = second_count;

            Console.WriteLine($"{hours}/{minutes}/{seconds}");

            Console.Write("Введіть рік");

            double year_v = double.Parse(Console.ReadLine());

            if (year_v % 4 == 0)
            {
                if (year_v % 100 != 0 || (year_v % 100 == 0 && year_v % 400 == 0))
                {
                    Console.WriteLine("Рік має 366 днів");
                }
            }
            else { Console.WriteLine(" Рік має 365 днів"); }

            Console.ReadKey();
        }
    }
}
