using System;

public class HelloWorld
{



    public static void Main(string[] args)
    {

        Console.Write("\n\n\t\t Вевідть ваш рядок: ");

        string line = Console.ReadLine();

        string[] str = line.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);


        for (int i = str.Length - 1; i >= 0; --i)
            Console.Write(str[i] + " ");


        int space = 0;


        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == ' ')
            {
                ++space;
            }
        }

        Console.WriteLine($"\n\n\t\t Кількість пробілів : {space}");

        int up = 0;
        int lw = 0;

        for (int i = 0; i < line.Length; ++i)
        {
            if (line[i] != ' ' && line[i] != '.' && line[i] != ',' && line[i] != '!')
            {
                if (Char.IsUpper(line[i]))
                    ++up;
                else if (Char.IsLower(line[i]))
                    ++lw;
            }
        }

        int count = 0;
        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] != ' ' && line[i] != '.' && line[i] != ',' && line[i] != '!')
            {
                ++count;
            }
        }
        Console.WriteLine($"Count :  {count}");
        Console.WriteLine($"IsUpper :  {up}");
        Console.WriteLine($"IsLower :  {lw}");

        double up_p = 100.0 / count * up;
        double lw_p = 100.0 / count * lw;
        Console.WriteLine($"IsUpper :  {up_p}%");
        Console.WriteLine($"IsLower :  {lw_p}%");

        string abbreviation = "";
        for (int i = 0; i < str.Length; i++)
        {
            abbreviation += str[i].First();
        }

        Console.WriteLine(abbreviation.ToUpper());




        string new_line = "";
        string check;
        while (true)
        {
            check = Console.ReadLine();
            new_line += check;
            if(check[check.Length-1] == '.') { break; }
            else { new_line += ", "; }


        }

        Console.WriteLine(new_line);
    }

}