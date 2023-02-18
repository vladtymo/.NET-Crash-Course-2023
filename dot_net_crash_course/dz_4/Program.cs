using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //Zavd1();
        //Zavd2();
        //Zavd3();
        //Zavd4();
        //Zavd5();
        //Zavd6();
    }

    private static void Zavd6()
    {
        string wordsString = Console.ReadLine();
        string[] wordsArray = wordsString.Split('.');

        StringBuilder builder = new StringBuilder();
        builder.Append(wordsArray[0] + '.');
        builder.Append(wordsArray[1].Replace(' ','\0'));
        builder.Append('.' + wordsArray[2]);
        Console.WriteLine(builder.ToString());
    }

    private static void Zavd5()
    {
        StringBuilder builder = new StringBuilder();
        bool dotCheck = false;

        while (dotCheck == false)
        {
            string word = Console.ReadLine();
            builder.Append(word);
            if (word.Contains('.'))
            {
                dotCheck= true;
                break;
            }
            builder.Append(", ");
        }
        Console.WriteLine(builder.ToString());
    }

    private static void Zavd4()
    {
        string wordsString = Console.ReadLine();
        string[] wordsArray = wordsString.Split(' ');
        StringBuilder builder = new StringBuilder();
        foreach (string i in wordsArray)
        {
            builder.Append(i.Substring(0, 1).ToUpper());
        }
        Console.WriteLine(builder.ToString());
    }

    private static void Zavd3()
    {
        string wordsString = Console.ReadLine();
        int upperSymb = 0, lowerSymb = 0;
        int allSymb = wordsString.Length;

        foreach (char i in wordsString)
        {
            if (char.IsUpper(i))
            {
                ++upperSymb;
            }
            else if (char.IsLower(i))
            {
                ++lowerSymb;
            }
        }

        Console.WriteLine($"Ratio of uppercase symbols {upperSymb * 100 / allSymb}");
        Console.WriteLine($"Ratio of lowercase symbols {lowerSymb * 100 / allSymb}");
    }

    private static void Zavd2()
    {
        string wordsString = Console.ReadLine();
        Console.WriteLine(wordsString.Split(' ').Count()-1);
    }

    private static void Zavd1()
    {
        string wordsString = Console.ReadLine();
        string[] wordsArray = wordsString.Split(' ');
        for (int i = wordsArray.Length-1; i>=0; i--)
        {
            Console.Write(wordsArray[i] + ' ');
        }
    }
}