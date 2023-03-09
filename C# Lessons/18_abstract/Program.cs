namespace _18_abstract
{
    // abstract class can contains abstract mehtod
    public abstract class Figure
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Figure(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                Name = name;
            else
                Name = "no name";
        }

        public Figure(string name, int x, int y) : this(name) // constructor delegating
        {
            X = x >= 0 ? x : 0;
            Y = y >= 0 ? y : 0;
        }

        public void SetCursorTo()
        {
            Console.SetCursorPosition(X, Y);
        }

        // abstract methods - has no realization
        public abstract double GetSquare();
        public abstract void Print();
    }

    public class Rectangle : Figure
    {
        public long Width { get; set; }
        public long Height { get; set; }

        public Rectangle() : base("Rectangle") { }

        public override double GetSquare()
        {
            return Width * Height;
        }

        public override void Print()
        {
            Console.WriteLine($"Printing rectangle with size {Width}x{Height}cm");
        }
    }

    public class Circle : Figure
    {
        public long Radius { get; set; }

        public Circle() : base("Circle") { }

        public override double GetSquare()
        {
            return Math.PI * (Radius * Radius);
        }

        public override void Print()
        {
            Console.WriteLine($"Printing circle with radius {Radius}cm");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // we cannot create an instance of abstract classes
            //Figure figure = new Figure("blablalba");

            Rectangle rectangle = new()
            {
                Height = 75,
                Width = 32
            };
            Circle circle = new()
            {
                Radius = 18
            };

            Figure figure = rectangle;

            rectangle.Print();
            Console.WriteLine($"Square: {rectangle.GetSquare()}cm^2");

            circle.Print();
            Console.WriteLine($"Square: {circle.GetSquare()}cm^2");
        }
    }
}