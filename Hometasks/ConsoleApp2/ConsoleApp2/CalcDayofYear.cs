using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CalcDayofYear
    {
        public void CalcDay()
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("This year have a 366 day in year");
            }
            else
            {
                Console.WriteLine("This year have a 365 day in year");
            }
        }
    }
}
