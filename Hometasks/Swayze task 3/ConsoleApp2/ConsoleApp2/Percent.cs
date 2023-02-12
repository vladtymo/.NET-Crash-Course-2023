using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Percent
    {
        public void percintext() 
        {
            Console.WriteLine("Enter your text:");

            string text = Console.ReadLine();
            char[] arrtext = text.ToCharArray();

            int lowers = 0;
            int uppers = 0;

            for(int i =0; i<arrtext.Length; i++)
            {
                if (Char.IsUpper(arrtext[i]))
                {
                    uppers++;
                }
                else if (Char.IsLower(arrtext[i]))
                {
                    lowers++;
                }
            }

            decimal result;

            if (lowers > uppers) {
                result = (decimal)(lowers / uppers);
            }
            else
            {
                result = (decimal)(uppers/lowers);
            }

            Console.WriteLine($"Result in percent: {result:P}");
            
        }
    }
}
