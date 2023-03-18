
using System;
internal class Program
{
    static void InitializeArray(int[] array, Func<int> generateValue)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = generateValue();
        }
    }

    static void InitializeArray(int[] array, Func<int, int> generateValue)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = generateValue(i);
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
 {
        int[] randomArray = new int[15];
        InitializeArray(randomArray, () => new Random().Next(1, 101));
        Console.WriteLine("Random array: ");
        PrintArray(randomArray);

        int[] powersOfTwoArray = new int[10];
        InitializeArray(powersOfTwoArray, i => (int)Math.Pow(2, i + 1));
        Console.WriteLine("Powers of two array: ");
        PrintArray(powersOfTwoArray);

        int[] steppedArray = new int[20];
        InitializeArray(steppedArray, i => i * 3);
        Console.WriteLine("Stepped array: ");
        PrintArray(steppedArray);
    }
}
