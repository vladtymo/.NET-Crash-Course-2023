using System;

namespace String {
    class Program {
        static void Main( string[] args) {
            Console.WriteLine( " Enter a string: ");
            string stringInput = Console.ReadLine();
            int lower, upper = 0;

            foreach (char ch in stringInput) {
                if (char.IsLower(ch)) {
                    ++lower;
                }
                else if (char.IsUpper(ch)) {
                    ++upper;
                }
            }

            float lowerPerc = (float)lower/stringInput.Length * 100;
            float upperPerc = (float)upper/stringInput.Length * 100;

            Console.WriteLine("Percentage of lowercase letters: " + lowerPerc + "%");
            Console.WriteLine("Percentage of uppercase letters: " + upperPerc + "%");
        }
    }
}

