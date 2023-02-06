using System;
using System.Security.Cryptography;

namespace project
{
    enum Current { USD = 1, EUR = 2, PLN = 3};
    enum Variant { Radius = 1, Area = 2, Perimeter = 3};
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1            
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("EROR");
                    break;
            }

            //Task 2
            double h;
            Console.WriteLine("Enter the amount of money in UAN:");
            h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Сhoose which currency you want to transfer money to:\n " +
                $"{(int)Current.USD} - {Current.USD}\n" +
                $"{(int)Current.EUR} - {Current.EUR}\n" +
                $"{(int)Current.PLN} - {Current.PLN}");

            Current current = Enum.Parse<Current>(Console.ReadLine());

            switch (current)
            {
                case Current.USD:
                    Console.WriteLine($"Your money: {h * 0.027} USD");
                    break;
                case Current.EUR:
                    Console.WriteLine($"Your money: {h * 0.025} EUR");
                    break;
                case Current.PLN:
                    Console.WriteLine($"Your money: {h * 0.012} PLN");
                    break;
                default:
                    Console.WriteLine("EROR");
                    break;
            }

            //Task 3
            const double P = 3.14;
            double d;
            Console.Write("Enter d: ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose variant:\n" +
                $"{(int)Variant.Radius} - {Variant.Radius}\n" +
                $"{(int)Variant.Area} - {Variant.Area}\n" +
                $"{(int)Variant.Perimeter} - {Variant.Perimeter}");

            Variant variant = Enum.Parse<Variant>(Console.ReadLine());

            switch (variant)
            {
                case Variant.Radius:
                    Console.WriteLine($"Radius = {d / 2}");
                    break;
                case Variant.Area:
                    Console.WriteLine($"Area = {P * d}");
                    break;
                case Variant.Perimeter:
                    Console.WriteLine($"Perimetr = {2 * P * (d / 2)}");
                    break;
                default:
                    Console.WriteLine("EROR");
                    break;
            }

            //Task 4
            int number, r, sum = 0, temp;
            Console.WriteLine("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            temp = number;
            while (number > 0)
            {
                r = number % 10;
                sum = (sum * 10) + r;
                number = number / 10;
            }
            if (temp == sum)
                Console.Write("Number is palindrome");
            else
                Console.WriteLine("Number is no palindrome");
        }
    }

}