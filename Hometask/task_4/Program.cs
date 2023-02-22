using System.Net.Http.Headers;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Task5();
    }

    public static void Task1()
    {
        Console.WriteLine("Enter line: ");
        string str1 = Console.ReadLine()!;
        string str2 = "";
        for (int i = str1.Length; i > 0; i--)
        {
            str2 += str1[i];
        }
        Console.WriteLine(str2);
    }

    public static void Task2()
    {
        string str = "Hi, my name is Bob!";
        Console.WriteLine($"Count ' ': {str.Split(' ').Count() - 1}");
    }

    public static void Task3() 
    {
        string str = "There are many VARIATION of passages of Lorem Ipsum available";
        int upperLetter = 0;
        int lowerLetter = 0;
        foreach (char symbol in str)
        {
            char.IsLower(symbol);
            if (char.IsLower(symbol))
                lowerLetter++;
            else if (char.IsUpper(symbol))
                upperLetter++;
        }
        Console.WriteLine($"Procent upper letter: {upperLetter * 100 /(float) str.Length}\n" +
            $"Procent lower letter: {lowerLetter * 100 /(float) str.Length}");
        Console.WriteLine(str.Length + " " + upperLetter + " " + lowerLetter);

    }

    public static void Task4() 
    {
        Console.WriteLine("Enter text: ");
        string str = Console.ReadLine()!;
        string abbreviation = "";
        string[] tm = str.Split(' ',  StringSplitOptions.RemoveEmptyEntries );
        foreach(string st in tm)
        {
            abbreviation += st[0];
        }
        Console.WriteLine($"Abbreviation: {abbreviation.ToUpper()}");
    }

    public static void Task5() 
    {
        StringBuilder stringBuilder = new StringBuilder();
        do
        {
            Console.WriteLine("Enter word: ");
            stringBuilder.Append( Console.ReadLine());
            if(!stringBuilder[stringBuilder.Length - 1].Equals('.'))
                stringBuilder.Append(", ");
        }
        while (!stringBuilder[stringBuilder.Length-1].Equals('.'));
        
        Console.WriteLine($"Word after commas: {stringBuilder}");

    }
}