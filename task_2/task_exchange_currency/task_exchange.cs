enum Ccurency { USD = 1, EUR, PLN }
internal class task_exchange
{
    private static void Main(string[] args)
    {
        const float USD = 37.28F;
        const float EUR = 40.35F;
        const float PLN = 8.53F;
        Console.Write("Enter sum money: ");
        int sumMoney =int.Parse( Console.ReadLine());
        Console.WriteLine("Choose ccurency:\n" +
                            $"{(int)Ccurency.USD} - {Ccurency.USD}\n" +
                            $"{(int)Ccurency.EUR} - {Ccurency.EUR}\n" +
                            $"{(int)Ccurency.PLN} - {Ccurency.PLN}\n");

        Ccurency exchange = Enum.Parse<Ccurency>(Console.ReadLine());
        switch (exchange)
        {
            case Ccurency.USD:
                Console.WriteLine($"Result: {sumMoney*USD}");
                break;
            case Ccurency.EUR:
                Console.WriteLine($"Result: {sumMoney * EUR}");
                break;
            case Ccurency.PLN:
                Console.WriteLine($"Result: {sumMoney * PLN}");
                break;
            default:
                Console.WriteLine("Invalid ccurency");
                break;
        }
    }
}
