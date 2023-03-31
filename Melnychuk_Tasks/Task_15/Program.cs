using System;
using System.Collections.Generic;

namespace Task_15
{
    class Program
    {
        class Exange
        {
            private double exangeRate;
            private double minRate;
            private double maxRate;

            public List<Trader> Traders { get; private set; }

            public void RegisterTrader(Trader trader)
            {
                Traders.Add(trader);
            }
            public Exange(double exangeRate, double minRate, double maxRate)
            {
                this.exangeRate = exangeRate;
                this.minRate = minRate;
                this.maxRate = maxRate;
                this.Traders = new List<Trader>();

            }

            public event EventHandler<ExchangeRateEventArgs> MinRateReached;
            public event EventHandler<ExchangeRateEventArgs> MaxRateReached;

            public void SimulateRateChange(double delta)
            {
                this.exangeRate += delta;

                if (this.exangeRate <= this.minRate) OnMinRateReached(new ExchangeRateEventArgs(this.exangeRate));
                else if (this.exangeRate >= this.maxRate) OnMaxRateReached(new ExchangeRateEventArgs(this.exangeRate));
            }

            protected virtual void OnMinRateReached(ExchangeRateEventArgs e)
            {
                MinRateReached?.Invoke(this, e);
            }

            protected virtual void OnMaxRateReached(ExchangeRateEventArgs e)
            {
                MaxRateReached?.Invoke(this, e);
            }

        }
        class ExchangeRateEventArgs : EventArgs
        {
            public double ExchangeRate { get; private set; }

            public ExchangeRateEventArgs(double exchangeRate)
            {
                this.ExchangeRate = exchangeRate;
            }
        }
        class Trader
        {
            private double currencyAmount;
            private double desiredRate;
            private Exange exange;

            public Trader(double currencyAmount, double desiredRate, Exange exange)
            {
                this.currencyAmount = currencyAmount;
                this.desiredRate = desiredRate;
                this.exange = exange;
                this.exange.MinRateReached += OnMinRateReached;
                this.exange.MaxRateReached += OnMaxRateReached;
            }

            private void OnMinRateReached(object sender, ExchangeRateEventArgs e)
            {
                if (e.ExchangeRate <= desiredRate)
                {
                    double amount = currencyAmount / e.ExchangeRate;
                    Buy(amount, e.ExchangeRate);
                }
            }

            private void OnMaxRateReached(object sender, ExchangeRateEventArgs e)
            {
                if (e.ExchangeRate >= desiredRate)
                {
                    Sell(currencyAmount, e.ExchangeRate);
                }
            }

            public void Buy(double amount, double rate)
            {
                if (rate <= desiredRate && amount * rate <= currencyAmount)
                {
                    currencyAmount -= amount * rate;
                }
            }

            public void Sell(double amount, double rate)
            {
                if (rate >= desiredRate && amount <= currencyAmount)
                {
                    currencyAmount += amount * rate;
                }
            }

            public double Show()
            {
                return currencyAmount;
            }
        }

        static void Main(string[] args)
        {
            Exange exange = new Exange(10, 5, 20);

            Trader trader1 = new Trader(100, 90, exange);
            Trader trader2 = new Trader(50, 12, exange);
            Trader trader3 = new Trader(200, 15, exange);

            exange.RegisterTrader(trader1);
            exange.RegisterTrader(trader2);
            exange.RegisterTrader(trader3);

            Console.WriteLine($"{trader1.Show()}");
            Console.WriteLine($"{trader2.Show()}");
            Console.WriteLine($"{trader3.Show()}");

            exange.SimulateRateChange(-3);
            exange.SimulateRateChange(6);
            exange.SimulateRateChange(10);

            Console.WriteLine($"{trader1.Show()}");
            Console.WriteLine($"{trader2.Show()}");
            Console.WriteLine($"{trader3.Show()}");
        }
    }
}