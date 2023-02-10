enum Week { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the day of the week number: \n");

        Week day = Enum.Parse<Week>(Console.ReadLine());

        switch (day)
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
                Console.WriteLine("Invalid day");
                break;
        }
    }
}
