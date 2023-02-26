using System;

namespace DemoApplication
{
 class Program
 { 
  static void Main(string[] args) 
  {
   Console.Write("Enter 2 sides of the rectangle: ");
   Console.Write("\nWidth: ");
   double width = Convert.ToDouble(Console.ReadLine());
   Console.Write("Length: ");
   double length = Convert.ToDouble(Console.ReadLine());
   
   double area = width * length;
   
   Console.WriteLine($"Area of a rectangle: {area}(m^2)");
  }
 }
}


