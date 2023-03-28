using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    internal class Trader
    {
        public string Name { get; set; }
        public double Currency { get; set; }

        public Trader(string name, double currency)
        {
            Name = name;
            Currency = currency;
        }

        public void Buy(Exchange exchange, double amount)
        {
            var rate = exchange.Rate;
            var cost = rate * amount;
            if (cost > Currency)
            {
                Console.WriteLine($"{Name} does not have enough currency to buy {amount} at the current rate of {rate}");
                return;
            }

            Currency -= cost;
            Console.WriteLine($"{Name} bought {amount} at the rate of {rate}. Remaining currency: {Currency}");
        }

        public void Sell(Exchange exchange, double amount)
        {
            var rate = exchange.Rate;
            var sale = rate * amount;
            Currency += sale;
            Console.WriteLine($"{Name} sold {amount} at the rate of {rate}. Currency balance: {Currency}");
        }

        public void RegisterForExchange(Exchange exchange)
        {
            exchange.CurrencyRateChanged += OnCurrencyRateChanged;
        }

        private void OnCurrencyRateChanged(object sender, CurrencyRateChangedEventArgs args)
        {
            Console.WriteLine($"{Name}: Rate changed from {args.OldRate} to {args.NewRate}");
        }
    }
}
