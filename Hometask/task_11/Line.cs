
namespace task_11
{
    internal class Line : Shape
    {
        Point[] point = new Point[2];

        public Line() : base("Line")
        {
            point[0]= new Point(0,0);
            point[1]= new Point(10,0);
        }

        public override void Print()
        {
            base.Print();

            for (int i = point[0].X; i < point[1].X; i++)
                Console.Write("*");
            


        }
    }
}

/*            if (point[0].X < point[1].X)
            {
                for (int i = point[0].X; i < point[1].X; i++)
                {
                    if (point[0].Y < point[1].Y)
                    {
                        for (int j = point[0].Y; j < point[1].Y; j++)
                        {
                            Console.Write("*");
                        }
                    }
                        
                }
            }
            else
            {
                for (int i = point[0].X; i < point[1].X; i++)
                {
                    if (point[0].Y < point[1].Y)
                        for (int j = point[0].Y; j < point[1].Y; j++)
                        {

                        }
                }
            }*/