internal class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Yellow;

        //----------------------------------------1---------------------------//
        /*
        Console.WriteLine("Введіть рядок слів: ");
        string s = Console.ReadLine();
        string[] a = s.Split(' ');
        Array.Reverse(a);
        Console.WriteLine("Reverse String is:");
        for (int i = 0; i <= a.Length - 1; i++)
        {
            Console.Write(a[i] + "" + ' ');
        }*/

        //-------------------------2--------------------------//

        /*
         Console.WriteLine("Введіть рядок слів: ");
        string s = Console.ReadLine();
        int i = 0;
        string[] a = s.Split(' ');
        foreach(var a2 in a)
        {
            i++;
        }
        Console.WriteLine("кількість пробілів: " + (i-1));*/

        //---------------------3--------------------------//

        /*
         Console.WriteLine("Введіть рядок слів: ");
        string s = Console.ReadLine();
        double upper = 0, lower = 0;
        double n = s.Count();
        foreach(char c in s)
        {
            if(char.IsUpper(c))
                upper++;
            else if(char.IsLower(c))
                lower++;
        }
        double UP = (upper / n) * 100;
        double LOW = (lower / n) * 100;
        Console.WriteLine(Math.Round(UP, 2) + "% i " + Math.Round(LOW, 2) + "%");*/

        //-------------------------------------4-----------------------------//

        /*  Console.WriteLine("Введіть слова, щоб з них зробити абревіатуру: ");
          string s = Console.ReadLine();
          string abr = "";
          abr = Fourth(s);
          Console.Write("The Abbreviation : " + abr);*/



        //------------------------------------------------5-----------------------------//

        /*
        string res = "";
        bool Checked = false;
        do
        {
            string str = Console.ReadLine();
            if (str[str.Length - 1] == '.')
            {
                Checked = true;
                res += str; 
            }
            else
            {
                res += str + ", ";
            }
        } while (!Checked);
        Console.WriteLine(res);*/

        //-------------------------6-----------------------------//

        Console.WriteLine("Введіть слова");
        string s = Console.ReadLine();
        string[] trimS = s.Split('.');
        trimS[1] = trimS[1].Replace(" ", "");
        string res = "";
        for (int i = 0; i < trimS.Length; i++)
        {
            if(i != trimS.Length - 1)
                res += trimS[i] + ".";
            else 
                res += trimS[i];
        }
        Console.WriteLine(res);
    }
    /* public static string Fourth(string ss)
     {
         string abreva = "";
         int i = 0;
         abreva += ss[0];
         abreva += '.';

         for (i = 0; i < ss.Length - 1; i++)
         {
             if (ss[i] == ' ' || ss[i] == '\t' ||
                 ss[i] == '\n')
             {
                 abreva += ss[i + 1];
                 abreva += '.';
             }
         }
         return abreva;
     }*/
}