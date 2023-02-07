// enum - mainly used to assign the names or string values to integral constants,
// that make a program easy to read and maintain.
enum Direction { Forward = 1, Left, Right, Backward };

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Choose direction:\n" +
                            $"{(int)Direction.Forward} - {Direction.Forward}\n" +
                            $"{(int)Direction.Left} - {Direction.Left}\n" +
                            $"{(int)Direction.Right} - {Direction.Right}\n" +
                            $"{(int)Direction.Backward} - {Direction.Backward}");

        //int direction = int.Parse(Console.ReadLine());
        Direction direction = Enum.Parse<Direction>(Console.ReadLine());

        switch (direction)
        {
            case Direction.Forward:
                Console.WriteLine("We are going forward...");
                break; // go out of the switch statement
            case Direction.Right: Console.WriteLine("We are going right..."); break;
            case Direction.Left: Console.WriteLine("We are going left..."); break;
            case Direction.Backward: Console.WriteLine("We are going backward..."); break;

            default: Console.WriteLine("Invalid direction!"); break;
        }

        Console.WriteLine("Goodbye!");
    }
}
