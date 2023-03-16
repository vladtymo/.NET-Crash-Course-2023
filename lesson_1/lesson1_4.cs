using System;

namespace DemoApplication
{
 class Program
 { 
  static void Main(string[] args) 
  {
   Console.Write("Enter number of seconds: ");
   int seconds = Convert.ToInt32(Console.ReadLine());
   TimeSpan time = TimeSpan.FromSeconds(seconds);
   Console.WriteLine($"{time.ToString(@"hh\:mm\:ss")}");
  }
 }
}


