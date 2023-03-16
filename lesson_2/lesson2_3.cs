using System;

namespace nProgram{
    class Program{
        enum CalculateOptions{
            Radius = 1,
            Area,
            Perimeter
        }
        static void Main(string[] args){
            Console.WriteLine("Enter diameter:");
            double diameter = Convert.ToDouble(Console.ReadLine());
            double radius = diameter / 2;
            Console.WriteLine(" Select the action: ");
            Console.WriteLine("1. Calculate the radius of the circle");
            Console.WriteLine("2. Calculate the area of the circle");
            Console.WriteLine("3. Calculate the perimeter of the circle");
            int choice = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            CalculateOptions selectedOption = (CalculateOptions)choice;
            switch (selectedOption){
                case CalculateOptions.Radius:
                    Console.WriteLine($"The radius is {radius}");
                    break;
                case CalculateOptions.Area:
                    result = Math.PI * radius * radius;
                    Console.WriteLine($"The area is {result}");
                    break;
                case CalculateOptions.Perimeter:
                    result = 2 * Math.PI * radius;
                    Console.WriteLine($"The perimeter is {result}");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}

