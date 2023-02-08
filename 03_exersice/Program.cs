using System;
using System.Globalization;
using System.Security.Cryptography;

namespace project
{
    enum Menu { Suma = 1, Sort = 2, EvenValues = 3, MaxValues = 4}
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1            
            string symbol;
            int length, counter = 0;
            Console.Write("Enter symbol: ");
            symbol = Console.ReadLine();
            Console.Write("Enter length of lines: ");
            length = Convert.ToInt32(Console.ReadLine());

            while (counter < length)
            {
                Console.Write(symbol);
                ++counter;
            }

            //Task 2
            Random random = new Random();
            int i = random.Next(10);
            int count = 1;
            Console.WriteLine("Computer guessed a number from 0 to 9, try to guess it!");
            Console.WriteLine("Enter number: ");
            int k = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (i == k)
                {
                    Console.WriteLine("Yes! You guessed it, the computer guessed the number " + k + "!");
                    break;
                }
                else
                {
                    count++;
                    Console.WriteLine("Try to guess again! Enter number: ");
                    k = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine($"Number of attempts: {count}");

            //Task 3
            int[] array = new int[20];
            Random random= new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
                Console.WriteLine(array[i]);
            }


            //Task 4
            Console.WriteLine("Choose variant:\n" +
                $"{(int)Menu.Suma} - {Menu.Suma}\n" +
                $"{(int)Menu.Sort} - {Menu.Sort}\n" +
                $"{(int)Menu.EvenValues} - {Menu.EvenValues}\n" +
                $"{(int)Menu.MaxValues} - {Menu.MaxValues}\n");

            Menu menu = Enum.Parse<Menu>(Console.ReadLine());

            switch (menu)
            {
                case Menu.Suma:
                    const int MaxN = 20;
                    int sum = 0;
                    for (int j = 0; j < MaxN; j++)
                        if (array[j] > 0)
                            sum = sum + array[j];
                    Console.WriteLine($"Suma = {sum} ");
                    break;
                case Menu.Sort:
                    for(int k = 0; k < array.Length; k++)
                    {
                        Console.Write(array[k] + " ");
                    }
                    Array.Sort(array);
                    Array.Reverse(array);
                    Console.WriteLine();

                    for(int k = 0; k < array.Length; k++)
                    {
                        Console.Write(array[k] + " ");
                    }
                    Console.Read();
                    break;
                case Menu.EvenValues:
                    int n = 20, l, count = 0;
                    for(l = 0; l < n; l++)
                    {
                        if ((array[l] % 2) == 0)
                            count++;
                    }
                    Console.WriteLine($"Even Values: {count}");
                    break;
                case Menu.MaxValues:
                    int MaxValue = array.Max();
                    Console.WriteLine(MaxValue);
                    break;
            }   
        }
    }

}