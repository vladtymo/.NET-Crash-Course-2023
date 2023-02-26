using System;

namespace RemoveSpaces{
    class Program{
        static void Main(string[] argss ){
            
            Console.WriteLine(" enter a string: ");
            string inputString = Console.ReadLine();
            string result = inputString.Replace(" . ", ".");
            Console.WriteLine("String after: " + result);
            Console.ReadLine();
        }
    }
}

