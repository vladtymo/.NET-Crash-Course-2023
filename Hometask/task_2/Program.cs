internal class Program
{
    enum Circle { Square = 1, Radius, Perimeter }
    enum Valuta { USD = 1, EUR, PLN }
    enum Week { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    private static void Main(string[] args)
    {
        Console.WriteLine("--------Enum Circle--------");
        //---------EnumCircle
        EnumCircle();
        Console.WriteLine("--------Enum Money--------");
        //---------EnumMoney
        EnumMoney();
        Console.WriteLine("--------Enum Week--------");
        //---------EnumWeek
        EnumWeek();
        Console.WriteLine("--------Palindrom--------");
        //---------Palindrom
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPalindrom(number));
    }


    public static void EnumCircle()
    {
        Console.WriteLine("Enter diameter: ");
        double diameter = double.Parse(Console.ReadLine());
        Console.WriteLine("Choose operate: \n" +
                            $"{(int)Circle.Square} - to show {Circle.Square}\n" +
                            $"{(int)Circle.Radius} - to show {Circle.Radius}\n" +
                            $"{(int)Circle.Perimeter} - to show {Circle.Perimeter}\n");
        Circle circle = Enum.Parse<Circle>(Console.ReadLine());

        switch (circle)
        {
            case Circle.Square:
                Console.WriteLine("S = " + Math.PI * diameter / 2 + " units^2");
                break;
            case Circle.Radius:
                Console.WriteLine("R = " + diameter / 2 + " units");
                break;
            case Circle.Perimeter:
                Console.WriteLine("L = " + Math.PI * diameter + " units");
                break;
            default:
                Console.WriteLine("Invalid values");
                break;
        }
    }

    public static void EnumMoney()
    {
        const double usdCourse = 36.5686;
        const double eurCourse = 39.0644;
        const double plnCourse = 8.1639;

        Console.WriteLine("Enter number: ");
        double money = double.Parse(Console.ReadLine());
        Console.WriteLine("Choose valuta: \n" +
                            $"{(int)Valuta.USD} - {Valuta.USD}\n" +
                            $"{(int)Valuta.EUR} - {Valuta.EUR}\n" +
                            $"{(int)Valuta.PLN} - {Valuta.PLN}\n");
        Valuta valuta = Enum.Parse<Valuta>(Console.ReadLine());
        switch (valuta)
        {
            case Valuta.USD:
                Console.WriteLine("USD = " + usdCourse * money);
                break;
            case Valuta.PLN:
                Console.WriteLine("PLN = " + plnCourse * money);
                break;
            case Valuta.EUR:
                Console.WriteLine("EUR = " + eurCourse * money);
                break;
            default:
                Console.WriteLine("UAH = " + money);
                break;
        }
    }

    public static void EnumWeek()
    {
        Console.WriteLine("Choose week: \n" +
                           $"{(int)Week.Monday} - {Week.Monday}\n" +
                           $"{(int)Week.Tuesday} - {Week.Tuesday}\n" +
                           $"{(int)Week.Wednesday} - {Week.Wednesday}\n" +
                           $"{(int)Week.Thursday} - {Week.Thursday}\n" +
                           $"{(int)Week.Friday} - {Week.Friday} \n" +
                           $"{(int)Week.Saturday} - {Week.Saturday}\n" +
                           $"{(int)Week.Sunday} - {Week.Sunday}\n");
        Week weekDays = Enum.Parse<Week>(Console.ReadLine());

        switch (weekDays)
        {

            case Week.Monday:
                Console.WriteLine("Monday");
                break;
            case Week.Tuesday:
                Console.WriteLine("Tuesday");
                break;
            case Week.Wednesday:
                Console.WriteLine("Wednesday");
                break;
            case Week.Thursday:
                Console.WriteLine("Thursday");
                break;
            case Week.Friday:
                Console.WriteLine("Friday");
                break;
            case Week.Saturday:
                Console.WriteLine("Saturday");
                break;
            case Week.Sunday:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid values");
                break;
        }
    }

    public static bool IsPalindrom(int number)
    {
        List<int> digit = DivideDigits(number);
        for (int first = 0, last = digit.Count - 1; first < last; ++first, --last)
        {
            if (digit[first] != digit[last])
            {
                return false;
            }
        }

        return true;
    }

    public static List<int> DivideDigits(int number)
    {
        List<int> digit = new List<int>();

        while (number > 0)
        {
            digit.Add(number % 10);
            number /= 10;
        }

        return digit;
    }
}