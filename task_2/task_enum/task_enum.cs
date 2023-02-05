
enum Week { Monday=1, Tuesday , Wednesday , Thursday, Friday, Saturday, Sunday }
internal class task_enum
{
    private static void Main(string[] args)
    {
        Console.Write("Enter number day: ");
        Week day = Enum.Parse<Week>(Console.ReadLine());
        switch (day)
        {
            case Week.Monday:
                Console.WriteLine($"{Week.Monday}");
                break;
            case Week.Tuesday:
                Console.WriteLine($"{Week.Tuesday}");
                break;
            case Week.Wednesday:
                Console.WriteLine($"{Week.Wednesday}");
                break;
            case Week.Thursday:
                Console.WriteLine($"{Week.Thursday}");
                break;
            case Week.Friday:
                Console.WriteLine($"{Week.Friday}");
                break;
            case Week.Saturday:
                Console.WriteLine($"{Week.Saturday}");
                break;
            case Week.Sunday:
                Console.WriteLine($"{Week.Sunday}");
                break;
            default:
                Console.WriteLine($"Invalid num day:{day}");
                break;
        }
    }
}