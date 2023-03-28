using System;

class Program
{
    static void Main(string[] args)
    {
        // масив з 15-ти елементів випадкових значень від 1 до 100
        int[] arr1 = InitializeArray(15, () => new Random().Next(1, 101));

        // масив з 10-ти елементів степенів двійки (2, 4, 8, 16…)
        int[] arr2 = InitializeArray(10, i => (int)Math.Pow(2, i + 1));

        // масив з 20-ти елементів із значеннями від 0 та кроком збільшення в 3 (0, 3, 6, 9, 12…)
        int[] arr3 = InitializeArray(20, i => i * 3);

        // масив з 10-ти елементів чисел Фібоначчі
        int[] arr4 = InitializeArray(10, i =>
        {
            if (i == 0 || i == 1)return 1;
           
            int a = 1;
            int b = 1;
            int c = 0;
            for (int j = 2; j <= i; j++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        });
    }

    static T[] InitializeArray<T>(int length, Func<T> generator)
    {
        T[] arr = new T[length];

        for (int i = 0; i < length; i++)
        {
            arr[i] = generator();
        }

        return arr;
    }

    static T[] InitializeArray<T>(int length, Func<int, T> generator)
    {
        T[] arr = new T[length];

        for (int i = 0; i < length; i++)
        {
            arr[i] = generator(i);
        }

        return arr;
    }
}