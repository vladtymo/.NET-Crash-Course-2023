using System;
using System.Globalization;
using System.Security.Cryptography;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.Write("Enter sentence: ");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            Console.WriteLine("Reversed: ");
            Array.Reverse(words);

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i] + " ");
            }
            Console.ReadKey();

            //Task 2
            int count;
            Console.Write("Enter sentence: ");
            string str = Console.ReadLine();
            count = str.Split(' ').Length;
            Console.WriteLine("The count is " + count);

            //Task 3
            Console.Write("Enter sentence: ");
            string str = Console.ReadLine();
            int upper = 0, lower = 0;
            int number = 0, special = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch >= 'A' && ch <= 'Z') upper++;
                else if (ch >= 'a' && ch <= 'z') lower++;
                else if (ch >= '0' && ch <= '9') number++;
                else special++;
            }
            Console.WriteLine("Upper case latters: " + upper);
            Console.WriteLine("Lower case latters: " + lower);
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Special characters:" + special);

            //Task 4
            Console.WriteLine(GenerationAbbr("Cascading style sheets:"));
            static string GenerationAbbr(string str)
            {
                string[] words = str.Split(' ');
                string abbreviation = " ";
                foreach (string word in words)
                {
                    abbreviation += word[0];
                }
                return abbreviation.ToUpper();
            }

            //Task 5
            Console.WriteLine("Enter words: ");
            string inputStr = Console.ReadLine();
            string resultStr = " ";
            while (!inputStr.EndsWith("."))
            {
                resultStr += resultStr + ",";
                inputStr = Console.ReadLine();
            }
            resultStr += inputStr.TrimEnd('.');
            Console.WriteLine("Result: " + resultStr);

            //Task 6
            Console.WriteLine("Enter the string:");
            string inputString = Console.ReadLine();
            string result = inputString.Replace(".", ".");
            Console.WriteLine("String after: " + result);
            Console.ReadLine();
        }       
    }
}