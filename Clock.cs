using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hometask1.Interfaces;
namespace hometask1.TimeDate
{
    public class Clock : IClock
    {
        public void DateFunctionNow()
        {
            var uaCulture = new CultureInfo("ua-UA");
            Console.WriteLine("Введiть дату народження в форматi (DD.MM.YYYY): \n");
            string input = Console.ReadLine();
            DateTime userDate;
            if (DateTime.TryParse(input, uaCulture.DateTimeFormat, DateTimeStyles.None, out userDate))
                Console.WriteLine($"{userDate.Day}/{userDate.Month}/{userDate.Year}");
            else
                Console.WriteLine("Неправильне введення дати");
        }

        public void PrintYearDays()
        {
            
            do
            {

                Console.WriteLine("Введiть рiк: \n");
                string yearRead = Console.ReadLine();
                try
                {
                    int year = int.Parse(yearRead);
                    Console.WriteLine("Введений Рiк: {0};\nДнiв в роцi {1}.", year, DateTime.IsLeapYear(year) ? 366 : 365);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Введено не правильне значення '{yearRead}'");
                    continue;
                }
            } while (true);



        }

        public void SecondsToTime()
        {
            do
            {

                Console.WriteLine("Введiть секунди: \n");
                string secondsRead = Console.ReadLine();
                try
                {
                    int seconds = int.Parse(secondsRead);
                    TimeSpan t = TimeSpan.FromSeconds(seconds);
                    Console.WriteLine(t.ToString());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Введено не правильне значення '{secondsRead}'");
                    continue;
                }
            } while (true);
        }
    }
}
