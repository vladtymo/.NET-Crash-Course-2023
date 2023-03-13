using System.Runtime.CompilerServices;

namespace lab_11_polymorphism
{
    internal class Program
    {
        public struct Coordinate
        {
            public int X;
            public int Y;
        }
        class Shape 
        {
            public string shapeType;
            public virtual void Print()
            {
                Console.WriteLine("Type of figure in console: " + shapeType);
            }
        }
        class Line : Shape
        {
            Coordinate start;
            Coordinate end;
            public Line(Coordinate start, Coordinate end)
            {
                shapeType = "Line";
                this.start = start; 
                this.end = end;
            }
            public override void Print()
            {
                base.Print();
                Console.SetCursorPosition(start.X, start.Y);
                Console.WriteLine(new String('_', end.X - start.X));
                Console.WriteLine($"Start coordinate: ({start.X};{start.Y}), end coordinate: ({end.X};{end.Y})");
            }
        }
        class Rectangle : Shape
        {
            Coordinate TopLeft { get; set; }
            public int Width;
            public int Height;
            public Rectangle(Coordinate topLeft, int width, int height)
            {
                shapeType = "Rectangle";
                TopLeft = topLeft;
                Width = width;
                Height = height;
            }
            public override void Print()
            {
                base.Print();
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
        class Polyline : Shape
        {
            public Coordinate[] Points { get; set; }
            public Polyline(Coordinate[] points)
            {
                shapeType = "Polyline";
                Points = points;
            }
            public override void Print()
            {
                base.Print();
                for(int i=0; i<Points.Length; ++i)
                {
                    Console.SetCursorPosition(Points[i].X, Points[i].Y );
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Line line = new Line(new Coordinate{X = 2, Y = 1}, new Coordinate{X = 10, Y = 8});
            line.Print();
            //Console.WriteLine();
            Rectangle rectangle = new Rectangle(new Coordinate { X = 3,Y=5 },4,5);
            rectangle.Print();
            Coordinate[] points = { new Coordinate { X = 3, Y = 4 }, new Coordinate { X = 8, Y = 8 }, new Coordinate { X = 5, Y = 13 }, new Coordinate { X = 6, Y = 17 } };
            Polyline polyline = new Polyline(points);
            polyline.Print();

        }
    } 
}