using System;
using System.Security.Cryptography;

namespace project
{ 
    class Program
    { 
        static void Main(string[] args) 
        {
            ////Task 1
            int day, month, year;
            Console.Write("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter day: ");
            day = Convert.ToInt32(Console.ReadLine());
            DateTime date1 = new DateTime(day, month, year);
            Console.WriteLine($"Date: {date1.ToString("dd/mm/yyyy")}");

            //Task 2
            int a, b;
            float P, S;
            Console.Write("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            P = 2 * a + 2 * b;
            S = a * b;
            Console.WriteLine($"P = {P}");
            Console.WriteLine($"S = {S}");

            //Task 3
            double r, S;
            Console.Write("Enter r: ");
            r = Convert.ToInt32(Console.ReadLine());
            S = 3.14 * r * r;
            Console.WriteLine($"S = {S}");

            //Task 4
            int s, m, h, sec;
            Console.Write("Enter time (in seconds: )");
            sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{sec}");
            h = sec / 3600;
            m = (sec - 3600 * h) / 60;
            s = sec - m * 60 - h * 3600;
            DateTime time1 = new DateTime(1, 1, 1, h, m, s);
            Console.WriteLine($"Time = {time1.ToString("hh:mm:ss")}");

            //Task 5
            int year;
            Console.Write("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
                Console.WriteLine($"{year} year has 366 days");
            else
                Console.WriteLine($"{year} year has 365 days");
         }
    }

}