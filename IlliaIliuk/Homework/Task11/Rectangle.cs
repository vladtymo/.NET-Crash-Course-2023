using System.Drawing;

namespace Task11
{
    internal class Rectangle: Shape
    {
        private Point point;

        public Rectangle(Point point, int width, int height)
        {
            this.point = point;
            Width = width;
            Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            for (int y = 0; y < Height; y++)
            {
                Console.SetCursorPosition(point.X, point.Y + y);

                for (int x = 0; x < Width; x++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}
