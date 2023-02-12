using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Abbreviation
    {
        public void Abbs()
        {
            Console.WriteLine("Enter your text:");

            string text = Console.ReadLine();

            string[] words = text.Split(new[] { ' ', ',', '.', '?', '!', ';' });

            char[] words2 = new char[words.Length];

            for( int i =0; i< words.Length; i++ )
            {
                char[] word = new char[words[i].Length];
                char[] word3 = words[i].ToCharArray();
                words2[i]= word3[0];
            }

            string word4 = string.Join("", words2);

            Console.WriteLine(word4.ToUpper());
        }
    }
}
