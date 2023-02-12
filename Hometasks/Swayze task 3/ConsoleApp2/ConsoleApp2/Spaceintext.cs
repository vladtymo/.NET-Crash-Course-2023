using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace ConsoleApp2
{
    internal class Spaceintext
    {
        public void Spaces()
        {
            Console.Write("Enter your text:");
            string text = Console.ReadLine();

            char[] arrtext = text.ToCharArray();


            int space_count = 0;

            for (int i=0; i<arrtext.Length; i++)
            {
                if (Char.IsWhiteSpace(arrtext[i]))
                {
                    space_count++;
                }
            }

            Console.WriteLine($"Spaces in text: {space_count}");
        }
    }
}
