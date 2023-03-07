Random rand = new Random();
Task1();
Task2();
Task3_4();

void Task1()
{
    Console.Write("Enter 1 symbol: ");
    string symbol = Console.ReadLine();
    Console.Write("Enter length of line: ");
    int length = int.Parse(Console.ReadLine());
    for (int i = 0; i < length; i++)
        Console.Write(symbol);
    Console.WriteLine("\n");
}

void Task2()
{
    Console.WriteLine("----------------- Guess number -----------------");
    Console.Write("Enter number (1-10): ");
    int number = int.Parse(Console.ReadLine());
    int num = rand.Next(10) + 1;
    if (num == number)
        Console.WriteLine($"You guessed! The number is: {num}\n");
    else
        Console.WriteLine($"You didn't guess! The number is: {num}\n");
}

void Task3_4()
{
    int[] arr = new int[20];
    Console.Write("Array: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(101);
        Console.Write($"{arr[i]} ");
    }
    int choose = 0;
    while (choose < 1 || choose > 4)
    {
        Console.Write("\nChoose action: \n1 - Summary of all elements in array;\n2 - Sort array;\n3 - Count of pair numbers;\n4 - Maximum element.\nEnter: ");
        choose = int.Parse(Console.ReadLine());
    }
    switch (choose)
    {
        case 1:
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            Console.WriteLine($"Summary: {sum}");
            break;
        case 2:
            Array.Sort(arr);
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            break;
        case 3:
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    count++;
            }
            Console.WriteLine($"Count: {count}");
            break;
        case 4:
            int max = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= max)
                    max = arr[i];
            }
            Console.WriteLine($"Maximum: {max}");
            break;
    }
}
