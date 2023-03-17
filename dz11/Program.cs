using System;
internal class Program{
    public struct Coordinate
    {
        public int X { get;set; }
        public int Y { get; set;}

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Shape
    {
        public string Type { get; }

        public Shape(string type)
        {
            Type = type;
        }
        public void setCursorByY(int y){
            for(int i = 0;i<y;i++){
                Console.WriteLine();
            }
        }
        public void setCursorByX(int x){
            for (int i = 0; i < x; i++)
            {
                Console.Write(" ");
            }
        }
        public void setCursor(int x,int y){
            setCursorByY(y);
            setCursorByX(x);
        }
        public virtual void Print()
        {
            Console.WriteLine($"Type: {Type}");
        }
    }

    public class Line : Shape
    {
        public Coordinate Start { get; }
        public Coordinate End { get; }

        public Line(Coordinate start, Coordinate end) : base("Line")
        {
            Start = start;
            End = end;
        }

        public override void Print()
        {
            base.Print();
            base.setCursor(Start.X, Start.Y);
            Console.Write("#");
            base.setCursor(End.X, End.Y);
            Console.WriteLine("#");
        }
    }

    public class Rectangle : Shape
    {
        public Coordinate TopLeft { get; }
        public int Width { get; }
        public int Height { get; }

        public Rectangle(Coordinate topLeft, int width, int height) : base("Rectangle")
        {
            TopLeft = topLeft;
            Width = width;
            Height = height;
        }

        public override void Print()
        {
            base.Print();
            base.setCursorByY(TopLeft.Y);
            for (int y = 0; y < Height; y++)
            {
                base.setCursorByX(TopLeft.X);
                for (int x = 0; x < Width; x++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }

    public class Polyline : Shape
    {
        public Coordinate[] Coordinates { get; set;}

        public Polyline(Coordinate[] coordinates) : base("Polyline")
        {
            Coordinates = coordinates;
        }
        
        public override void Print()
        {
            base.Print();
            foreach (var coordinate in Coordinates)
            {
                Console.SetCursorPosition(coordinate.X,coordinate.Y);
                Console.WriteLine($"#");
            }
        }
    }
    private static void Main(string[] args)
    {
        Polyline polyline = new Polyline(new Coordinate[]{new Coordinate{X=5,Y=5},new Coordinate{X=6,Y=6}});
        polyline.Print();
        Rectangle rectangle = new Rectangle(new Coordinate { X = 3,Y=3 },3,3);
        Line line = new Line(new Coordinate{X=1,Y=1},new Coordinate{X=4,Y=4});
        rectangle.Print();
        line.Print();
        
    }
}