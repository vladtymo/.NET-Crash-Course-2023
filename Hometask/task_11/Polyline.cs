

namespace task_11
{
    internal class Polyline : Shape
    {
        const int n = 10;
        Point[] points = new Point[n];

        public Polyline() : base("Polyline")
        {
            for(int i = 0; i < n; i++) 
            {
                if(i%2==0)
                    points[i] = new Point(i, 0);
                else
                    points[i] = new Point(i, 1);

            }

        }

        public override void Print()
        {
            base.Print();
            
            for (int j = 0; j < points.Length; j++)
            {
                if (points[j].Y == 1)
                    Console.Write("*");
                else
                    Console.Write("  ");
            }

            Console.WriteLine("");

            for (int j = 0; j < points.Length; j++)
            {
                if (points[j].Y == 0)
                    Console.Write("*");
                else
                    Console.Write("  ");
            }


        }
    }
}
