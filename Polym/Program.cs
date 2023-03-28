using System;

namespace Polym
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }


    public class Shape
    {
        public string Type;

        public Shape(string type)
        {
            Type = type;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Type: {Type}");
        }
    }


    public class Line : Shape
    {
        public Point StartPoint;
        public Point EndPoint;

        public Line(Point startPoint, Point endPoint) : base("Line")
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public override void Print()
        {


            int deltaX = Math.Abs(EndPoint.X - StartPoint.X);
            int deltaY = Math.Abs(EndPoint.Y - StartPoint.Y);

            if (deltaX > deltaY)
            {
                int stepX = (StartPoint.X < EndPoint.X) ? 1 : -1;
                int currentX = StartPoint.X;
                int currentY = StartPoint.Y;

                while (currentX != EndPoint.X)
                {
                    Console.SetCursorPosition(currentX, currentY);
                    Console.Write("*");

                    currentX += stepX;
                    currentY = (int)Math.Round(StartPoint.Y + (double)(currentX - StartPoint.X) * deltaY / deltaX);
                }
            }
            else
            {
                int stepY = (StartPoint.Y < EndPoint.Y) ? 1 : -1;
                int currentX = StartPoint.X;
                int currentY = StartPoint.Y;

                while (currentY != EndPoint.Y)
                {
                    Console.SetCursorPosition(currentX, currentY);
                    Console.Write("+");

                    currentY += stepY;
                    currentX = (int)Math.Round(StartPoint.X + (double)(currentY - StartPoint.Y) * deltaX / deltaY);
                }
            }
        }
    }


    public class Rectangle : Shape
    {
        public Point UpperLeft;
        public int Width;
        public int Height;

        public Rectangle(Point upperLeft, int width, int height) : base("Rectangle")
        {
            UpperLeft = upperLeft;
            Width = width;
            Height = height;
        }

        public override void Print()
        {


            for (int x = UpperLeft.X; x < UpperLeft.X + Width; x++)
            {
                Console.SetCursorPosition(x, UpperLeft.Y);
                Console.Write("+");
                Console.SetCursorPosition(x, UpperLeft.Y + Height - 1);
                Console.Write("+");
            }

            for (int y = UpperLeft.Y + 1; y < UpperLeft.Y + Height - 1; y++)
            {
                Console.SetCursorPosition(UpperLeft.X, y);
                Console.Write("+");
                Console.SetCursorPosition(UpperLeft.X + Width - 1, y);
                Console.Write("+");
            }
        }
    }

    public class Polyline : Shape
    {
        public Point[] Points;

        public Polyline(Point[] points) : base("Polyline")
        {
            Points = points;
        }

        public override void Print()
        {


            for (int i = 0; i < Points.Length - 1; i++)
            {
                Line line = new Line(Points[i], Points[i + 1]);
                line.Print();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Line(new Point(20, 5), new Point(15, 15)),
                new Rectangle(new Point(30, 10), 10, 5),
                new Polyline(new Point[] { new Point(5,5), new Point(5, 0), new Point(15, 10), new Point(20, 20) })
            };

            foreach (Shape shape in shapes)
            {
                shape.Print();
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}