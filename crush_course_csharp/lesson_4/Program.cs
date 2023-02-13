using System.ComponentModel;
using System.Security;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        TrimBetweenDots();
    }
    static void ReverseLine()
    {
        Console.WriteLine("Введіть рядок слів: ");
        string str = Console.ReadLine();
        string[] slova = str.Split(' ');
        for (int i = slova.Length - 1; i >= 0; i--)
        {
            Console.Write(slova[i] + " ");
        }
    }
    static void CountGap()
    {
        Console.WriteLine("Введіть рядок: ");
        string str = Console.ReadLine();
        int count = 0;
        foreach(char a in str)
        {
            if (a == ' ')
                count++;
        }
        Console.WriteLine("Кількість пробілів в рядку: " + count);
    }
    static void Relation()
    {
        Console.WriteLine("Введіть рядок: ");
        string str = Console.ReadLine();
        //------піднімаємо рядок у верхній регістр
        string strToUpper = str.ToUpper();
        //------підрахунок символів (в регістрах)
        int countLower = 0;
        int countUpper = 0;
        for(int i = 0; i < str.Length; i++)
        {
            if (Char.IsLetter(str[i]))
            {
                if (str[i] == strToUpper[i])
                    countUpper++;
                else
                    countLower++;
            }
        }
        Console.WriteLine($"Кількість % малих літер в рядку: {Math.Round((countLower / (double)str.Length) * 100, 2)}%");
        Console.WriteLine($"Кількість % великих літер в рядку: {Math.Round((countUpper / (double)str.Length) * 100, 2)}%");
    }
    static void Abbreviation()
    {
        Console.WriteLine("Введіть рядок: ");
        string str = Console.ReadLine();
        string[] slova = str.Split(' ');
        string abrev = "";
        foreach(string s in slova)
        {
            if (Char.IsLetter(s[0]) && s.Length > 2)
            {
                abrev += s[0].ToString().ToUpper();
            }
        }
        Console.WriteLine("Абревіатура: " + abrev);
    }
    static void CreateLine()
    {
        string result = "";
        bool checkDot = false;
        do
        {
            string str = Console.ReadLine();
            if (str[str.Length - 1] == '.')
            {
                checkDot = true;
                result += str;
            }
            else
                result += str + ", ";
        } while (!checkDot);
        Console.WriteLine(result);
    }
    static void TrimBetweenDots()
    {
        Console.WriteLine("Введіть рядок: ");
        string str = Console.ReadLine();
        string[] trimArray = str.Split('.');
        trimArray[1] = trimArray[1].Replace(" ", "");
        string result = "";
        for(int i = 0; i < trimArray.Length; i++)
        {
            if(i != trimArray.Length - 1)
                result += trimArray[i] + '.';
            else
                result += trimArray[i];
        }
        Console.WriteLine(result);
    }
}