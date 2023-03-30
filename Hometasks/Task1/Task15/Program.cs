namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bitcoin[] bitcoins = new Bitcoin[100];
            for (int i = 0; i < bitcoins.Length; i++)
            {
                bitcoins[i] = new Bitcoin()
                {
                    Price = new Random().Next(5000, 15000)
                };
            }
            BitconExchange exchange = new BitconExchange(bitcoins);

            Trader trader1 = new Trader();
            Trader trader2 = new Trader();
            Trader trader3 = new Trader();

            exchange.SubscribeToBuy(trader1);
            exchange.SubscribeToBuy(trader2);
            exchange.SubscribeToBuy(trader3);

            for (int i = 0; i < 100; i++)
            {
                exchange.Buy(new Bitcoin()
                {
                    Price = new Random().Next(5000, 10000),
                });
            }
        }
    }
}