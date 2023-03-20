namespace lesson_11_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[] { '-', '*', 'a', '/', ',', '6', '1' };
            List<Shape> shapes = new List<Shape>
            {
                new Polyline(10, 1, chars)
                {
                    Color = ConsoleColor.DarkYellow
                },
                new Line()
                {
                    startCoordinate = new Shape.coordinate() { y = 20, x = 10 },
                    endCoordinate = new Shape.coordinate() { y = 20, x = 40 },
                    Color = ConsoleColor.Red
                },
                new Line()
                {
                    startCoordinate = new Shape.coordinate() { y = 15, x = 10 },
                    endCoordinate = new Shape.coordinate() { y = 20, x = 10 },
                    Color = ConsoleColor.Yellow
                },
                new Rectangle(20, 4)
                {
                    Width = 20,
                    Height = 5,
                    Color = ConsoleColor.Green,
                }
            };

            foreach(Shape shape in shapes)
            {
                shape.Print();
            }
        }
    }
}