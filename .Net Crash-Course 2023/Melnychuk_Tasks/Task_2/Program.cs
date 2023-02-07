


using System;

public class HelloWorld
{

    enum Week {Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 }

    enum Converter_v {   USD = 40 , EUR = 44,PLN = 9 }

    public static void Main(string[] args)
    {

        /////// TASK //////
        Console.WriteLine(" /////// TASK //////");

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

        /////// TASK //////
        Console.WriteLine(" /////// TASK //////");

        Console.Write("\n\tEnter count :  ");

        float money = float.Parse(Console.ReadLine());




        Console.WriteLine("Choose currency :\n" +
                          $"{ (int)Converter_v.USD} - {Converter_v.USD }\n" +
                        $"{(int)Converter_v.EUR} - {Converter_v.EUR   }\n" +
                        $"{(int)Converter_v.PLN} - {Converter_v.PLN   }\n");

        Console.Write("\n\t Enter:");
        Converter_v currency = Converter_v.Parse<Converter_v>(Console.ReadLine());


        switch (currency)
        {
            case Converter_v.USD: Console.WriteLine($"You will get - {money / (float)Converter_v.USD} USD"); break;
            case Converter_v.EUR: Console.WriteLine($"You will get - {money / (float)Converter_v.EUR} EUR"); break;
            case Converter_v.PLN: Console.WriteLine($"You will get - {money / (float)Converter_v.PLN} PLN"); break;
            default: Console.WriteLine("Sorry,  we don't have the currency  you enter"); break;
        }

        /////// TASK //////
        Console.WriteLine(" /////// TASK //////");

        Console.Write("\n\t\tEnter Diameter -- ");

        float Diameter = float.Parse(Console.ReadLine());

        Console.WriteLine("\t\t Select an action " +
            "\n\tGet the radius of the circle    -- 1" +
            "\n\tGet the area of ​​the circle    -- 2" +
            "\n\tGet the perimeter of the circle -- 3");

        Console.Write("\nEnter : ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.WriteLine($"Radius = {Diameter/2}"); ;break;
            case 2: Console.WriteLine($"Area = {Math.PI *((Diameter/2)*(Diameter/2))}"); ; break;
            case 3: Console.WriteLine($"Perimeter = {2 * Math.PI * (Diameter / 2)}"); ; break;
            default: Console.WriteLine("Sorry(("); ; break;
        }







    }
}

