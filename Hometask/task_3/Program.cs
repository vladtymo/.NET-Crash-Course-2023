
enum Options { Sum = 1, Sort, Pair, MaxElement }
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------------Symbol Line------------");
        SymbolLine();
        Console.WriteLine("------------Game Guess Number------------");
        GameGuessNumber();
        Console.WriteLine("------------Arrey Task------------");
        ArreyTask();


    }

    public static void SymbolLine()
    {
        Console.WriteLine("Enter char: ");
        char symbol = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter count: ");
        int digit = int.Parse(Console.ReadLine());
        Console.WriteLine($"\n{new string(symbol, digit)}");
    }

    public  static void GameGuessNumber()
    {
        Random rnd = new Random();
        Console.WriteLine("Enter your variant: ");
        int number = rnd.Next(0, 10);
        int digit = int.Parse(Console.ReadLine()); ;
        int count = 0;
        while (digit != number)
        {
            Console.WriteLine($"Incorrect try again: {number}");
            digit = int.Parse(Console.ReadLine());
            count++;
        }
        Console.WriteLine("Your Win!!!!\n" +
                            $"Count = {count}");
    }

    public static void ArreyTask()
    {
        int[] Arr = new int[20];
        for (int i = 0; i < 20; i++)
        {
            Random rnd = new Random();
            Arr[i] = rnd.Next(0, 100);

        }
        Console.WriteLine("[{0}]", string.Join(", ", Arr));

        Console.WriteLine("Choose options: \n" +
                            $"{(int)Options.Sum} - {Options.Sum}\n" +
                            $"{(int)Options.Sort} - {Options.Sort}\n" +
                            $"{(int)Options.Pair} - {Options.Pair}\n" +
                            $"{(int)Options.MaxElement} - {Options.MaxElement}\n");

        Options options = Enum.Parse<Options>(Console.ReadLine());

        switch (options)
        {
            case Options.Sum:
                Console.WriteLine($"Sum = {Arr.Sum()}");
                break;
            case Options.Sort:
                Array.Sort(Arr);
                Console.WriteLine("Sort array: [{0}]", string.Join(", ", Arr));
                break;
            case Options.Pair:
                Console.WriteLine($"Count pair number: {CountPairElement(Arr)}");
                break;
            case Options.MaxElement:
                Console.WriteLine($"Max element: {Arr.Max()}");
                break;
            default:
                Console.WriteLine("Invalid values ");
                break;
        }
    }
    public static int CountPairElement(int[] array)
    {
        int cont = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
                cont++;
        }
        return cont;
    }
}