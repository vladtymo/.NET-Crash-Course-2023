using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                Random random = new Random();
                arr[i] = random.Next(0, 101);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }



        }
    }
}
