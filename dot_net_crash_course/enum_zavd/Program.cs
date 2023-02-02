using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        //Zavd1();
        Zavd2();


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

    private static void Zavd2()
    {

    }


}