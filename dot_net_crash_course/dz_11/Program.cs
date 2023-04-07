
using Microsoft.VisualBasic;
using System.Data.SqlTypes;
using System.Net;

namespace dz_11
{
    class Shape
    {
        public virtual string Type { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine(Type);
        }
        public virtual void Print()
        {
            Console.WriteLine("None");
        }

    }

    struct Cords
    {
        public Cords(int x, int y) 
        { 
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Line : Shape
    {
        public override string Type => "Line";
        public static Cords StartPoint { get; set; }
        public static Cords EndPoint { get; set; }
        
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"{StartPoint.X}, {StartPoint.Y}");
            Console.WriteLine($"{EndPoint.X}, {EndPoint.Y}");
        }

        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(StartPoint.X, StartPoint.Y);
            Console.Write('#');
            Console.SetCursorPosition(EndPoint.X, EndPoint.Y);
            Console.Write('#');

            //int mY = (EndPoint.Y - StartPoint.Y) / (EndPoint.X - StartPoint.X);
            //int mX = (EndPoint.X - StartPoint.X) / (EndPoint.Y - StartPoint.Y);

            //Console.ForegroundColor = ConsoleColor.Green;
            //int lMX = 0;
            //int lMY = 0;
            //if (mX >= mY)
            //{
            //    for (int y = StartPoint.Y; y < EndPoint.Y; y++)
            //    {
            //        int x = StartPoint.X+lMX;
            //        lMX += mX;
            //        Console.SetCursorPosition(x, y);
            //        Console.Write(new string('#', mX));
            //    }
            //}
            //else
            //{
            //    for (int x = StartPoint.X; x < EndPoint.X; x++)
            //    {
            //        int y = StartPoint.Y + lMY;
            //        lMY += mY;
            //        Console.SetCursorPosition(x, y);
            //        for (int i = 0; i < mY; i++)
            //        {
            //            Console.Write("#\n");
            //            Console.SetCursorPosition(x, y+i);
            //        }
            //    }
            //}            
            Console.SetCursorPosition(25, 25);
            Console.ResetColor();
        }

        public Line(Cords startPoint, Cords endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public Line()
        {
            StartPoint = new Cords(0, 0);
            EndPoint = new Cords(1, 1);
        }
    }

    class Polyline : Shape
    {
        public override string Type => "Polyline";
        public Cords[] PointArray { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            foreach (var point in PointArray)
            {
                Console.WriteLine($"{point.X}, {point.Y}");
            }
        }
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
     
            foreach (Cords i in PointArray)
            {
                Console.SetCursorPosition(i.X, i.Y);
                Console.Write('@');
            }
            Console.SetCursorPosition(25, 25);
            Console.ResetColor();
        }
    }

    class Rectangle : Shape
    {
        public Cords Start { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"{Height}, {Width}");
        }
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = Start.X; i<= Start.X+Width; i++)
            {
                for (int j = Start.Y; j<= Start.Y+Height; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write("%");
                }
            }
            Console.SetCursorPosition(25, 25);
            Console.ResetColor();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Line(new Cords { X = 1, Y = 1 }, new Cords { X = 8, Y = 12 });
            s1.Print();

            Shape s2 = new Polyline()
            {
                PointArray = new Cords[] { 
                    new Cords(1, 2), 
                    new Cords(3, 8),
                    new Cords(6, 1),
                    new Cords(7, 3),
                }
            };
            s2.Print();

            Shape s3 = new Rectangle()
            {
                Start = new Cords { X = 12, Y = 4 },
                Height = 3,
                Width = 6
            };
            s3.Print();

            //Console.WriteLine(s1.Type);
        }
    }
}