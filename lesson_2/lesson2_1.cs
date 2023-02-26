using System;

namespace DayOfWeek
{
   enum DaysOfWeek
   {
      Monday = 1,
      Tuesday,
      Wednesday,
      Thursday,
      Friday,
      Saturday,
      Sunday
   }
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number representing a day of the week:");
        int dayNumber = Convert.ToInt32(Console.ReadLine());
        DaysOfWeek day = (DaysOfWeek)dayNumber;

        switch (day)
        {
            case DaysOfWeek.Monday:
                Console.WriteLine("Monday");
                break;
            case DaysOfWeek.Tuesday:
                Console.WriteLine("Tuesday");
                break;
            case DaysOfWeek.Wednesday:
                Console.WriteLine("Wednesday");
                break;
            case DaysOfWeek.Thursday:
                Console.WriteLine("Thursday");
                break;
            case DaysOfWeek.Friday:
                Console.WriteLine("Friday");
                break;
            case DaysOfWeek.Saturday:
                Console.WriteLine("Saturday");
                break;
            case DaysOfWeek.Sunday:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day number");
                break;
        }
     }
  }
}
