using System;

namespace Homework13
{
    public class ExchangeRate
    {
        public Action<double> RateChanged;
        public event Action<double> MaxRateReached;
        public event Action<double> MinRateReached;
        private double rate;
        private double maxRate = 1.4;
        private double minRate = 0.6;

        public ExchangeRate()
        {
            rate = 1.0;
        }

        public void UpdateRate(double newRate)
        {
            if (newRate != rate)
            {
                rate = newRate;

                if (rate > maxRate)
                {
                    maxRate = rate;
                    MaxRateReached?.Invoke(maxRate);
                }

                if (rate < minRate)
                {
                    minRate = rate;
                    MinRateReached?.Invoke(minRate);
                }

                Console.WriteLine($"\t New rate: {newRate}");
                RateChanged?.Invoke(rate);
            }
        }
        public void Run()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                double newRate = 0.5 + random.NextDouble();
                UpdateRate(newRate);
            }
        }
    }

    public class Trader
    {
        public double Currency { get; set; }

        public Trader()
        {
            Currency = 1000.0;
        }

        public void ChangeExchangeRate(double rate)
        {
            if (rate > 1.0)
            {
                double amountToBuy = Currency / rate;
                Currency -= amountToBuy;
                Console.WriteLine($"Buy: {amountToBuy} \t Rate: {rate}");
            }
            else if (rate < 1.0)
            {
                double amountToSell = Currency * rate;
                Currency -= amountToSell;
                Console.WriteLine($"Sell: {amountToSell} \t Rate: {rate}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExchangeRate exchangeRate = new ExchangeRate();
            Trader trader = new Trader();

            exchangeRate.RateChanged += trader.ChangeExchangeRate;
            exchangeRate.MaxRateReached += rate => Console.WriteLine($"Max rate: {rate}");
            exchangeRate.MinRateReached += rate => Console.WriteLine($"Min rate: {rate}");

            exchangeRate.Run();




            Console.ReadLine();
        }
    }
}