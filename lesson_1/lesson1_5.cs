using System;
using System.Globalization;

namespace DemoApplication
{
 class Program
 { 
  static void Main() 
  {
    
    int year;
    Console.Write("Input an year : ");
    year = Convert.ToInt32(Console.ReadLine());
 
    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0){
       Console.WriteLine("366 days in {0}", year);}
     else { Console.WriteLine("365 days in {0}", year);}  
  }
 }
}

