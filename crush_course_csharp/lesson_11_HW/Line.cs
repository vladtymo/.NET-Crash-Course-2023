
namespace lesson_11_HW
{
    public class Line : Shape
    {
        public coordinate startCoordinate; 
        public coordinate endCoordinate;
        public override void Print()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(startCoordinate.x, startCoordinate.y);
            if(startCoordinate.x < endCoordinate.x)
            {
                for (int x = startCoordinate.x; x <= endCoordinate.x; x++)
                {
                    Console.SetCursorPosition(x, startCoordinate.y);
                    Console.WriteLine("-");
                }
            }
            else if(startCoordinate.x < endCoordinate.x)
            {
                for (int x = endCoordinate.x; x <= startCoordinate.x; x++)
                {
                    Console.SetCursorPosition(x, startCoordinate.y);
                    Console.WriteLine("-");
                }
            }
            else
            {
                if (startCoordinate.y < endCoordinate.y)
                {
                    for (int y = startCoordinate.y; y <= endCoordinate.y; y++)
                    {
                        Console.SetCursorPosition(startCoordinate.x, y);
                        Console.WriteLine("|");
                    }
                }
                else if (startCoordinate.y < endCoordinate.y)
                {
                    for (int y = endCoordinate.y; y <= startCoordinate.y; y++)
                    {
                        Console.SetCursorPosition(startCoordinate.x,y);
                        Console.WriteLine("|");
                    }
                }
            }
            
        }
    }
}
