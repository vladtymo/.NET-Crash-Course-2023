// 1
/*
Console.Write("Enter symbol: ");
char symbol = char.Parse(Console.ReadLine());

Console.Write("Enter length line: ");
int lengthLine = int.Parse(Console.ReadLine());

for (int i = 0; i < lengthLine; i++)
{
    Console.Write(symbol);
}
*/


// 2
/*
Random rand = new Random();
int randomNumber = rand.Next(0, 5);
int i = 0;
bool next = true;
int number;

do
{
    i++;
    Console.Write("Guess the number from 0 to 5: ");
    number = int.Parse(Console.ReadLine());
    if (number == randomNumber)
    {
        next = false;
    }
} while (next);

Console.Write($"Congratulations, you guessed it\nNumber of attempts: {i}");
*/

// 3
/*
Random rand = new Random();

int[] numbers = new int[20];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(0,100);
    Console.Write($"{numbers[i]}  ");
}
*/

// 4
/*
enum MenuFunc
{
    Sum = 1,
    Sort,
    Pair,
    MaxEl,
    Exit
};
class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] numbers = new int[20];
        bool exit = true;
        var pairs = numbers.GroupBy(i => i).Sum(g => g.Count() / 2);
        MenuFunc menuFunc;

        Console.WriteLine("Int array: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(0, 100);
            Console.Write($"{numbers[i]}  ");
        }
       
        while (exit)
        {
            Console.WriteLine("\nSelect a function: ");
            Console.WriteLine(MenuFunc.Sum + " = " + (int)MenuFunc.Sum);
            Console.WriteLine(MenuFunc.Sort + " = " + (int)MenuFunc.Sort);
            Console.WriteLine(MenuFunc.Pair + " = " + (int)MenuFunc.Pair);
            Console.WriteLine(MenuFunc.MaxEl + " = " + (int)MenuFunc.MaxEl);
            Console.WriteLine(MenuFunc.Exit + " = " + (int)MenuFunc.Exit);
            menuFunc = Enum.Parse<MenuFunc>(Console.ReadLine());
            switch (menuFunc)
            {
                case MenuFunc.Sum:
                    Console.WriteLine($"Sum = {numbers.Sum()}");
                    break;

                case MenuFunc.Sort:
                    Array.Sort(numbers);
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write($"{numbers[i]}  ");
                    }
                    break;

                case MenuFunc.Pair:
                    Console.WriteLine($"Pairs = {pairs}");
                    break;

                case MenuFunc.MaxEl:
                    Console.WriteLine($"MaxEl = {numbers.Max()}");
                    break;

                case MenuFunc.Exit:
                    exit = false;
                    break;
            }
        }
    }
}
*/