using System;
using System.Linq;

namespace CharacterLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character: ");
            char character = Console.ReadLine()[0]; // Read the first character of the input

            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Output: ");
            foreach (int i in Enumerable.Range(0, number)) 
            {
                Console.Write(character); 
            }
        }
    }
}
