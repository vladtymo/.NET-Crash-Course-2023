using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hometask1.Interfaces;
namespace hometask1.CalcPropFigures
{
    public class Figures : IFigures
    {
        public void Square()
        {
            double storona1a;
            double storona2b;
            double perimeter;
            double area;
            Console.WriteLine("Введiть 1 сторону прямокутника: \n");
            string storona1 = Console.ReadLine();
            try
            {
                double.Parse(storona1);
                Console.WriteLine("Значення першої сторони введено вiрно");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Введено не правильне значення '{storona1}'");
            }
            storona1a = double.Parse(storona1);


            Console.WriteLine("Введiть 2 сторону прямокутника: \n");
            string storona2 = Console.ReadLine();
            try
            {
                double.Parse(storona2);
                Console.WriteLine("Значення другої сторони введено вiрно");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Введено не правильне значення '{storona2}'");
            }
            storona2b = double.Parse(storona2);

            perimeter = storona1a * 2 + storona2b * 2;
            area = storona1a * storona2b;
            Console.WriteLine($"Периметр прямокутника = {perimeter}");
            Console.WriteLine($"Площа прямокутника = {area}");
        }

        public void Circle()
        {
            double pi = 3.14;
            do
            {

                Console.WriteLine("Введiть радіус кола: \n");
                string radius = Console.ReadLine();
                try
                {
                    double radiusConvertedToDouble = double.Parse(radius);
                    Console.WriteLine("Радіус введено вiрно");
                    Console.WriteLine($"Площа кола = {2 * pi * radiusConvertedToDouble}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Введено не правильне значення '{radius}'");
                    continue;
                }
            } while (true);
        }
    }
}
