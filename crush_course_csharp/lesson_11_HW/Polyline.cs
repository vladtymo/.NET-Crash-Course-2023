using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_11_HW
{
    public class Polyline : Shape
    {
        public char[] chars { get; set; }
        public coordinate startPoint;

        public Polyline(int x, int y, char[] chars)
        {
            startPoint.x = x;
            startPoint.y = y;
            this.chars = chars;
        }

        public override void Print()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(startPoint.x, startPoint.y);
            for(int i =0; i < chars.Length; i++)
            {
                Console.Write(chars[i] + " ");
            }
        }
    }
}
