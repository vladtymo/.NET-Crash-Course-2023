
enum Circle { Radius = 1, Area, Perimeter };
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter diameter of the circle: ");
        double diameter = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose an option:\n" +
                            $"{(int)Circle.Radius} - {Circle.Radius}\n" +
                            $"{(int)Circle.Area} - {Circle.Area}\n" +
                            $"{(int)Circle.Perimeter} - {Circle.Perimeter}");


        Circle circle = Enum.Parse<Circle>(Console.ReadLine());

        switch (circle)
        {
            case Circle.Radius:
                Console.WriteLine($"Radius = {diameter/2}"); break;
            case Circle.Area:
                Console.WriteLine($"Area = {Math.PI * (Math.Pow((diameter/2),2))}"); break;
            case Circle.Perimeter:
                Console.WriteLine($"Perimeter = {2*Math.PI * (diameter / 2)}"); break;

            default: Console.WriteLine("Invalid option!"); break;
        }

        Console.WriteLine("Goodbye!");

    }
}