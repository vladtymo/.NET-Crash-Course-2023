namespace c2
{
    public class HelloWorld
    {

        enum Week { Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 }

        enum Converter_v { USD = 40, EUR = 44, PLN = 9 }

        public static void Main(string[] args)
        {


            Console.Write("Select a day of the week : ");

            Week day = Enum.Parse<Week>(Console.ReadLine());


            switch (day)
            {
                case Week.Monday:
                    Console.WriteLine($"\n\tDay - {Week.Monday}");
                    break;
                case Week.Tuesday:
                    Console.WriteLine($"\n\tDay - {Week.Tuesday}");
                    break;
                case Week.Wednesday:
                    Console.WriteLine($"\n\tDay - {Week.Wednesday}");
                    break;
                case Week.Thursday:
                    Console.WriteLine($"\n\tDay - {Week.Thursday}");
                    break;
                case Week.Friday:
                    Console.WriteLine($"\n\tDay - {Week.Friday}");
                    break;
                case Week.Saturday:
                    Console.WriteLine($"\n\tDay - {Week.Saturday}");
                    break;
                case Week.Sunday:
                    Console.WriteLine($"\n\tDay - {Week.Sunday}");
                    break;

                default: Console.WriteLine(" Error"); break;

            }

        }
    }
}