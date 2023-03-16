using System;

    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            int spaceCount = 0;
            foreach (char c in input){
                if (c == ' '){
                    spaceCount++;
                }
            }
            Console.WriteLine("The number of spaces in the str is: " + spaceCount);
        }
    }

