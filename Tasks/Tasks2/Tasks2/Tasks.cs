enum Day { Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 }
enum Currency { USD = 1, EUR = 2, PLN = 3, UAH = 4 }
enum Action { Radius = 1, Square = 2, Perimeter = 3 }
internal class Tasks
{
    private static void Main(string[] args)
    {
        //Task1();
        //Task2();
        //Task3();
    }

    private static void Task1()
    {
        Console.Write("Enter number of week day (1 - 7): ");
        Day day = Enum.Parse<Day>(Console.ReadLine());
        switch (day)
        {
            case Day.Monday: Console.WriteLine("Now is: " + Day.Monday); break;
            case Day.Tuesday: Console.WriteLine("Now is: " + Day.Tuesday); break;
            case Day.Wednesday: Console.WriteLine("Now is: " + Day.Wednesday); break;
            case Day.Thursday: Console.WriteLine("Now is: " + Day.Thursday); break;
            case Day.Friday: Console.WriteLine("Now is: " + Day.Friday); break;
            case Day.Saturday: Console.WriteLine("Now is: " + Day.Saturday); break;
            case Day.Sunday: Console.WriteLine("Now is: " + Day.Sunday); break;
            default: Console.WriteLine("Invalid day!"); break;
        }
    }

    private static void Task2()
    {
        Console.Write("Enter count of UAH: ");
        double uah = int.Parse(Console.ReadLine());
        Console.Write("Choose currency:\n" +
                            $"{(int)Currency.USD} - {Currency.USD}\n" +
                            $"{(int)Currency.EUR} - {Currency.EUR}\n" +
                            $"{(int)Currency.PLN} - {Currency.PLN}\n" +
                            $"{(int)Currency.UAH} - {Currency.UAH}\n" + "Enter: ");
        Currency currency = Enum.Parse<Currency>(Console.ReadLine());
        switch (currency)
        {
            case Currency.USD: Console.WriteLine($"{uah} UAH = {uah * 0.027} USD"); break;
            case Currency.EUR: Console.WriteLine($"{uah} UAH = {uah * 0.025} EUR"); break;
            case Currency.PLN: Console.WriteLine($"{uah} UAH = {uah * 0.12} PLN"); break;
            case Currency.UAH: Console.WriteLine($"{uah} UAH = {uah * 1} UAH"); break;
            default: Console.WriteLine("Invalid currency!"); break;
        }
    }

    private static void Task3()
    {
        Console.Write("Enter diameter: ");
        double d = int.Parse(Console.ReadLine());
        Console.Write("Choose action:\n" +
                            $"{(int)Action.Radius} - Find {Action.Radius}\n" +
                            $"{(int)Action.Square} - Find {Action.Square}\n" +
                            $"{(int)Action.Perimeter} - Find {Action.Perimeter}\n" + "Enter: ");
        Action action = Enum.Parse<Action>(Console.ReadLine());
        switch (action) 
        {
            case Action.Radius: Console.WriteLine($"{Action.Radius}: {d / 2}"); break;
            case Action.Square: Console.WriteLine($"{Action.Square}: {(d / 2)*(d / 2)}pi"); break;
            case Action.Perimeter: Console.WriteLine($"{Action.Perimeter}: {d}pi"); break;
            default: Console.WriteLine("Invalid action!"); break;
        }
    }
}