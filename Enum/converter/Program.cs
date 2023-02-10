enum Currency { USD = 1, EUR = 2, PLN = 3 }
internal class Program
{
    private static void Main(string[] args)
    {
        const float USD = 37.28F;
        const float EUR = 40.35F;
        const float PLN = 8.53F;


        Console.WriteLine("Enter sum money: ");
        int sumMoney = int.Parse(Console.ReadLine());

        Console.WriteLine("Select currency:\n" +
                            $"{(int)Currency.USD} - {Currency.USD}\n" +
                            $"{(int)Currency.EUR} - {Currency.EUR}\n" +
                            $"{(int)Currency.PLN} - {Currency.PLN}\n");

        Currency exchange = Enum.Parse<Currency>(Console.ReadLine());


        switch (exchange)
        {
            case Currency.USD:
                Console.WriteLine($"It comes out = {sumMoney * USD}");
                break;
            case Currency.EUR:
                Console.WriteLine($"It comes out = {sumMoney * EUR}");
                break;
            case Currency.PLN:
                Console.WriteLine($"It comes out = {sumMoney * PLN}");
                break;

            default:
                Console.WriteLine("Invalid curency!");
                break;
        }
    }
}