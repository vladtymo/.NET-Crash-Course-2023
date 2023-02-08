int[] array = new int[20];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(0, 100);

foreach (int num in array) Console.Write(num + " ");

Console.WriteLine();

Console.WriteLine("\n1 - обрахувати суму чисел в масиві\n" +
    "2 - відсортувати масив\n" +
    "3 - знайти кількість парних значень\n" +
    "4 - знайти максимальний елемент\n");

while (1 > 0) 
{
    

    int res = int.Parse(Console.ReadLine());

    int sum = 0;

    if (res == 1)
    {
        for (int i = 0; i < array.Length; ++i) sum += array[i];

        Console.WriteLine($"сума чисел в масиві = {sum}\n");
    }
    else if (res == 2)
    {
        Array.Sort(array);
        Console.WriteLine($"відсортований масив: ");
        foreach (int num in array) Console.Write(num + " ");
        Console.WriteLine("\n");  
    }
    else if (res == 3)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i] % 2 == 0) ++counter;

        }
        Console.WriteLine($"кількість парних значень = {counter}\n");
    }
    else if (res == 4)
    {
        int maxValue = array.Max();
        Console.WriteLine($"максимальний елемент = {maxValue}\n");
    }
    else
    {
        break;
    }
}
