enum Week { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
enum Currency { USD = 1, EUR = 2, PLN = 3 }
enum Circle { Radius = 1, Area, Perimeter }
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 1");
        Console.Write("Enter number of the day of week:" +
            $"\n{(int)Week.Monday}-{Week.Monday}" +
            $"\n{(int)Week.Tuesday}-{Week.Tuesday}" +
            $"\n{(int)Week.Wednesday}-{Week.Wednesday}" +
            $"\n{(int)Week.Thursday}-{Week.Thursday}" +
            $"\n{(int)Week.Friday}-{Week.Friday}" +
            $"\n{(int)Week.Saturday}-{Week.Saturday}" +
            $"\n{(int)Week.Sunday}-{Week.Sunday}\n");
        Week day = Enum.Parse<Week>(Console.ReadLine());
        switch (day)
        {
            case Week.Monday: Console.WriteLine($"\n{Week.Monday}"); break;
            case Week.Tuesday: Console.WriteLine($"\n{Week.Tuesday}"); break;
            case Week.Wednesday: Console.WriteLine($"\n{Week.Wednesday}"); break;
            case Week.Thursday: Console.WriteLine($"\n{Week.Thursday}"); break;
            case Week.Friday: Console.WriteLine($"\n{Week.Friday}"); break;
            case Week.Saturday: Console.WriteLine($"\n{Week.Saturday}"); break;
            case Week.Sunday: Console.WriteLine($"\n{Week.Sunday}"); break;
            default: Console.WriteLine("\nInvalid number!"); break;
        }

        Console.WriteLine("Task 2");
        Console.Write("Enter amound of currency(UAN):");
        int uan = int.Parse(Console.ReadLine());
        const double usd = 36.75, eur = 40.12, pln = 8.56;
        Console.Write("\nChoose which currency to convert to:" +
            $"\n{(int)Currency.USD}-{Currency.USD}" +
            $"\n{(int)Currency.EUR}-{Currency.EUR}" +
            $"\n{(int)Currency.PLN}-{Currency.PLN}\n");
        Currency currency = Enum.Parse<Currency>(Console.ReadLine());
        switch (currency)
        {
            case Currency.USD: Console.WriteLine($"\n{uan} UAN = {uan / usd}"); break;
            case Currency.EUR: Console.WriteLine($"\n{uan} UAN = {uan / eur} EUR"); break;
            case Currency.PLN: Console.WriteLine($"\n{uan} UAN = {uan / pln} PLN"); break;
            default: Console.WriteLine("\nInvalid currency!!!"); break;
        }

        Console.WriteLine("Task 3");
        Console.Write("Enter diameter:");
        double d = double.Parse(Console.ReadLine());
        int k = 4;
        while (k != 0)
        {
            Console.Write("\nChoose an action:" +
                $"\n{(int)Circle.Radius}-{Circle.Radius}" +
                $"\n{(int)Circle.Area}-{Circle.Area}" +
                $"\n{(int)Circle.Perimeter}-{Circle.Perimeter}\n");
            Circle action = Enum.Parse<Circle>(Console.ReadLine());
            switch (action)
            {
                case Circle.Radius: Console.WriteLine($"\n{Circle.Radius} = {d / 2}"); break;
                case Circle.Perimeter: Console.WriteLine($"\n{Circle.Perimeter} = {Math.PI * d}"); break;
                case Circle.Area: Console.WriteLine($"\n{Circle.Area} = {(Math.PI * d * d) / 4}"); break;
                default: Console.WriteLine("\nInvalid date!!!"); break;
            }
            --k;
        }

        Console.WriteLine("Task 4");
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int originalNumber = number;
        int reverseNumber = 0;
        while (number != 0)
        {
            int lastDigit = number % 10;
            reverseNumber = reverseNumber * 10 + lastDigit;
            number = number / 10;
        }
        if (originalNumber == reverseNumber) { Console.WriteLine($"{originalNumber} is palindrome"); }
        else { Console.WriteLine($"{originalNumber} is not a palindrome"); }
    }
}