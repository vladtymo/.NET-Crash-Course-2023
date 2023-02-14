using System;
using System.IO;
using System.Linq;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            abbreviation();

        }


        static private void reverseString()
        {
            string str = "Hello world";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }

        }

        static private void calculateSpase()
        {
            Console.WriteLine("Enter some text");
            string str = Console.ReadLine();
            int countSpace = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    countSpace++;
                }

            }

            Console.WriteLine(countSpace);
        }

        static private void lowerUpperAmount()
        {
            char[] upperSymbols = {'Q','W','E','R','T','Y','U','I','O','P',
                'A','S','D','F','G','H','J','K','L','Z','X','C','V','B',
                'N','M'};
            char[] lowerSymbols = {'q','w','e','r','t','y','u','i','o','p',
                'a','s','d','f','g','h','j','k','l','z','x','c','v','b',
                'n','m'};

            Console.WriteLine("Enter some text");
            string str = Console.ReadLine();
            double countUpper = 0;
            double countLower = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (str[i] == upperSymbols[j]) ++countUpper;

                    else if (str[i] == lowerSymbols[j]) ++countLower;

                }

            }
            int stringLen =  str.Length;
            
            double resultUpper = (countUpper / stringLen * 100);
            double resultLower = ( countLower / stringLen * 100);
            Console.WriteLine($"Lower case: {(double)resultLower}% \nUpper case: {(double)resultUpper}% ");
        }
        static private void abbreviation()
        {
            string s = "asdc.,, bcsdc.,, cfgc,.";
            string[] parts = s.Split(new char[] { ' ', '.', ',' });
             
           
            string result = String.Concat(parts.Select(part => char.ToUpper(part[0])));
            Console.WriteLine(result);

        }

    }
}