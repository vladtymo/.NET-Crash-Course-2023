using System;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string of words: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            Array.Reverse(words);

            string output = string.Join(" ", words);

            Console.WriteLine("The reversed words are: " + output);
        }
    }
}

