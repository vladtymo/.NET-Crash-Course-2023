using System;

namespace FillArrayWithRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next();
            }
            Console.WriteLine("Array filled with random numbers:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}

