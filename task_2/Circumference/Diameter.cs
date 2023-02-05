enum Value { Radius = 1, Square, Perimeter }

internal class Diameter
{
    private static void Main(string[] args)
    {
    
        Console.Write("Enter diameter: ");
        float diameter = float.Parse(Console.ReadLine());
        Console.WriteLine("Choose function:\n" +
                            $"{(int)Value.Radius} - Search {Value.Radius}\n" +
                            $"{(int)Value.Square} - Search {Value.Square}\n" +
                            $"{(int)Value.Perimeter} - Search {Value.Perimeter}\n");
        Value function = Enum.Parse<Value>(Console.ReadLine());

        switch (function)
        {
            case Value.Radius:
                Console.WriteLine($"Radius = {diameter/2}");
                break;
            case Value.Square:
                Console.WriteLine($"Square = {Math.PI* (diameter / 2)* (diameter / 2)}");
                break;
            case Value.Perimeter:
                Console.WriteLine($"Perimeter = {2*Math.PI*(diameter / 2)}");
                break;
            default:
                Console.WriteLine("Invalid value\n");
                break;
        }

    }
}