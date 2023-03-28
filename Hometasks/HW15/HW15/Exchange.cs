using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    public delegate void CurrencyRateChangedEventHandler(object sender, CurrencyRateChangedEventArgs args);

    public class CurrencyRateChangedEventArgs : EventArgs
    {
        public double OldRate { get; set; }
        public double NewRate { get; set; }
    }

    internal class Exchange
    {
        private double _rate;
        public event CurrencyRateChangedEventHandler CurrencyRateChanged;
        public event EventHandler MaxRateReached;
        public event EventHandler MinRateReached;

        public double Rate
        {
            get { return _rate; }
            set
            {
                if (value > _rate)
                {
                    MaxRateReached?.Invoke(this, EventArgs.Empty);
                }
                else if (value < _rate)
                {
                    MinRateReached?.Invoke(this, EventArgs.Empty);
                }

                var oldRate = _rate;
                _rate = value;

                CurrencyRateChanged?.Invoke(this, new CurrencyRateChangedEventArgs
                {
                    OldRate = oldRate,
                    NewRate = _rate
                });
            }
        }

        public void SimulateRateChange(double maxRate, double minRate, double rateChange)
        {
            var random = new Random();
            while (true)
            {
                var oldRate = Rate;
                var rateChangePercentage = rateChange / 100;
                var rateChangeAmount = oldRate * rateChangePercentage;
                var newRate = oldRate + (random.NextDouble() > 0.5 ? 1 : -1) * rateChangeAmount;

                if (newRate >= maxRate)
                {
                    Rate = maxRate;
                    break;
                }
                else if (newRate <= minRate)
                {
                    Rate = minRate;
                    break;
                }

                Rate = newRate;
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
