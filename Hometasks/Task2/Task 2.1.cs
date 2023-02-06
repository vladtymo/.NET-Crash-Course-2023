using System;

namespace _1
{

    enum Week { Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть номер дня тижня");

            Week week = Enum.Parse<Week>(Console.ReadLine());

            switch (week)
            {
                case Week.Monday:
                    Console.WriteLine(Week.Monday);
                    break;
                case Week.Tuesday:
                    Console.WriteLine(Week.Tuesday);
                    break;
                case Week.Wednesday:
                    Console.WriteLine(Week.Wednesday);
                    break;
                case Week.Thursday:
                    Console.WriteLine(Week.Thursday);
                    break;
                case Week.Friday:
                    Console.WriteLine(Week.Friday);
                    break;
                case Week.Saturday:
                    Console.WriteLine(Week.Saturday);
                    break;
                case Week.Sunday:
                    Console.WriteLine(Week.Sunday);
                    break;
                default:
                    Console.WriteLine("Невiрно введені дані");
                    break;

            }

        }
    }
}
