using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Reverse
    {
        public void Reversestring()
        {
            Console.WriteLine("Enter you text:");

            string originaltext = Console.ReadLine();

            char[] arrtext = originaltext.ToCharArray();
            Array.Reverse(arrtext);

            Console.WriteLine($"Reversed text: {arrtext}");

        }
    }
}
