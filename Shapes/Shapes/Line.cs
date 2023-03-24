using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Line : Shape
    {
        public char Symbol { get; set; }
        public Coordinates StartPoint { get; set; }
        public Coordinates EndPoint { get; set; }

        public Line(string name, char symbol, Coordinates startPoint, Coordinates endPoint) : base(name)
        {
            Symbol = symbol;
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public override void PrintFigure()
        {
            Console.SetCursorPosition(StartPoint.X, StartPoint.Y);
            for (int i = StartPoint.X; i < EndPoint.X; i++)
            {
                Console.Write(Symbol);
            }
        }
    }
}
