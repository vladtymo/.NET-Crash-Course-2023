using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_11_HW
{
    public class Rectangle : Shape
    {
        public coordinate startPoint;
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y)
        {
            startPoint.x = x; 
            startPoint.y = y;
        }
        public override void Print()
        {
            Console.ForegroundColor = Color;
            for(int y = 0; y < Height; y++)
            {
                Console.SetCursorPosition(startPoint.x, startPoint.y+y);
                for(int x = 0; x < Width; x++)
                {
                    Console.Write("+");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
