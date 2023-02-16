//--------------------- one-dimensional arrays

using System;

int[] numbers = new int[5] { 2, 9, 4, 5, 1 };
int[] numbers2 = { 1, 3, 4, 5, 5 };

Console.WriteLine(numbers[0].GetType()); // type Int
Console.WriteLine(numbers2.GetType()); // type Arr

numbers[0] = 25;
Console.WriteLine($"First el: {numbers[0]}");

numbers.SetValue(26, 0);
Console.WriteLine($"First el: {numbers.GetValue(0)}");

Console.WriteLine($"Lenght {numbers.Length}");
Console.WriteLine($"GetLength {numbers.GetLength(0)}");

//--------------------- two-dimensional arrays

int[,] matrix = new int[3, 2]
{
    { 1, 2 },
    { 3, 4 },
    { 5, 6 }
};

int[,] matrix2 =
{
    { 1, 2 },
    { 3, 4 },
    { 5, 6 }
};

Console.WriteLine($"Lenght {matrix.Length}");
Console.WriteLine($"GetLength {matrix.GetLength(0)} and {matrix.GetLength(1)}");
Console.WriteLine($"Rank {matrix.Rank}");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}

Console.WriteLine();
Array.Reverse(numbers);

foreach (int num in numbers)
{
    Console.Write(num + " ");
}

Console.WriteLine();
Array.Sort(numbers);

foreach (int num in numbers)
{
    Console.Write(num + " ");
}

Console.WriteLine();
Array.Fill(numbers, 5);

foreach (int num in numbers)
{
    Console.Write(num + " ");
}

Console.WriteLine();
Array.Resize(ref numbers, 10);

foreach (int num in numbers)
{
    Console.Write(num + " ");
}

Console.WriteLine();
int index = Array.IndexOf(numbers2, 50);
if (index == -1)
{
    Console.WriteLine("Error!");
}
else
{
    Console.WriteLine("Index of 50: " + index);
}
