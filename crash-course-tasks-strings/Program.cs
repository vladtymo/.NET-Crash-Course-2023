using System.Runtime.InteropServices;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //Task 4
        //Console.WriteLine("Enter text");
        //string str = Console.ReadLine()!;
        //Console.WriteLine(Abbreviations(str));
       
    }

    static void deleteSpaces()
    {
        Console.WriteLine("Enter text");
        string str = Console.ReadLine()!;
        int dot_index = str.IndexOf('.');

        while (str[dot_index++] != '.')
        {
            if (str[dot_index] == ' ')
            {
                str = str.Remove(dot_index, 1);
            }
            ++dot_index;
        }

        Console.WriteLine("Changed string");
        Console.WriteLine(str);
    }

    static void creatingSentence()
    {
        Console.WriteLine("Enter words. If you want to stop just enter \".\" in end of word ");
        string str = " ";
        StringBuilder stringBuilder = new StringBuilder();

        while (str[str.Length - 1] != '.')
        {
            str = Console.ReadLine()!;
            stringBuilder.Append($"{str}, ");
        }

        Console.WriteLine(stringBuilder.ToString());
    }

    static string Abbreviations(string text)
    {
       StringBuilder stringBuilder = new StringBuilder();
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            stringBuilder.Append(words[i][0]);
        }

       return stringBuilder.ToString();
    }

    static void lowerUpper()
    {
        Console.WriteLine("Enter text");
        string str = Console.ReadLine()!;
        int big_letter_counter = 0;
        int small_letter_counter = 0;
        int letter_counter = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsUpper(str[i]))
            {
                ++big_letter_counter;
            }
            else if (Char.IsLower(str[i]))
            {
                ++small_letter_counter;
            }
            ++letter_counter;
        }

        double upper_percent = ((double)big_letter_counter / (double)letter_counter) * 100;
        double lower_percent = 100 - upper_percent;
        Console.WriteLine($"Upper letter is {(int)upper_percent}%({big_letter_counter})");
        Console.WriteLine($"Lower letter is {(int)lower_percent}%({small_letter_counter})");

    }

    static void reversWords()
    {
        string str = Console.ReadLine()!;

        string[] words = str.Split(' ');

        Console.WriteLine("Words in reverse direction");

        for (int i = words.Length - 1; i >= 0; i--)
        {
            Console.Write(words[i] + " ");
        }
    }

    static void spaceCounter()
    {
        string str = Console.ReadLine()!;
        int space_counter = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                ++space_counter;
            }
        }

        Console.WriteLine($"Count of spaces is {space_counter}");
    }
}