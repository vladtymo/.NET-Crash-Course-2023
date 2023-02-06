using System;

namespace _3
{

    enum Diya { RadiusKola = 1, PloschaKola, PerumetrKola };
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть діаметер кола:");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Виберіть дію:");

            Console.WriteLine(
               $"{(int)Diya.RadiusKola}-{Diya.RadiusKola}\n" +
               $"{(int)Diya.PloschaKola}-{Diya.PloschaKola}\n" +
               $"{(int)Diya.PerumetrKola}-{Diya.PerumetrKola}\n");

            Diya diya = Enum.Parse<Diya>(Console.ReadLine());
            double r = d / 2;
            switch (diya)
            {
                case Diya.RadiusKola:

                    Console.WriteLine($"Радіус кола:  {r} ");
                    break;
                case Diya.PloschaKola:
                    double s = 3.14 * r * r;
                    Console.WriteLine($"Площа кола {s}  ");
                    break;
                case Diya.PerumetrKola:
                    double p = 2 * 3.14 * r;
                    Console.WriteLine($"Периметер кола {p}  ");
                    break;
                default:
                    Console.WriteLine("Невiрно введені дані");
                    break;
            }

        }
    }
}
