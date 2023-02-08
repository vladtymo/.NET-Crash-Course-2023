using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swayze_task_2
{
    enum Weekname { Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 };
    public class Week
    {
        public void Weeks()
        {
            Console.Write("Hello, write a number day in week:");
            Weekname day = (Weekname)Enum.Parse(typeof(Weekname), Console.ReadLine());

            switch (day)
            {
                case Weekname.Monday:
                    Console.WriteLine("Monday");
                    break;
                case Weekname.Tuesday:
                    Console.WriteLine("Tuesday");
                    break;
                case Weekname.Wednesday:
                    Console.WriteLine("Wednesday");
                    break;
                case Weekname.Thursday:
                    Console.WriteLine("Thursday");
                    break;
                case Weekname.Friday:
                    Console.WriteLine("Friday");
                    break;
                case Weekname.Saturday:
                    Console.WriteLine("Saturday");
                    break;
                case Weekname.Sunday:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Day in week 7, please write 1 to 7 number.");
                    break;
            }
        }
    }
}
