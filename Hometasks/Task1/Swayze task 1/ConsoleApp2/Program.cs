using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Format of year, month, day.");
                Console.WriteLine("2. Calculate area and perimetr of rectangle.");
                Console.WriteLine("3. Calculate area of circle by radius.");
                Console.WriteLine("4. Convert time in seconds to format 'HH:MM:SS'.");
                Console.WriteLine("5. Calculate days in year.");
                Console.Write("Which task you need to do?(Enter a number of task): ");
                int task = int.Parse(Console.ReadLine());

                switch (task)
                {
                    case 1:
                        FormattoYear Calcdate = new FormattoYear();
                        Calcdate.Formatofyear();
                        break;
                    case 2:
                        Rectangle rect = new Rectangle();
                        rect.CalcofRectangle();
                        break;
                    case 3:
                        Circle calcofCircle = new Circle();
                        calcofCircle.Radius();
                        break;
                    case 4:
                        CalcofTime time = new CalcofTime();
                        time.Time();
                        break;
                    case 5:
                        CalcDayofYear CalcDay = new CalcDayofYear();
                        CalcDay.CalcDay();
                        break;
                    default:
                        Console.WriteLine("I dont have this number of task.");
                        break;
                }
            }
        }
    }
}
