using System.Drawing;

namespace Task11
{
    internal class Line : Shape
    {
        private Point p1;
        private Point p2;
        public Line(Point point1, Point point2) 
        {  
            this.p1 = point1;
            this.p2 = point2;

        }
        private void Bresenham4Line()
        {
            int dx = (p2.X > p1.X) ? (p2.X - p1.X) : (p1.X - p2.X);
            int dy = (p2.Y > p1.Y) ? (p2.Y - p1.Y) : (p1.Y - p2.Y);
            int sx = (p2.X >= p1.X) ? (1) : (-1);
            int sy = (p2.Y >= p1.Y) ? (1) : (-1);

            if (dy < dx)
            {
                int d = (dy << 1) - dx;
                int d1 = dy << 1;
                int d2 = (dy - dx) << 1;
                Drow(p1.X, p1.Y);
                int x = p1.X + sx;
                int y = p1.Y;
                for (int i = 1; i <= dx; i++)
                {
                    if (d > 0)
                    {
                        d += d2;
                        y += sy;
                    }
                    else
                        d += d1;
                    Drow(x, y);
                    x += sx;
                }
            }
            else
            {
                int d = (dx << 1) - dy;
                int d1 = dx << 1;
                int d2 = (dx - dy) << 1;
                Drow(p1.X, p1.Y);
                int x = p1.X;
                int y = p1.Y + sy;
                for (int i = 1; i <= dy; i++)
                {
                    if (d > 0)
                    {
                        d += d2;
                        x += sx;
                    }
                    else
                        d += d1;
                    Drow(x, y);
                    y += sy;
                }
            }
        }
        private void Drow(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y);
            Console.Write('*');
            Console.ResetColor();
        }
        public override void Print()
        {
            Bresenham4Line();
        }
    }
}
