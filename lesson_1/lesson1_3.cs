using System;

namespace DemoApplication
{
 class Program
 { 
  static void Main(string[] args) 
  {
   Console.Write("Enter Radius: ");
   double Radious = Convert.ToDouble(Console.ReadLine());
   double Area = Math.PI * Radious * Radious;
   Console.WriteLine("Area of circle: " + Area);
  }
 }
}


