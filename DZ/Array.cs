using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)

        {
            /* try
             {
                 char symb = char.Parse(Console.ReadLine());
                 line(symb);
             }
             catch
             {
                 Console.WriteLine("Enter correct char");
             }
            */
            /* try
               {

                   guessNumber();
               }
               catch
               {
                   Console.WriteLine("Enter correct number (int)");
               }
            */


           fillingArray();

        }


       

        static private void line(char param)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write(param);
            }
        }

        static private void guessNumber()
        {
            var randomNum= new Random();
            bool win = false;
            int attempts = 0;
            do
            {
                Console.WriteLine("Enter data");
                int num = int.Parse(Console.ReadLine());
                attempts++;

                if (num != randomNum.Next(0, 5))
                {
                    Console.WriteLine("Try again");
                }
                else
                {
                    Console.WriteLine($"You won! and were {attempts} attempts ");
                    win = true;
                }
            }
            while (win != true);

        }
        static private void fillingArray()
        {

        int[]array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                var randomNum = new Random();
                array[i] = randomNum.Next(0, 100);
                Console.WriteLine(array[i]);
            }

            Console.WriteLine ("Even Max Sort Sum");
            string method = Console.ReadLine();
            int max = 0;
            int sum = 0;
            switch (method)
            {
                case "Sort":

                    Array.Sort(array);
                    for (int i = 0; i < array.Length; i++)
                    {

                        Console.WriteLine(array[i]);
                    }
                    break;
                case "Even":

                    for (int i = 0; i < array.Length; i++)
                    {
                        if(array[i]%2==0) Console.WriteLine(array[i]);

                    }
                    break;

                case "Max":
                    for (int i = 0; i < array.Length; i++)
                    {
                        
                        if (array[i] > max)
                        {
                            max = array[i];
                            Console.WriteLine(max);
                        }

                    }
                    break;

                case "Sum":
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                       

                    }
                    Console.WriteLine(sum);
                    break;
            }


          
        }
            
        

    }

    


}

    
