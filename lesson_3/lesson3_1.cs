using System;
using System.Linq;

    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter a character: ");
            char character = Console.ReadLine()[0]; // Зчитання першого символу введення

            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Output: ");
            foreach (int i in Enumerable.Range(0, number)) {
                Console.Write(character); 
            }
        }
    }
