using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.DesignerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Space_delete
    {
        public void spc_del()
        {
            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine();

            char[] word = text.ToCharArray();

            int dot = 0;

            for(int i =0; i< word.Length; i++)
            {
                if (word[i] == '.')
                {
                    dot++;
                }

                    else if (dot >= 1 && dot <= 2)
                    {
                        if (word[i] == ' ')
                        {
                            word[i] = '拼';
                        }
                    }
            }

            string revtext = new string(word);

            revtext = revtext.Replace("拼", "");

            Console.WriteLine(revtext);

            /*for(int i =0; i< word.Length; i++)
            {
                Console.Write(word[i]);
            }*/
        }
    }
}
