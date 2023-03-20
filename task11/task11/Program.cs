namespace task11
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
           Line line = new Line(new Point(1, 1), new Point(10, 10));
            line.Print();

            Rectangle rectangle = new Rectangle(new Point(1, 12), 10, 8);
            rectangle.Print();

            Polyline polyline = new Polyline(new Point[] { new Point(2, 3), new Point(3, 3), new Point(7, 2) });
            polyline.Print();
        }
    }
    public class Shape
    {
        public virtual void Print()
        {
            Console.WriteLine("Shape");
        }
    }

    public class Line : Shape
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public override void Print()
        {
            Console.WriteLine($"Line from ({Start.X},{Start.Y}) to ({End.X},{End.Y}):");
            int deltaX = Math.Abs(End.X - Start.X);
            int deltaY = Math.Abs(End.Y - Start.Y);
            int x = Start.X;
            int y = Start.Y;
            int dx = (End.X > Start.X) ? 1 : -1;
            int dy = (End.Y > Start.Y) ? 1 : -1;
            int error = deltaX - deltaY;
            while (x != End.X || y != End.Y)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("*");
                int error2 = error * 2;
                if (error2 > -deltaY)
                {
                    error -= deltaY;
                    x += dx;
                }
                if (error2 < deltaX)
                {
                    error += deltaX;
                    y += dy;
                }
            }
            Console.WriteLine();
        }
    }

    public class Rectangle : Shape
    {
        public Point TopLeft { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(Point topLeft, int width, int height)
        {
            TopLeft = topLeft;
            Width = width;
            Height = height;
        }

        public override void Print()
        {
            Console.WriteLine($"Rectangle with TopLeft ({TopLeft.X},{TopLeft.Y}), Width {Width}, Height {Height}:");
            for (int i = TopLeft.Y; i < TopLeft.Y + Height; i++)
            {
                for (int j = TopLeft.X; j < TopLeft.X + Width; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    public class Polyline : Shape
    {
        public Point[] Points { get; set; }

        public Polyline(Point[] points)
        {
            Points = points;
        }

        public override void Print()
        {
            Console.WriteLine("Polyline with points:");
            foreach (Point p in Points)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}