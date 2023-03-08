using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public enum type { Lines, Rectangle, Polyline }

namespace ConsoleApp11
{
    public class Shape
    {
        public type Type { get; set; }
        public virtual void Print()
        {
            Console.WriteLine($"Type: {Type}");
        }

    }
    public struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Line : Shape
    {
        public Position Start { get; set; }
        public Position End { get; set; }

        public Line (Position start, Position end)
        {
            base.Type = type.Lines;
            Start = start;
            End = end;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Lines start with: {Start.X},{Start.Y}. End with: {End.X},{End.Y}");
        }
    }

    public class Rectangle : Shape
    {
        public int width { get; set; }
        public int height { get; set; }
        public Position Left { get; set; }

        public Rectangle(int width, int height, Position left)
        {
            Type = type.Rectangle;
            this.width = width;
            this.height = height;
            Left = left;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Left position: {Left.X},{Left.Y}. Width: {width}. Height: {height}");
        }

    }

    public class Polyline : Shape
    {
        public Position[] Positions { get; set; }

        public Polyline(Position[] positions)
        {
            base.Type = type.Polyline;
            this.Positions = positions;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Points: ");
            foreach(var position in this.Positions)
            {
                Console.WriteLine($"{position.X},{position.Y}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = new Line(new Position { X = 0, Y = 0 }, new Position { X=25, Y=30});
            line.Print();
            var rect = new Rectangle(12, 3, new Position(45, 12));
            rect.Print();
            var poly = new Polyline(new[] { new Position(13, 2), new Position(187, 4), new Position(123, 12), new Position(513, 2), new Position(613, 28) });
            poly.Print();
        }
    }
}
