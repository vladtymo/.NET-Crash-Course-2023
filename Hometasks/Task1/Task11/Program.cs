namespace Task11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[15];
            for(int i = 0; i < points.Length; i++)
            {
                Random random = new Random();
                points[i].X = Math.Round(random.NextDouble() * 1000, 2);
                points[i].Y = Math.Round(random.NextDouble() * 1000, 2);
            }

            Polyline polyline = new Polyline(points);
            polyline.Print();
        }
    }

    public struct Point
    {
        public double X;
        public double Y;

        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
    }

    public class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape ctor");
            Points = new Point[1];
        }

        public Shape(Point[] points)
        {
            Points = points;
        }

        public Point[] Points { get; protected set; }
        public string Type => this.GetType().Name;

        public virtual void Print()
        {
            for(int i = 0; i < Points.Length; i++)
            {
                Console.WriteLine($"{i}: [{Points[i].X}; {Points[i].Y}]");
            }
        }
    }

    public class Line : Shape
    {
        public Line(Point a, Point b)
        {
            Points = new Point[2];
            Points[0] = a;
            Points[1] = b;
        }

        public Point A => Points[0];
        public Point B => Points[1];

        public override void Print()
        {
            Console.WriteLine($"A[{A.X}; {A.Y}]; B[{B.X}; {B.Y}]");
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }

        public Rectangle(Point location, double length, double height)
        {
            Location = location;
            Length = length;
            Height = height;
        }

        public Point Location
        {
            get { return Points[0]; }
            set { Points[0] = value; }
        }
        public double Length { get; set; }
        public double Height { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Length: {Length}; Height: {Height}; Located: [{Location.X}; {Location.Y}]");
        }
    }

    public class Polyline : Shape 
    {
        public Polyline()
        {
            Console.WriteLine("Polyline ctor");
        }

        public Polyline(Point[] points)
        {
            Points = points;
        }
    }
}