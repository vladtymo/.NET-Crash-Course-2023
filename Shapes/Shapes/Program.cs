namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string points = new string('.', 15);
            char[] chars = points.ToCharArray();

            Coordinates pointA = new Coordinates(8, 3);
            Coordinates pointB = new Coordinates(74, 3);

            Shape shape = new Line("line", '-', pointA, pointB);
            Shape recShape = new Rectangle("Rectangle", pointA, 4, 16);
            Shape polyShape = new Polyline("Polyline", chars, pointA);
             

            polyShape.PrintFigure();
        }
    }
}