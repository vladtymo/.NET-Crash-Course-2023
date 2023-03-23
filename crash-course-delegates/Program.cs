using System;
using System.Runtime.InteropServices;

namespace crash_course_delegates
{
    internal class Program
    {
        delegate int Generate(int num);

        static int GenerateNum(int num)
        {
            Random random = new Random();
            num = random.Next(1, 100);

            return num;
        }
        
        public static int GenerateFibonacci(int n)
        {
            int number = n + 1;
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
        }

        static void GeneratedArray(int[] nums, Generate generate)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = generate(i);
                Console.Write($"{nums[i]} ");
            }
        }

       
        static void Main(string[] args)
        {
            int[] Fibonachi=new int[10];
            Fibonachi [0] = 0;
            Fibonachi[1] = 1;
            int step = 0;

            int[] nums = new int[15];
            int[] pows = new int[10];
            int[] steps = new int[20];
            GeneratedArray(steps, (num) => (step = 3 * num));
            Console.WriteLine();
            GeneratedArray(nums, GenerateNum);
            Console.WriteLine();
            GeneratedArray(pows, num => ((int)Math.Pow(2, num)));
            Console.WriteLine();
            GeneratedArray(Fibonachi, GenerateFibonacci);
        }
    }
}