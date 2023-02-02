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
        

    }

    //-----------------------------------------------------------------

    public static void CheckDate()
    {
        float day = 0, month = 0, year = 0;

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

    //-----------------------------------------------------------------

    public static int Rectangle()
    {
        float a = 0, b = 0;

        a = CheckWordOnInt(a);
        b = CheckWordOnInt(b);
        
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
        return 0;
    }


    //-----------------------------------------------------------------

    public static int Circle()
    {
        float r = 0;

        r = CheckWordOnInt(r);

        if (r < 0 )
        {
            Console.WriteLine("Wrong input data!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"The area of circle is {Math.PI*Math.Pow(r,2)}");
        }
        return 0;
    }

    //-----------------------------------------------------------------

    private static float CheckWordOnInt(float word)
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

    //-----------------------------------------------------------------




}