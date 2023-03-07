internal class Program
{
    private static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
    }

    private static void Task1()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine()!;
        string[] words = str.Split(new[] { ' ', ',', '.', '?', '!', ';' }, StringSplitOptions.RemoveEmptyEntries);
        foreach(string word in words.Reverse())
            Console.Write($"{word} ");
        Console.WriteLine("\n");
    }

    private static void Task2() 
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine()!;
        string[] words = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"Count of spaces: {words.Length - 1}\n");
    }

    private static void Task3() 
    {
        int count = 0, countUpper = 0, countLower = 0;
        Console.Write("Enter string: ");
        string str = Console.ReadLine()!;
        foreach (string word in str.Split(new[] { ' ', ',', '.', '?', '!', ';' }, StringSplitOptions.RemoveEmptyEntries))
        {
            foreach (char s in word)
            {
                count++;
                if (char.IsUpper(s)) countUpper++;
                if (char.IsLower(s)) countLower++;
            }
        }
        int perCountUpper = (countUpper * 100) / count;
        int perCountLower = (countLower * 100) / count;
        Console.WriteLine($"Count uppercase percentage: {perCountUpper}%");
        Console.WriteLine($"Count lowercase percentage: {perCountLower}%");
        Console.WriteLine();
    }

    private static void Task4()
    {
        string abr = "";
        Console.Write("Enter string: ");
        string str = Console.ReadLine()!;
        foreach (string word in str.Split(new[] { ' ', ',', '.', '?', '!', ';' }, StringSplitOptions.RemoveEmptyEntries))
            abr += word[0];
        Console.WriteLine($"Result: {abr.ToUpper()}\n");
    }

    private static void Task5()
    {
        Console.Write("Enter word: ");
        string str = Console.ReadLine()!;
        string res = str;
        while (!str.EndsWith('.'))
        {
            Console.Write("Enter word: ");
            str = Console.ReadLine()!;
            res += (", " + str);
        }
        Console.WriteLine(res);
        Console.WriteLine();
    }

    private static void Task6()
    {
        bool isBFSD = false;
        int times = 2;
        string res = "";
        Console.Write("Enter string: ");
        string str = Console.ReadLine()!;
        foreach (char s in str)
        {
            if(s == '.' && times > 0)
            {
                isBFSD = !isBFSD;
                times--;
            }
            if(!isBFSD || s != ' ')
                res += s;
        }
        Console.WriteLine(res);
        Console.WriteLine();
    }
}

