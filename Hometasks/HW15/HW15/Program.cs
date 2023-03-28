namespace HW15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exchange = new Exchange();
            exchange.Rate = 1.2;

            var trader1 = new Trader("Trader1", 100);
            var trader2 = new Trader("Trader2", 50);

            trader1.RegisterForExchange(exchange);
            trader2.RegisterForExchange(exchange);

            trader1.Buy(exchange, 30);
            trader2.Buy(exchange, 20);
            trader1.Sell(exchange, 10);
            trader2.Sell(exchange, 15); 

            Console.ReadLine();

            exchange.SimulateRateChange(1.3, 1.1, 0.5);

            Console.ReadLine();
        }
    }
}