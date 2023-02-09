
//3. Створити масив із 20-ти цілих чисел та заповнити
//його випадковими значеннями від 0 до 100.
using System;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

enum Tasks { task1 = 1, task2 = 2, task3 = 3 };
internal class Program
{

    private static void Main(string[] args)
    {
        int[] massive = new int[10];
        int res = 0;
        Random RandomNumberArray = new Random();

        for (int i = 0; i < massive.Length; i++)
        {
            massive.SetValue(RandomNumberArray.Next(100), i);
        }


        Console.Write("Array with filled foreach(): ");
        foreach (int num in massive)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();




        Tasks tasks;
        Console.WriteLine(res);
        string input = Console.ReadLine();
        bool sucess = Enum.TryParse<Tasks>(input, out tasks);
        if (!sucess)
        {
            Console.WriteLine("entry {0} is not a valid value", input);
            return;
        }
        Console.WriteLine("Введiть завдання яке будемо виконувати\n" +
            "1.     - обрахувати суму чисел в масиві\r\n:\n" +
            "2.     - відсортувати масив\r\n:\n" +
            "3.     - знайти кількість парних значень\r\n:");
        switch (tasks)
        {
            case Tasks.task1:
                int sum = massive.Sum();
                Console.WriteLine(sum);
                break;
            case Tasks.task2:
                Array.Sort(massive);
                Console.Write("Array with sorted foreach():");
                foreach (int num in massive)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
                break;
            case Tasks.task3:
                for (int i = 0; i < massive.Length; i++)
                {
                    if (massive[i] % 2 == 0) res++;
                }
                Console.WriteLine(res);
                break;
        }
    }
}