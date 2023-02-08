enum Week { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
enum Currency { USD = 1, EUR = 2, PLN = 3}


// Task 1.
internal class Program
{
    private static void Main(string[] args)
    {


        Console.WriteLine("TASK 1");
        Console.WriteLine($"Enter data number (1 - 7)");
        Week week = Week.Parse<Week>(Console.ReadLine());

        switch (week)
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
                Console.WriteLine("ERROR");
                break;
        }



        // Task 2.

        Console.WriteLine("\n\nTASK 2");
        Console.Write("\nEnter count of your money in UAH: ");
        float uah = float.Parse(Console.ReadLine());
        const float eur = 43;
        const float pln = 9;
        const float usd = 42;
        Console.WriteLine("\n\nChoose currency:\n" +
            $"{usd} = {Currency.USD} ({(int)Currency.USD})\n" +
            $"{eur} = {Currency.EUR} ({(int)Currency.EUR})\n" +
            $"{pln} = {Currency.PLN} ({(int)Currency.PLN})\n");



        int choose = int.Parse(Console.ReadLine());
        switch (choose)
        {
            case 1:
                Console.WriteLine($"You get {uah / usd} USD");

                break;
            case 2:
                Console.WriteLine($"You get {uah / eur} EUR");
                break;
            case 3:
                Console.WriteLine($"You get {uah / pln} PLN");
                break;

            default:
                Console.WriteLine("ERROR");
                break;
        }

        //Task 3

        Console.WriteLine("\n\nTASK 3");
        Console.Write("\nEnter diameter - ");
        double diameter = double.Parse(Console.ReadLine());

        Console.WriteLine("\tEnter: " +
            "\n\tGet the radius of the circle    - 1" +
            "\n\tGet the S of ​​the circle    - 2" +
            "\n\tGet the perimeter of the circle - 3");

        Console.Write("\nEnter : ");
        int chooses = int.Parse(Console.ReadLine());

        switch (chooses)
        {
            case 1:
                Console.WriteLine($"R = {diameter / 2}");
                break;
            case 2:
                Console.WriteLine($"S = {Math.PI * ((diameter / 2) * (diameter / 2))}");
                break;
            case 3:
                Console.WriteLine($"P = {2 * Math.PI * (diameter / 2)}");
                break;
            default:
                Console.WriteLine("ERROR");
                break;
        }
    }
}
