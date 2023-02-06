
enum Week { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Choose a day from week:\n" +
                            $"{(int)Week.Sunday} - {Week.Sunday}\n" +
                            $"{(int)Week.Monday} - {Week.Monday}\n" +
                            $"{(int)Week.Tuesday}  -  {Week.Tuesday}\n" +
                            $"{(int)Week.Wednesday} - {Week.Wednesday}\n" +
                            $"{(int)Week.Thursday} - {Week.Thursday}\n" +
                            $"{(int)Week.Friday} - {Week.Friday}\n" +
                            $"{(int)Week.Saturday} - {Week.Saturday}");


        Week week = Enum.Parse<Week>(Console.ReadLine());

        switch (week)
        {
            case Week.Sunday:
                Console.WriteLine("Today is Sunday"); break;
            case Week.Monday:
                Console.WriteLine("Today is Monday"); break;
            case Week.Tuesday:
                Console.WriteLine("Today is Tuesday"); break;
            case Week.Wednesday:
                Console.WriteLine("Today is Wednesday"); break;
            case Week.Thursday:
                Console.WriteLine("Today is Thursday"); break;
            case Week.Friday:
                Console.WriteLine("Today is Friday"); break;
            case Week.Saturday:
                Console.WriteLine("Today is Saturday"); break;

            default: Console.WriteLine("Invalid day of week!"); break;
        }

        Console.WriteLine("Goodbye!");

    }
}