using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Polyline : Shape
    {
       
        public char[] PolyLineSymbol { get; }
        public Coordinates StartPoint { get; set; }

        public Polyline(string name, char[] points, Coordinates startPoint) : base(name)
        {
            PolyLineSymbol = points;
            StartPoint = startPoint;
        }

        public override void PrintFigure()
        {
            Console.SetCursorPosition(StartPoint.X, StartPoint.Y);

            for (int i = 0; i < PolyLineSymbol.Length; i++)
            {
                Console.Write($"{PolyLineSymbol[i]} ");
            }
        }
    }
}
