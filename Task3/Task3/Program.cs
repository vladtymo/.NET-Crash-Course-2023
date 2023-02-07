enum Day {Mon = 1, Tues, Wed, Thurs, Fri, Sat, Sun };
enum Money {USD = 1, EUR, PLN}
enum Search {R = 1, S, P}
internal class Program
{

   /* static void TaskOne()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("виберіть день тижня\n" + 
                           $"{(int)Day.Mon} - {Day.Mon}\n" +
                           $"{(int)Day.Tues} - {Day.Tues}\n" +
                           $"{(int)Day.Wed} - {Day.Wed}\n" +
                           $"{(int)Day.Thurs} - {Day.Thurs}\n" +
                           $"{(int)Day.Fri} - {Day.Fri}\n" +
                           $"{(int)Day.Sat} - {Day.Sat}\n" +
                           $"{(int)Day.Sun} - {Day.Sun}");

        //int direction = int.Parse(Console.ReadLine());
        Day day = Enum.Parse<Day>(Console.ReadLine());

        switch (day)
        {
            case Day.Mon: Console.WriteLine("it's Monday");break; // go out of the switch statement
            case Day.Tues: Console.WriteLine("it's Tuesday"); break;
            case Day.Wed: Console.WriteLine("it's Wednesday"); break;
            case Day.Thurs: Console.WriteLine("it's Thursday"); break;
            case Day.Fri: Console.WriteLine("it's Friday"); break;
            case Day.Sat: Console.WriteLine("it's Saturday"); break;
            case Day.Sun: Console.WriteLine("it's Sunday"); break;

            default: Console.WriteLine("Not a day!"); break;
        }
        }*/
   /* static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Yellow;
        double USDcourse = 36.75;
        double EURcourse = 40.11;
        double PLNcourse = 8.56;
        Console.WriteLine(
            $"{(int)Money.USD} - {Money.USD}\n" +
            $"{(int)Money.EUR} - {Money.EUR}\n"+
            $"{(int)Money.PLN} - {Money.PLN}\n");
        Console.WriteLine("Введіть кількість купюр");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введіть, на яку валюту будете міняти");
        Money money = Enum.Parse<Money>(Console.ReadLine());
        switch(money)
        {
            case Money.USD: Console.WriteLine("UAN to USD = " + Math.Round(a/USDcourse, 2)); break;
            case Money.EUR: Console.WriteLine("UAN to USD = " + Math.Round(a / EURcourse, 2)); break;
            case Money.PLN: Console.WriteLine("UAN to USD = " + Math.Round(a / PLNcourse, 2)); break;
                default : Console.WriteLine("Вибрана не та валюта"); break;
        }
        
    }*/
   
   /*  static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Введіть діаметр кола");
        double D = double.Parse(Console.ReadLine());
        Console.WriteLine("Виберіть операцію");
        Console.WriteLine(
            $"{(int)Search.R} - {Search.R}\n" +
            $"{(int)Search.S} - {Search.S}\n" +
            $"{(int)Search.P} - {Search.P}\n");
        Search search = Enum.Parse<Search>(Console.ReadLine());
        switch(search)
        {
            case Search.R: Console.WriteLine("радіус кола = " + D/2); break;
            case Search.S: Console.WriteLine("площа кола = " + Math.Round(Math.Pow((D / 2), 2) * Math.PI,2)); break;
            case Search.P: Console.WriteLine("периметр кола = " + Math.Round(D*Math.PI,2)); break;
            default: Console.WriteLine("Такої операції не існує"); break;
        }
    }*/

        static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Введіть число: ");
        string number = Console.ReadLine();
        bool check = true;

        for(int i = 0; i< number.Length / 2; i++)
        {
            if (number[i] != number[number.Length - i - 1])
            {
                check = false;
                break;
            }
        }
        if (check)
            Console.WriteLine("Число є паліндромом");
        else
            Console.WriteLine("Число не є паліндромом");
    }
}