using System;

namespace _2
{

    enum Valuta { USD = 1, EUR, PLN };
    class Program
    {
        static void Main(string[] args)
        {

            const double USD = 37.28;
            const double EUR = 40.35;
            const double PLN = 8.53;

            Console.WriteLine("Введіть суму для обміну");
            double UAH = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Виберіть валюту\n" +
                $"{(int)Valuta.USD}-{Valuta.USD}: {USD}\n" +
                $"{(int)Valuta.EUR}-{Valuta.EUR}: {EUR}\n" +
                $"{(int)Valuta.PLN}-{Valuta.PLN}: {PLN}\n");

            Valuta valuta = Enum.Parse<Valuta>(Console.ReadLine());

            double result;

            switch (valuta)
            {
                case Valuta.USD:
                    result = UAH / USD;
                    Console.WriteLine($"Ви отримаєте {result} {Valuta.USD} ");
                    break;
                case Valuta.EUR:
                    result = UAH / EUR;
                    Console.WriteLine($"Ви отримаєте {result} {Valuta.EUR} ");
                    break;
                case Valuta.PLN:
                    result = UAH / PLN;
                    Console.WriteLine($"Ви отримаєте {result} {Valuta.PLN} ");
                    break;
                default:
                    Console.WriteLine("Невiрно введені дані");
                    break;
            }



        }
    }
}
