using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zavd 1");
        //CheckDate();
        Console.WriteLine("Zavd 2");
        //Rectangle();
        Console.WriteLine("Zavd 3");
        //Circle();
        Console.WriteLine("Zavd 4");
        //SecToTime();
        Console.WriteLine("Zavd 5");

        int year = 0;
        Console.WriteLine("Enter the year: ");
        year = CheckWordOnInt(year);

        isLeapYear(year);
    }

    //-----------------------------------------------------------------

    public static bool isLeapYear(int year)
    {
        if (((year % 4 == 0)&&(year % 100 !=0))||(year % 400 == 0))
        {
            Console.WriteLine("The year is a leap year");
            return true;
        }
        else
        {
            Console.WriteLine("The year is not a leap year");
            return false;
        }
    }


    public static void CheckDate()
    {
        int day = 0, month = 0, year = 0;

        Console.WriteLine("Enter the current day: ");
        day = CheckWordOnInt(day);

        Console.WriteLine("Enter the current month: ");
        month = CheckWordOnInt(month);

        Console.WriteLine("Enter the current year: ");
        year = CheckWordOnInt(year);

        if ((day < 1 || day > 31) || (month < 1 || month > 12) || (year > 2023))
        {
            Console.WriteLine("Wrong input data!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Ccurrent date is: {day}/{month}/{year}");
        }
    }

    public static void Rectangle()
    {
        float a = 0, b = 0;

        Console.WriteLine("Enter the value of side A: ");
        a = CheckWordOnFloat(a);
        Console.WriteLine("Enter the value of side B: ");
        b = CheckWordOnFloat(b);
        
        if (a < 0 || b < 0)
        {
            Console.WriteLine("Wrong input data!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"The area of rectangle is {a * b}");
            Console.WriteLine($"The perimeter of rectangle is {(a + b)*2}");
        }
    }

    public static void Circle()
    {
        float r = 0;

        Console.WriteLine("Enter the radius: ");
        r = CheckWordOnFloat(r);

        if (r < 0 )
        {
            Console.WriteLine("Wrong input data!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"The area of circle is {Math.PI*Math.Pow(r,2)}");
        }
    }

    public static void SecToTime()
    {
        int s = 0;

        Console.WriteLine("Enter seconds: ");
        s = CheckWordOnInt(s);
        int h = s / 3600;
        s -= h * 3600;
        int m = s / 60;
        s -= m * 60;

        Console.WriteLine($"Ccurrent date is: {h}:{m}:{s}");

    }


    //-----------------------------------------------------------------
    //-----------------------------------------------------------------

    private static float CheckWordOnFloat(float word)
    {
        try
        {
            word = Convert.ToSingle(Console.ReadLine());
            return word;
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong input data!");
        }

        return 0;
    }

    private static int CheckWordOnInt(int word)
    {
        try
        {
            word = Convert.ToInt32(Console.ReadLine());
            return word;
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong input data!");
        }

        return 0;
    }

    //-----------------------------------------------------------------




}