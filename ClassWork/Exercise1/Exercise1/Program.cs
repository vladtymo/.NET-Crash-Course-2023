using System.Diagnostics.Metrics;

class Program
{
    enum Day { Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 };
    static void Main(string[] args)
    {
        Day day;
        Console.WriteLine("Enter the number of week\n 1.Monday \n 2.Tuesday \n 3.Wednesday \n 4. Thursday \n 5. Friday\n 6.Saturday\n 7.Sunday");
        string input = Console.ReadLine();
        bool sucess = Enum.TryParse<Day>(input, out day);

        if (!sucess)
        {
            Console.WriteLine("entry {0} is not a valid day", input);
            return;
        }

        switch (day)
        {
            case Day.Monday:
                Console.WriteLine(Day.Monday);
                break;
            case Day.Tuesday:
                Console.WriteLine(Day.Tuesday);
                break;
            case Day.Wednesday:
                Console.WriteLine(Day.Wednesday);
                break;
            case Day.Thursday:
                Console.WriteLine(Day.Thursday);
                break;
            case Day.Friday:
                Console.WriteLine(Day.Friday);
                break;
            case Day.Saturday:
                Console.WriteLine(Day.Saturday);
                break;
            case Day.Sunday:
                Console.WriteLine(Day.Sunday);
                break;
        }
        Console.ReadKey();
    }

}
