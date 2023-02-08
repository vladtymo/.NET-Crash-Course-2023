using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Circle
    {
        public void Radius()
        {
            Console.Write("Enter a radius of circle: ");
            int rcircle = int.Parse(Console.ReadLine());

            double areacircle = (2 * 3.14 * rcircle);

            Console.WriteLine($"Area of cirlce = {areacircle}");
        }
    }
}
