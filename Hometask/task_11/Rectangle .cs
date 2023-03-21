

namespace task_11
{
    internal class Rectangle : Shape
    {
        Point pointLeft;

        public int Weidth { get; set; }
        public int Height { get; set; }

        public Rectangle(int weidth, int height) : base("Rectangle")
        {
            Weidth= weidth > 0 ? weidth : 20;
            Height= height > 0 ? height : 10;
            pointLeft = new Point(0 , 0);
        }

        public override void Print()
        {
            base.Print();

            for(int i = pointLeft.Y; i < Height + pointLeft.Y; i++) 
            { 
                for(int j = pointLeft.X; j < Weidth + pointLeft.X; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
        }
    }
}
