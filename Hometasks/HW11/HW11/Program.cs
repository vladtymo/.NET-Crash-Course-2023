namespace HW11
{
    internal class Program
    {
        internal struct SPoint
        {
            public int X { get; set; }
            public int Y { get; set; }
            public SPoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        static void Main(string[] args)
        {
            SPoint[] points = { new SPoint(6, 6), new SPoint(20, 20), new SPoint(2, 5) };
            Line line = new Line(new SPoint(5, 3), new SPoint(15, 13));
            Rectangle rectangle = new Rectangle(new SPoint(5, 14), 10, 10);
            Polyline polyline = new Polyline(points);
            line.Print();
            rectangle.Print();
            polyline.Print();
        }
    }
}