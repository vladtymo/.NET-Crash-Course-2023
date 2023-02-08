using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    enum Menu { Calculatesum = 1, Sortarray = 2, evendigits =3, maxinarray=4};
    public class Arraywithmenu
    {
        public void arrays()
        {
            Random rnd = new Random();

            int[] a = new int[20];

            for (int i = 0; i < 20; i++)
            {
                a[i] = rnd.Next(0, 100);
            }

            Console.WriteLine($"Enter number of task:\n"
                + $"{(int)Menu.Calculatesum} - Calculate sum of digits in array\n"
                + $"{(int)Menu.Sortarray} - Sort a number of array\n"
                + $"{(int)Menu.evendigits} - Find a even digits in array\n"
                + $"{(int)Menu.maxinarray} - Find maximum digits in array");

            Menu selection = (Menu)Enum.Parse(typeof(Menu),Console.ReadLine());

            int sum = 0;
            int count = 0;

            Console.WriteLine();
            for(int i =0;i<20;i++)
            {
                Console.Write($"{a[i]}  ");
            }
            Console.WriteLine();

            switch (selection)
            {
                case Menu.Calculatesum:
                    for(int i =0; i < 20; i++)
                    {
                        sum += a[i];
                    }
                    Console.WriteLine($"Sum of digits = {sum}");
                    break;
                case Menu.Sortarray:
                    Array.Sort(a);
                    for(int i =0; i < 20; i++)
                    {
                        Console.Write($"{a[i]} ");
                    }
                    break;
                case Menu.evendigits:
                    for(int i =0; i < 20; i++)
                    {
                        if (a[i] % 2 == 0)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"Count of even digits = {count}");
                    break;
                case Menu.maxinarray:
                    Array.Sort(a);
                    Console.WriteLine($"Maximum digit in array is {a[19]}");
                    break;

            }

        }
    }
}
