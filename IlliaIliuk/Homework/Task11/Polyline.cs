using System.Drawing;

namespace Task11
{
    internal class Polyline : Shape
    {
        private Point[] points;
        public Polyline(Point[] points)
        {
            this.points = points;
        }

        public void Bresenham4Line(int x0, int y0, int x1, int y1)
        {
            int dx = (x1 > x0) ? (x1 - x0) : (x0 - x1);
            int dy = (y1 > y0) ? (y1 - y0) : (y0 - y1);
            int sx = (x1 >= x0) ? (1) : (-1);
            int sy = (y1 >= y0) ? (1) : (-1);

            if (dy < dx)
            {
                int d = (dy << 1) - dx;
                int d1 = dy << 1;
                int d2 = (dy - dx) << 1;
                Drow(x0, y0);
                int x = x0 + sx;
                int y = y0;
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
                Drow(x0, y0);
                int x = x0;
                int y = y0 + sy;
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
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(x, y);
            Console.Write('*');
            Console.ResetColor();
        }
        public override void Print()
        {
            for (int i = 0; i < points.Length-1; i++)
            {
                Bresenham4Line(points[i].X, points[i].Y, points[i+1].X, points[i+1].Y);
            }
            
        }
    }
}
