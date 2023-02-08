using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Randomdigit
    {
        public void randvalue()
        {
            Random rnd = new Random();
            int randomvalue = rnd.Next(0, 10);

            int attempt = 0;

            while (true)
            {
                attempt++;
                Console.WriteLine("Can you guess a intenger? From 0 to 10");

                int value = int.Parse(Console.ReadLine());

                if (value == randomvalue)
                {
                    Console.WriteLine($"You win, you use {attempt} attempt");
                    break;
                }
            }
        }
    }
}
