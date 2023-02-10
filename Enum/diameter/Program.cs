enum Value { radius = 1, area, perimeter }
internal class Diameter
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter diameter: ");

        float diameter = float.Parse(Console.ReadLine());

        Console.WriteLine("Сhoose an action: \n" +
            $"{(int)Value.radius} - Search {Value.radius}\n" +
            $"{(int)Value.area} - Search {Value.area}\n" +
            $"{(int)Value.perimeter} - Search {Value.perimeter}\n");

        Value function = Enum.Parse<Value>(Console.ReadLine());

        switch (function)
        {
            case Value.radius:
                Console.WriteLine($"Radius = {diameter / 2}");
                break;
            case Value.area:
                Console.WriteLine($"Area = {Math.PI * (diameter / 2) * (diameter / 2)}");
                break;
            case Value.perimeter:
                Console.WriteLine($"Perimeter = {2 * Math.PI * (diameter / 2)}");
                break;
            default:
                Console.WriteLine("Invalid value\n");
                break;
        }
    }
}
