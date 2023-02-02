
internal class Program
{
    private static void Main(string[] args)
    {
        //------завдання 1------//
        /*
        Console.Write("Введіть поточний рік: ");
        string year = Console.ReadLine();
        Console.Write("Місяць: ");
        string month = Console.ReadLine();
        Console.Write("День: ");
        string day = Console.ReadLine();
        Console.WriteLine($"Поточна дата: {day}/{month}/{year}");
        */

        //------завдання 2------//
        /*
        Console.Write("a: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"Периметр прямокутника: {a * 2 + b * 2}");
        Console.WriteLine($"Площа прямокутника: {a * b}");
        */

        //------завдання 3------//
        /*
        Console.Write("r: ");
        int r = Int32.Parse(Console.ReadLine());
        Console.WriteLine("S = " + Math.Round(Math.Pow(r,2) * Math.PI , 2));
        */

        //------завдання 4------//
        /*
        int s = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"Час: {s / 3600}/{(s % 3600) / 60}/{s % 60}");
        */

        //------завдання 5------//
        /*
        Console.Write("Введіть рік: ");
        int year = Int32.Parse(Console.ReadLine());
        Console.Write("Кількість днів у році: ");
        if(year % 4 == 0)
        {
            Console.WriteLine(365);
        }
        else
        {
            Console.WriteLine(364);
        }
        */
    }
}