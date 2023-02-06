
enum Currency { USD = 1, EUR, PLN };
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter amount of UAH: ");
        double UAH = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose a currency:\n" +
                            $"{(int)Currency.USD} - {Currency.USD}\n" +
                            $"{(int)Currency.EUR} - {Currency.EUR}\n" +
                            $"{(int)Currency.PLN} - {Currency.PLN}");

        Currency cur = Enum.Parse<Currency>(Console.ReadLine());

        switch (cur)
        {
            case Currency.USD:
                Console.WriteLine($"From {UAH}UAH, you take {UAH/36.75}USD"); break;
            case Currency.EUR:
                Console.WriteLine($"From {UAH}UAH, you take {UAH / 40.24}EUR"); break;
            case Currency.PLN:
                Console.WriteLine($"From {UAH}UAH, you take {UAH / 8.59}PLN"); break;

            default: Console.WriteLine("Invalid currency!"); break;
        }

        Console.WriteLine("Goodbye!");

    }
}