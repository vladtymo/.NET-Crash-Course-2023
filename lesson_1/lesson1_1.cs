using System;

namespace DemoApplication
{
 class Program
 { 
  static void Main(string[] args) 
  {
   Console.Write("Enter your current date: ");
   Console.Write("\nDay: ");
   int day =   Convert.ToInt32(Console.ReadLine());
   Console.Write("Month: ");
   int month = Convert.ToInt32(Console.ReadLine());
   Console.Write("Year: ");
   int year =  Convert.ToInt32(Console.ReadLine());
   
   Console.WriteLine($"Your current date:{day}/{month}/{year}");
   
    //second solution:
    //Console.WriteLine(DateTime.Now);
  }
 }
}


