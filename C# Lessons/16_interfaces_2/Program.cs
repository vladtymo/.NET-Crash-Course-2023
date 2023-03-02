namespace _16_interfaces_2
{
    interface ILocated
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    interface IColored
    {
        public ConsoleColor Color { get; }
    }

    interface IShape : ILocated, IColored
    {
        public double Square { get; }

        // interface can has default realization
        void MoveTo(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        void Print();
    }

    class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public double Square => Width * Height;

        public int X { get; set; }
        public int Y { get; set; }

        public ConsoleColor Color { get; init; }

        public void Print()
        {
            Console.ForegroundColor = this.Color;

            for (int y = 0; y < Height; y++)
            {
                Console.SetCursorPosition(this.X, this.Y + y);

                for (int x = 0; x < Width; x++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }

    class Triangle : IShape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public long P => Side1 + Side2 + Side3;
        private long HalfP => P / 2;
        public double Square => Math.Sqrt(HalfP * (HalfP - Side1) * (HalfP - Side2) * (HalfP - Side3));

        public int X { get; set; }
        public int Y { get; set; }

        public ConsoleColor Color { get; init; }

        public void Print()
        {
            Console.ForegroundColor = this.Color;

            for (int y = 0; y < Side1; y++)
            {
                Console.SetCursorPosition(this.X, this.Y + y);

                for (int x = Side2 - y; x > 0; x--)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }

    internal class Program
    {
        static void TestShape(IShape shape)
        {
            Console.WriteLine($"Square: {shape.Square} cm^2");

            shape.Print();
            shape.MoveTo(15, 15);
            shape.Print();
        }
        static void Main(string[] args)
        {
            var rect = new Rectangle()
            {
                Height = 8,
                Width = 35,
                Color = ConsoleColor.Magenta,
                X = 2,
                Y = 2
            };
            var triang = new Triangle()
            {
                Side1 = 9,
                Side2 = 11,
                Side3 = 4,
                Color = ConsoleColor.Yellow,
                X = 4,
                Y = 5
            };

            TestShape(rect);
            TestShape(triang);
        }
    }
}