
enum Direction { Forward = 1, Left, Right, Backward};


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Choose Direction\n" +
            $"{(int)Direction.Forward} = {Direction.Forward}\n"+
            $"{(int)Direction.Left} = {Direction.Left}\n" +
            $"{(int)Direction.Right} = {Direction.Right}\n" +
            $"{(int)Direction.Backward} = {Direction.Backward}\n"
            );

        Direction direction = Enum.Parse<Direction>(Console.ReadLine());

        switch (direction)
        {
            case Direction.Forward:
                Console.WriteLine("Going to Forward");
                break;
            case Direction.Left:
                Console.WriteLine("Going to Left");
                break;
            case Direction.Right:
                Console.WriteLine("Going to Right");
                break;
            case Direction.Backward:
                Console.WriteLine("Going to Backward");
                break;
            default:
                Console.WriteLine("Going to Default");
                break;
        }
    }
}