enum WeekDay
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
};

enum MoneyConverter
{
    USD,
    EUR,
    PLN
};

enum Circumference
{
    Radius,
    Area,
    Length 
};

class Task2
{
    static void Main()
    {
        // 1
        /*
        Console.WriteLine("Enter number of the day of the week: ");

        WeekDay number = Enum.Parse<WeekDay>(Console.ReadLine());

        switch (number)
        {
            case WeekDay.Monday:
                Console.WriteLine("Monday");
                break;
            case WeekDay.Tuesday:
                Console.WriteLine("Tuesday");
                break;
            case WeekDay.Wednesday:
                Console.WriteLine("Wednesday");
                break;
            case WeekDay.Thursday:
                Console.WriteLine("Thursday");
                break;
            case WeekDay.Friday:
                Console.WriteLine("Friday");
                break;
            case WeekDay.Saturday:
                Console.WriteLine("Saturday");
                break;
            case WeekDay.Sunday:
                Console.WriteLine("Sunday");
                break;
            default:
                break;
        }
        */

        //2
        /*
        Console.WriteLine($"{MoneyConverter.USD} - {(int)MoneyConverter.USD}\n" +
                          $"{MoneyConverter.EUR} - {(int)MoneyConverter.EUR}\n" +
                          $"{MoneyConverter.PLN} - {(int)MoneyConverter.PLN}\n " );
        Console.WriteLine("Choose a currency: ");

        MoneyConverter currency = Enum.Parse<MoneyConverter>(Console.ReadLine());

        Console.WriteLine("Enter value: ");
        float value = float.Parse(Console.ReadLine());


        switch (currency)
        {
            case MoneyConverter.USD:
                Console.WriteLine($"{value} UAH = {value / 36.5} USD");
                break;
            case MoneyConverter.EUR:
                Console.WriteLine($"{value} UAH = {value / 40.1} EUR");
                break;
            case MoneyConverter.PLN:
                Console.WriteLine($"{value} UAH = {value / 8.5} PLN");
                break;
            default:
                break;
        }
        */

        //3
        /*
        Console.Write("Enter diameter: ");
        float diameter = float.Parse(Console.ReadLine());

        Console.WriteLine($"\nGet {Circumference.Radius} - {(int)Circumference.Radius}\n" +
                          $"Get {Circumference.Area} - {(int)Circumference.Area}\n" +
                          $"Get {Circumference.Length} - {(int)Circumference.Length}\n " );
        Console.Write("Choose a options: ");
        Circumference options = Enum.Parse<Circumference>(Console.ReadLine());

        switch (options)
        {
            case Circumference.Radius:
                Console.WriteLine($"{Circumference.Radius} = {diameter / 2.0}");
                break;
            case Circumference.Area:
                Console.WriteLine($"{Circumference.Area} = {0.25 * Math.PI * Math.Pow(diameter,2)}");
                break;
            case Circumference.Length:
                Console.WriteLine($"{Circumference.Length} = {diameter*Math.PI}");
                break;
            default:
                break;
        }
        */

        //4
        
        Console.Write("Enter value: ");
        string value = Console.ReadLine();

        bool pal = false;

        for (int i = 0; i < value.Length/2; i++)
        {
            if (value[i] == value[value.Length - i - 1])
            {
                pal = true;
            }
            else
            {
                pal = false;
            }
        }

        if (pal)
        {
            Console.WriteLine("Palindrom");
        }
        else
        {
            Console.WriteLine("Not palindrom");
        }
    }

}
