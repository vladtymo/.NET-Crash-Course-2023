using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        { 
            Name= name;
        }

        public virtual void PrintFigure()
        {
            Console.WriteLine("Printing shape...");
        }
    }
}
