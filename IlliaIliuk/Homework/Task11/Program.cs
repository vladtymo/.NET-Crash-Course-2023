using System.Drawing;

namespace Task11
{
    internal class Program
    {
        static void DrowShape(Shape shape)
        {
            shape.Print();
        }
        static void Main(string[] args)
        {
            Line line = new(new(2, 20), new(10, 10));

            Rectangle rectangle = new(new(40, 7), 20,20);

            Point[] points =
            {
                new Point(0, 0),
                new Point(5, 5),
                new Point(0, 11),
                new Point(30, 15)
            };
            Polyline polyline = new(points);

            DrowShape(line);
            DrowShape(polyline);
            DrowShape(rectangle);


            Thread.Sleep(10000);
        }
    }
}