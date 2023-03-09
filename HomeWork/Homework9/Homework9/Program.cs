using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Homework9
{
    public struct Coordinate
    {
        public int X;
        public int Y;
    }
    class Shape
    {
        public string Type1;
        public virtual void Print()
        {
            Console.WriteLine($"Show figure type:{Type1} to console");
        }
    }
    class Line:Shape
    {
        Coordinate End;
        Coordinate Start;
        public Line(Coordinate startcoord, Coordinate endcoord)
        {
            Type1 = "Line";
            Start = startcoord;
            End = endcoord;
        }
        public override void Print()
        {
            Console.WriteLine($"This is a {Type1} shape with START point ({Start.X}, {Start.Y}) and END point ({End.X}, {End.Y}).");
            Console.SetCursorPosition(Start.X, Start.Y);
            Console.Write("#");

            // визначаємо напрям лінії
            bool isHorizontal = Start.Y == End.Y;
            int length = isHorizontal ? Math.Abs(End.X - Start.X) : Math.Abs(End.Y - Start.Y);

            // виводимо символ
            for (int i = 1; i <= length; i++)
            {
                if (isHorizontal)
                {
                    Console.Write("#");
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                }
                else
                {
                    Console.SetCursorPosition(Start.X, Start.Y + i);
                    Console.Write("#");
                }
            }
        }

    }

    class Rectangle : Shape
    {
        public Coordinate TopLeft { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(Coordinate topLeft, int width, int height)
        {
            Type1 = "Rectangle";
            TopLeft = topLeft;
            Width = width;
            Height = height;
        }

        public override void Print()
        {
            Console.WriteLine($"This is a {Type1} shape with top left corner ({TopLeft.X}, {TopLeft.Y}), width {Width} and height {Height}.");
            for (int y = 0; y < Height; y++)
            {
                Console.SetCursorPosition(TopLeft.X, TopLeft.Y + y);

                for (int x = 0; x < Width; x++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }

    }
    class Polyline: Shape
    {
        public Coordinate[] Points { get; set; }
        public Polyline(Coordinate[] points)
        {
            Type1 = "Polyline";
            Points = points;
        }
        public override void Print()
        {
            foreach (var point in Points)
            {
                Console.WriteLine($"Figure type: {Type1} with coordinates: x= {point.X} and y= {point.Y}");
            }
            foreach (var point in Points)
            {
                //Console.WriteLine($"point x{point.X} point y= {point.Y}");
                Console.SetCursorPosition(point.X, point.Y);
                Console.Write("#");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose what you want:" +
                "\n1. Paint Line;" +
                "\n2. Paint Rectangle;" +
                "\n3. Paint Polyline.");
            
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.Clear();

                        Console.WriteLine("Draw Line");
                        //малюємо лінію
                        Line line = new Line(new Coordinate { X = 0, Y = 1 }, new Coordinate { X = 25, Y = 1 });
                        line.Print();
                    }
                    break;
                case 2:
                    {
                        Console.Clear();

                        Console.WriteLine("Draw Rectangle");
                        //виводимо прямокутник
                        Rectangle rectangle = new Rectangle(new Coordinate { X = 2, Y = 2 }, 4, 3);
                        rectangle.Print();
                    }
                    break;
                case 3:
                    Console.Clear();

                    Console.WriteLine("Draw Polyline");
                    //виводимо точки полілінії
                    Polyline polyline = new Polyline(new Coordinate[] { new Coordinate { X = 25, Y = 4 }, new Coordinate { X = 5, Y = 12 }, new Coordinate { X = 15, Y = 15 } });
                    polyline.Print();
                    break;
                default:
                    Console.ReadKey();
                    break;
            }
        }


        }
    }
