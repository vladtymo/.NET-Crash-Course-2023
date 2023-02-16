using System.Diagnostics.Metrics;

enum ArrayOption { SUM = 1, SORT, MAX, EVEN };

internal class Program
{
    private static void Main(string[] args)
    {
        //Zavd1();
        //Zavd2();

        Random random = new Random();
        int[] numbers = new int[20];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 101);
        }

        //Zavd34(numbers);
    }

    private static void Zavd34(int[] numbers)
    {
        
        foreach (int i in numbers)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine();
        Console.WriteLine("Please select the option:\n" +
                $"{(int)ArrayOption.SUM} = Get sum of array\n" +
                $"{(int)ArrayOption.SORT} = Sort array\n" +
                $"{(int)ArrayOption.MAX} = Get max value of array\n" +
                $"{(int)ArrayOption.EVEN} = Get count of all even elements\n" +
                $"Any numeric = Exit\n"
        );

        ArrayOption arOp = Enum.Parse<ArrayOption>(Console.ReadLine());

        switch (arOp)
        {
            case ArrayOption.SUM:
                int sum = 0;
                foreach (int i in numbers)
                {
                    sum += i;
                }
                Console.WriteLine($"Sum of array values is {sum}\n");
                Zavd34(numbers);
                break;

            case ArrayOption.SORT:
                int[] numbersSort = new int[20];
                Array.Copy(numbers,numbersSort,20);
                Array.Sort(numbersSort);
                Console.Write("Sorted array is ");
                foreach (int i in numbersSort)
                {
                    Console.Write($"{i} ");
                }
                Console.Write("\n\n");
                Zavd34(numbers);
                break;

            case ArrayOption.MAX:
                Console.WriteLine($"Max value of array is {numbers.Max()}\n");
                Zavd34(numbers);
                break;

            case ArrayOption.EVEN:
                int counter = 0;
                foreach (int i in numbers)
                {
                    if (i % 2 == 0)
                    {
                        ++counter;
                    }
                }
                Console.WriteLine($"Count of all even elements is {counter}\n");
                Zavd34(numbers);
                break;

            default:
                break;
        }

    }

    private static void Zavd2()
    {
        Random random = new Random();
        int requiredNumber = random.Next(0, 10);
        int guessedNumber = -1;
        int counter = 0;

        Console.WriteLine("Guessed a number from 0 to 10. Guess which one!");
        while (requiredNumber != guessedNumber)
        {
            guessedNumber = int.Parse(Console.ReadLine());
            ++counter;
            if (requiredNumber != guessedNumber)
            {
                Console.WriteLine("Try again!");
            }
        }
        Console.WriteLine($"Required number is {requiredNumber}, number of attempts is {counter}");

    }

    private static void Zavd1() 
    {
        try
        {
            int n = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(symbol);
            }
        }
        catch
        {
            Console.WriteLine("Помилка!");
        }
    }

}