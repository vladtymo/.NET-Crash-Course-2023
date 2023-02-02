using System;

enum Day { Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 };

enum Money { USD = 1, EUR = 2, PLN = 3 };

enum Characteristic { Радіус = 1, Площа = 2, Периметр = 3, Площу = 2 };

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        CheckNumber();
    }

    //-------завдання 1--------//
    static void DayChoose()
    {
        Console.Write("Введіть номер дня тижня: ");
        Day dayNumber = Enum.Parse<Day>(Console.ReadLine());

        switch (dayNumber)
        {
            case Day.Monday: Console.WriteLine("Monday"); break;
            case Day.Tuesday: Console.WriteLine("Tuesday"); break;
            case Day.Wednesday: Console.WriteLine("Wednesday"); break;
            case Day.Thursday: Console.WriteLine("Thursday"); break;
            case Day.Friday: Console.WriteLine("Friday"); break;
            case Day.Saturday: Console.WriteLine("Saturday"); break;
            case Day.Sunday: Console.WriteLine("Sunday"); break;
            default: Console.WriteLine("Такого дня немає!"); break;
        }
    }

    //---------завдання 2--------------//
    static void Converter()
    {
        Console.Write("Введіть сумму в UAH: ");
        double summUAN = Double.Parse(Console.ReadLine());

        Console.Write($"{(int)Money.USD} - {Money.USD}\n" +
            $"{(int)Money.EUR} - {Money.EUR}\n" +
            $"{(int)Money.PLN} - {Money.PLN}\n" +
            "Оберіть валюту для конвертації: ");

        Money chooseMoney = Enum.Parse<Money>(Console.ReadLine());

        double summConvert = 0;
        switch (chooseMoney)
        {
            case Money.USD: summConvert += summUAN / 36.75; break;
            case Money.EUR: summConvert += summUAN / 40.11; break;
            case Money.PLN: summConvert += summUAN / 8.56; break;
            default: Console.WriteLine("Такої валюти немає!"); break;
        }
        Console.WriteLine($"{summUAN} UAN = {Math.Round(summConvert,2)} {chooseMoney}");
    }

    //----------завдання 3----------//
    static void Circle()
    {
        Console.Write("Введіть довжину кола: ");
        double l = Double.Parse(Console.ReadLine());
        double r = l / (2 * Math.PI);
        Console.Write($"{(int)Characteristic.Радіус} - {Characteristic.Радіус} кола\n" +
            $"{(int)Characteristic.Площа} - {Characteristic.Площа} кола\n" +
            $"{(int)Characteristic.Периметр} - {Characteristic.Периметр} кола\n" +
            "Оберіть, що бажаєте знайти: ");

        Characteristic chooseCh = Enum.Parse<Characteristic>(Console.ReadLine());
        
        switch (chooseCh)
        {
            case Characteristic.Радіус: Console.WriteLine($"{Characteristic.Радіус} кола = {r}"); break;
            case Characteristic.Площа: Console.WriteLine($"{Characteristic.Площа} кола = {Math.Pow(r,2)*Math.PI}"); break;
            case Characteristic.Периметр: Console.WriteLine($"{Characteristic.Периметр} кола = {l}"); ; break;
            default: Console.WriteLine("Такого варіанту немає!"); break;
        }
    }

    //----------завдання 4----------//
    static void CheckNumber()
    {
        Console.Write("Введіть число: ");

        string s = Console.ReadLine();
        bool check = true;

        for(int i = 0; i < s.Length / 2; i++)
        {
            if(s[i] != s[s.Length - i - 1])
            {
                check = false; 
                break;
            }
        }

        if(check)  
            Console.WriteLine("Число є паліндромом");
        else
            Console.WriteLine("Число не є паліндромом");
    }
}

