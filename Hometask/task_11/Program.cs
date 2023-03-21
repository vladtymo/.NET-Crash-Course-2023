namespace task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line();
            line.Print();
            Polyline polyline = new Polyline();
            polyline.Print();
            Rectangle rectangle = new Rectangle(0, 0);
            rectangle.Print();
        }
    }
}