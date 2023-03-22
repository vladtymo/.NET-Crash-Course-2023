namespace c2
{
    public class Program3
    {

        enum Week { Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 }

        enum Converter_v { USD = 40, EUR = 44, PLN = 9 }

        public static void Main3(string[] args)
        {

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
                case 1: Console.WriteLine($"Radius = {Diameter / 2}"); ; break;
                case 2: Console.WriteLine($"Area = {Math.PI * ((Diameter / 2) * (Diameter / 2))}"); ; break;
                case 3: Console.WriteLine($"Perimeter = {2 * Math.PI * (Diameter / 2)}"); ; break;
                default: Console.WriteLine("Sorry(("); ; break;
            }

        }
    }
}