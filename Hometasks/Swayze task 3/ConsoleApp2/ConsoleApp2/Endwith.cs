using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Endwith
    {
        public void Formattext() {
            Console.WriteLine("Enter your text:");

            List<string> lines = new List<string>();
            int i = 0;
            int j = 1;
                while (true)
                    {
                        string text = Console.ReadLine();
                lines.Add(text); 


                        if (text.EndsWith("."))
                        {
                            break;
                        }
                        i++;
                j++;
                    }
            string result = string.Join(", ", lines);
            Console.WriteLine(result);
        }
    }
}
