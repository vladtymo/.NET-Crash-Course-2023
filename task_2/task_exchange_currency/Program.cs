enum Ccurency { USD = 1, EUR, PLN }
internal class Program
{
    private static void Main(string[] args)
    {
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
                break;
            case Ccurency.EUR:
                break;
            case Ccurency.PLN:
                break;
            default:
                break;
        }
    }
}
