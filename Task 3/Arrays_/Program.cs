using System.Collections;

internal class Program
{
    enum Direction { Sum = 1, Sort, EvenValues, Max }
    private static void Main(string[] args)
    {

        Console.WriteLine("--------TASK 1---------");
        Console.Write("Enter line length: ");
        int lenghtLine = int.Parse(Console.ReadLine());
        Console.Write("Enter symbols: ");
        char symbol = char.Parse(Console.ReadLine());

        for (int i = 0; i < lenghtLine; i++)
        {
            Console.Write($"{symbol}");
        }


        Console.WriteLine("\n\n--------TASK 2---------");

        Random random = new Random();
        int num = random.Next(1, 50);
        Console.Write("Try to quess the number: ");
        int answer = int.Parse(Console.ReadLine());

        while (num != answer)
        {
            Console.Write("Try to quess the number: ");
            answer = int.Parse(Console.ReadLine());
            if (answer == num) Console.WriteLine("Congratulatiouns! ");
            if (answer < num) Console.WriteLine("This number is greater than " + answer);
            if (answer > num) Console.WriteLine("This number is less than " + answer);
            if (answer < 0 || answer > 50) Console.WriteLine("The range of numbers is from 1 to 50");

        }

        Console.WriteLine("\n\n--------TASK 3---------");

        int[] arr = new int[20];
        Console.Write($"Array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(0, 100);
            Console.Write($"{arr[i]} ");
        }


        Console.WriteLine("\n\n--------TASK 4---------");

        Console.WriteLine("Enter what you want to do: \n" +
            $"{(int)Direction.Sum} - sum in array\n" +
            $"{(int)Direction.Sort} - sort in array\n" +
            $"{(int)Direction.EvenValues} - even values in array\n" +
            $"{(int)Direction.Max} - max element in array\n");

        Direction direction = Enum.Parse<Direction>(Console.ReadLine());
            switch (direction)
            {
                case Direction.Sum:
                    Console.WriteLine("Array sum: " + arr.Sum());
                    break;

                case Direction.Sort:
                    Array.Sort(arr);
                    foreach (int i in arr)
                    {
                        Console.Write(i + " ");
                    }
                    break;

                case Direction.EvenValues:
                    int result = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            result++;
                        }

                    }
                    Console.WriteLine("Even values in array: " + result);
                    break;

                case Direction.Max:
                    Console.WriteLine("Max value is: " + arr.Max());
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;

            }


    }
}