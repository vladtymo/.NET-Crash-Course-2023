using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        
        public int Height { get; set; }
        public int Width { get; set; }
        public Coordinates StartPoint { get; set; }

        public Rectangle(string name, Coordinates startPoint, int height, int width) : base(name)
        {
            StartPoint = startPoint;
            Height = height;
            Width = width;
        }

        public override void PrintFigure()
        {
            for (int y = 0; y < Height; y++)
            {
                Console.SetCursorPosition(StartPoint.X, StartPoint.Y + y);

                for (int x = 0; x < Width; x++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
    
}
