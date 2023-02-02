using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class FormattoYear
    {
        public void Formatofyear()
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter day: ");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine($"Result of format date = {day}/{month}/{year}");
        }
    }
}
