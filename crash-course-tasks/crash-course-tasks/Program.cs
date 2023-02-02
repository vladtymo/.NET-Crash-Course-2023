
enum Days { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
enum Money {USD = 1, PLN, EUR };
enum Actions {Radius = 1, Area, Perimeter };

internal class Program
{

    private static void Main(string[] args)
    {
    }

    static void DaysCounter()
    {
        Console.WriteLine("Enter number of day");

        Days day = Enum.Parse<Days>(Console.ReadLine());

        switch (day)
        {
            case Days.Monday:
                Console.WriteLine("It`s Monday");
                break;
            case Days.Tuesday:
                Console.WriteLine("It`s Tuesday");
                break;
            case Days.Wednesday:
                Console.WriteLine("It`s Wednesday");
                break;
            case Days.Thursday:
                Console.WriteLine("It`s Thursday");
                break;
            case Days.Friday:
                Console.WriteLine("It`s Friday");
                break;
            case Days.Saturday:
                Console.WriteLine("It`s Saturday");
                break;
            case Days.Sunday:
                Console.WriteLine("It`s Sunday");
                break;
            default:
                Console.WriteLine("Invalid exeption");
                break;
        }
    }

    static void MoneyConverter()
    {
        Console.WriteLine("Enter sum in UAH");
        int sum = int.Parse(Console.ReadLine());

        double USD = 36.75;
        double EUR = 40.07;
        double PLN = 8.55;

        Console.WriteLine($"Convert UAH in \n" +
            $"{(int)Money.USD} - {Money.USD}\n" +
            $"{(int)Money.PLN} - {Money.PLN}\n" +
            $"{(int)Money.EUR} - {Money.EUR}\n"
            );

        Console.WriteLine("Enter number of convert");
        Money num = Enum.Parse<Money>(Console.ReadLine());
        double result = 0;

        switch (num)
        {
            case Money.USD:
                result = sum / USD;
                Console.WriteLine($"Your converted sum is {result} {Money.USD}");
                break;
            case Money.EUR:
                result = sum / EUR;
                Console.WriteLine($"Your converted sum is {result} {Money.EUR}");
                break;
            case Money.PLN:
                result = sum / PLN;
                Console.WriteLine($"Your converted sum is {result} {Money.PLN}");
                break;
            default:
                Console.WriteLine("Invalid exeption");
                break;
        }
    }

    static void CircleCalculation()
    {
        Console.WriteLine("Diameter in cm");
        int diameter = int.Parse(Console.ReadLine());

        Console.WriteLine($"---------------\n" +
            $"{(int)Actions.Radius} - {Actions.Radius}\n" +
            $"{(int)Actions.Area} - {Actions.Area}\n" +
            $"{(int)Actions.Perimeter} - {Actions.Perimeter}\n"
            );

        Console.WriteLine("Choose your action");
        Actions num = Enum.Parse<Actions>(Console.ReadLine());
        int result = 0;
        int radius = diameter / 2;

        switch (num)
        {
            case Actions.Radius:
                result = diameter / 2;
                Console.WriteLine($"Radius is {result} ");
                break;
            case Actions.Area:
                result = (int)Math.PI * radius * radius;
                Console.WriteLine($"Circle area = {result}");
                break;
            case Actions.Perimeter:
                result = 2 * (int)Math.PI * radius;
                Console.WriteLine($"Circle perimeter = {result}");
                break;
            default:
                Console.WriteLine("Invalid exeption");
                break;
        }
    }

    static void IsPalindrome()
    {
        Console.WriteLine("Enter a number");
        int num = int.Parse(Console.ReadLine());

        string num_str1 = Convert.ToString(num);
        char[] char_str = num_str1.ToCharArray();
        Array.Reverse(char_str);
        string num_str2 = new string(char_str);

        if (num_str1 == num_str2)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }



}