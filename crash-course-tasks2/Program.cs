
using System.Diagnostics.Tracing;

internal class Program
{
    enum Operations {CountSum = 1, Sort, CountCouples, FindMax}; 

    private static void Main(string[] args)
    {
        arrayOperations();
    }

    static void printLine()
    {
        Console.WriteLine("Enter symbol of line");
        char symbol = char.Parse(Console.ReadLine());

        Console.WriteLine("Enter array size");
        int size = int.Parse(Console.ReadLine());

        char[] line = new char[size];
        Array.Fill(line, symbol);

        Console.WriteLine("Your line is:");
        for (int i = 0; i < line.Length; i++)
        {
            Console.Write(line[i]);
        }

    }
    static void guessNumber()
    {
        Random random = new Random();
        int random_num = random.Next(1, 20);

        Console.WriteLine("Try to guess number from 1 to 20");
        int entered_num = 0;
        int attempts_counter = 0;

        do
        {
            entered_num = int.Parse(Console.ReadLine());
            ++attempts_counter;

            if (entered_num < random_num)
            {
                Console.WriteLine("Entered number is less then random");
            }
            else if (entered_num > random_num)
            {
                Console.WriteLine("Entered number is bigger then random");
            }
            
        } while (entered_num != random_num);

        Console.WriteLine($"Congratulations!\nYou had to {attempts_counter} attempts! ");
    }
    static void arrayOperations()
    {
        Random random = new Random();

        int[] numbers = new int[20];

        Console.WriteLine("Array is");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 100);
            Console.Write(numbers[i] + " ");
        }

        Console.Write($"\n{(int)Operations.CountSum} -- {Operations.CountSum}\n" +
            $"{(int)Operations.Sort} -- {Operations.Sort}\n" +
            $"{(int)Operations.CountCouples} -- {Operations.CountCouples}\n" +
            $"{(int)Operations.FindMax} -- {Operations.FindMax}\n");

        Operations operation = Enum.Parse<Operations>(Console.ReadLine());
        int sum = 0;
        int couples_counter = 0; 

        switch (operation)
        {
            case Operations.CountSum:
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine($"Sum of all elements: {sum}");
                break;

            case Operations.Sort:
                Array.Sort(numbers);

                Console.WriteLine("Sorted array is");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                break;

            case Operations.CountCouples:
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write(numbers[i] + " ");
                        ++couples_counter;
                    }
                }
                Console.WriteLine($"\nCount of couples is {couples_counter}");
                break;

            case Operations.FindMax:
                Console.WriteLine( $"Max number in array is {numbers.Max()}");
                break;
            default:
                Console.WriteLine("There is no variant like that");
                break;
        }


    }
    

}