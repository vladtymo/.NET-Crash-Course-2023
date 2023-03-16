using System;

namespace nProgran{
  class Program{
     static void Main(string[] args){
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int originalNumber = number;
        int reverse = 0;
        while (number != 0){
            int lastDigit = number % 10;
            reverse = reverse * 10 + lastDigit;
            number = number / 10;
        }
        if (originalNumber == reverse){
            Console.WriteLine($"{originalNumber} is a palindrome");
        }
        else{
            Console.WriteLine($"{originalNumber} is not a palindrome");
       }
     }
  }
}
