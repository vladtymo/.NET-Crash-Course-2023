using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW11.Program;

namespace HW11
{
    enum ShapeType { Line, Rectangle, Polyline }
    internal class Shape
    {
        public ShapeType Type { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("---");
        }
    }

    internal class Line : Shape
    {
        public SPoint A { get; set; }
        public SPoint B { get; set; }

        public Line(SPoint a, SPoint b)
        {
            A = a;
            B = b;
        }
        public override void Print()
        {
            double length = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            for (int i = 0; i <= length; i++)
            {
                int x = A.X + (int)(i * (B.X - A.X) / length);
                int y = A.Y + (int)(i * (B.Y - A.Y) / length);
                Console.SetCursorPosition(x, y);
                Console.Write("*");
            }
        }
    }

    internal class Rectangle : Shape
    {
        public SPoint StartPoint { get; set; }
        public double Width { get; set; }  
        public double Height { get; set; }

        public Rectangle(SPoint startPoint, double width, double height)
        {
            StartPoint = startPoint;
            Width = width;
            Height = height;
        }
        public override void Print()
        {
            Console.SetCursorPosition(StartPoint.X, StartPoint.Y);
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    internal class Polyline : Shape
    {
        public SPoint[] Points { get; set; }

        public Polyline(SPoint[] points)
        {
            Points = points;
        }
        public override void Print()
        {
            foreach(SPoint point in Points)
            {
                Console.SetCursorPosition(point.X, point.Y);
                Console.WriteLine("*");
            }
        }
    }
}
