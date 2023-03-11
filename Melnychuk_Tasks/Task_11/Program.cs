using System;


public class Task
{
    class Shape
    {
        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public virtual void Print() { }

    }

    class Line : Shape
    {
        public Line(int x, int y, char symbol, int symbols)
        {
            X = x;
            Y = y;
            Symbol = symbol;
            Symbols = symbols;
        }
        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Symbols { get; set; }
        public override void Print()
        {
            Console.SetCursorPosition(this.X, this.Y);

            for (int y = 0; y < Symbols; y++)
            {
                Console.Write(Symbol);
            }

            Console.WriteLine();
        }
    }

    class Rectangle : Shape
    {

        public Rectangle(int x, int y, char symbol, int height, int width)
        {
            X = x;
            Y = y;
            Symbol = symbol;
            Height = height;
            Width = width;
        }
        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public override void Print()
        {

            for (int y = 0; y < Height; y++)
            {
                Console.SetCursorPosition(this.X, this.Y + y);

                for (int x = 0; x < Width; x++)
                {
                    Console.Write(Symbol);
                }
                Console.WriteLine();
            }


        }
    }


    class Polyline : Shape
    {
        public Polyline(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }
        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public static void Main(string[] args)
    {

        Line line = new Line(3, 4, 'b', 5);
        line.Print();

        Rectangle rectangle = new Rectangle(4, 5, 'v', 5, 10);
        rectangle.Print();

        Console.ReadLine();
    }
}
