using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Rectangle
    {
        public void CalcofRectangle()
        {
            Console.Write("Enter a width of rectangle: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter a height of rectangle: ");
            int height = int.Parse(Console.ReadLine());

            int s = width * height;
            int p = (width + height) * 2;

            Console.WriteLine($"Area of rectangle = {s}");
            Console.WriteLine($"Perimetr of rectangle = {p}");
        }
    }
}
