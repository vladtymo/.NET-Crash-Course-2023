using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

enum Currency { USD = 1, EUR, PLN };
enum Circle { optR = 1, optS, optL };


internal class Program
{
    private static void Main(string[] args)
    {
        //Zavd1();
        //Zavd2();
        //Zavd3();
        //Zavd4();
    }

    private static void Zavd4()
    {
        Console.WriteLine("Please enter the number: ");
        string word = (Console.ReadLine());
        char[] wordArr = word.ToCharArray();
        int counter = 0;

        for (int i=0; i<wordArr.Length; i++)
        {
            if (wordArr[i] == wordArr[wordArr.Length - 1 - i])
            {
                counter ++;
            }
        }

        if (counter == wordArr.Length)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }
        
    }

    private static void Zavd3()
    {
        Console.WriteLine("Please enter the diameter: ");
        float diameter = Single.Parse(Console.ReadLine());
        float radius = diameter / 2;
        Console.WriteLine("Please enter the option:\n" + "1 - Search R\n" + "2 - Search S\n" + "3 - Search L\n");

        Circle circle = Enum.Parse<Circle>(Console.ReadLine());
        switch (circle)
        {
            case Circle.optR:
                Console.WriteLine($"R = {radius}");
                break;
            case Circle.optS:
                Console.WriteLine($"S = {Math.Pow(radius,2)*Math.PI}");
                break;
            case Circle.optL:
                Console.WriteLine($"L = {diameter*Math.PI}");
                break;
            default:
                Console.WriteLine("Incorrect option");
                break;
        }
    }
    
    private static void Zavd2()
    {
        Console.WriteLine("Please enter the amount in UAH: ");
        int uah = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please select the currency to convert:\n"+
            $"{(int)Currency.USD} = {Currency.USD}\n" +
            $"{(int)Currency.EUR} = {Currency.EUR}\n" +
            $"{(int)Currency.PLN} = {Currency.PLN}\n"
            );

        Currency cur = Enum.Parse<Currency>(Console.ReadLine());

        switch (cur)
        {
            case Currency.USD:
                Console.WriteLine($"{uah} UAH = {uah * 0.027} USD");
                break;
            case Currency.EUR:
                Console.WriteLine($"{uah} UAH = {uah * 0.025} EUR");
                break;
            case Currency.PLN:
                Console.WriteLine($"{uah} UAH = {uah * 0.12} PLN");
                break;
            default:
                Console.WriteLine("Wrong option!");
                break;
        }
    }

    private static void Zavd1()
    {
        Console.WriteLine("Please enter the day (1,2,3,4,5,6,7): ");
        int day = int.Parse(Console.ReadLine());
        switch (day)
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
                Console.WriteLine("Wrong day!!!");
                break;
        }
    }


}