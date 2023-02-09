using System.ComponentModel;

namespace Prog
{ 
    enum Days { Monday = 1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday};
    enum Currency { UAH = 1, USD, EUR , PLN };
    enum Circle { Radius =1, Area, Perimeter }
    
    class Program
    {

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            #region Task_1 Користувач вводить номер дня тижня (1-7). Вивести на екрна повну назву цього дня. 
            //
            //    Console.Write("Enter number of day :");

            //  Days days = Enum.Parse<Days>(Console.ReadLine());

            //    switch(days)
            //    {
            //          case Days.Monday:
            //            Console.WriteLine(Days.Monday);
            //            break;
            //        case Days.Tuesday:
            //            Console.WriteLine(Days.Tuesday);
            //            break;
            //        case Days.Wednesday:
            //            Console.WriteLine(Days.Wednesday);
            //            break;
            //        case Days.Thursday:
            //            Console.WriteLine(Days.Thursday);
            //            break;
            //        case Days.Friday:
            //            Console.WriteLine(Days.Friday);
            //            break;
            //        case Days.Saturday:
            //            Console.WriteLine(Days.Saturday);
            //            break;
            //        case Days.Sunday:
            //            Console.WriteLine(Days.Sunday);
            //            break;

            // }
            #endregion
            #region Task_2 Написати конвертер валют (UAH, USD, EUR, PLN), користувач має можливість ввести кількість валюти в UAH та вибрати в яку він бажає конвертувати величину.
            //Console.Write("Введіть число в гривнях :");
            //int value = int.Parse(Console.ReadLine());

            //Console.Write("Введіть валюту (1-UAH,2-USD,3-EUR,4-PLN):");
            //Currency currency = Enum.Parse<Currency>(Console.ReadLine());
            //switch (currency)
            //{
            //    case Currency.UAH:
            //        value *= 1;
            //        break;
            //    case Currency.USD:
            //        value *= 10;
            //        break;
            //    case Currency.PLN:
            //        value *= 100;
            //        break;
            //    case Currency.EUR:
            //        value *= 1000;
            //        break;
            //    default: Console.WriteLine("Введіть коректне значення");break;
            //}
            //Console.WriteLine($"Після конвертації в {curency}:{value}");
            #endregion
            #region Task_3
            ///3 - Користувач вводить діаметр окружності та вибирає дію, яку бажає виконати:
            // 1 - Отримати радіус кола
            // 2 - Отримати площу кола
            // 3 - Отримати периметр кола
            //Console.Write("Введіть діаметр:");
            //int diametr = int.Parse(Console.ReadLine());
            //Console.Write("Виберіть дію :\n" +
            //              "1 - Отримати радіус кола\n" +
            //              "2 - Отримати площу кола\n" +
            //              "3 - Отримати периметр кола\n");
            //Circle circle = Enum.Parse<Circle>(Console.ReadLine());
            //switch (circle)
            //{
            //    case Circle.Radius: Console.WriteLine( $"Радіус :{diametr/2}");break;
            //    case Circle.Area: Console.WriteLine($"Площа :{2 * Math.PI * Math.Pow((diametr/2),2) }"); break;
            //    case Circle.Perimeter: Console.WriteLine($"Периметр :{Math.PI * diametr}"); break;
            //        default : Console.WriteLine("Введіть правильний номер!"); break;
            //}

            #endregion
            #region Task_4  - Користувач вводить число, визначити чи воно є паліндромом.

            int number, tmp_number, reverse = 0;
            Console.Write("Введіть число :");
            number = int.Parse(Console.ReadLine());
            tmp_number = number;

            while (tmp_number != 0)
            {
                reverse = (reverse * 10) + tmp_number % 10;
                tmp_number /= 10;
            }
            if (number == reverse)
            {
                Console.WriteLine(" Це Поліндром");
            }
            else
            {
                Console.WriteLine(" Це не Поліндром");
            }

            #endregion

            Console.ReadKey();
        }   
    }
}
