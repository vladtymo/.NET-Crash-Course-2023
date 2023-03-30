using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Events
{
    internal class Exchange
    {
        public double ExchangeSellingRate { get; set; }
        public double ExchangePurchaseRate { get; set; }
        public event Action<double> UpdatePurchaseRate;
        public event Action<double> UpdateSellingRate;
        private double minPurchaseRate=0.24;
        private double minSellingRate = 0.1;
        public event Action<double> MinPurchaseReached;
        public event Action<double> MinSellingReached;
        private double maxPurchaseRate = 1.2;
        private double maxSellingRate = 1.14;
        public event Action<double> MaxPurchaseReached;
        public event Action<double> MaxSellingReached;

        public Exchange() 
        {
            ExchangeSellingRate = new Random().NextDouble();
            ExchangePurchaseRate = new Random().NextDouble();
        }
        
        public void Update()
        {
            UpdatePurchaseRate?.Invoke(ExchangePurchaseRate);
            UpdateSellingRate?.Invoke(ExchangeSellingRate);
        }
        public void UpdateRatePurchase(double newRate)
        {
            if(newRate!=ExchangePurchaseRate)
            {
                ExchangePurchaseRate = newRate;
                if(ExchangePurchaseRate>maxPurchaseRate)
                {
                    maxPurchaseRate = ExchangePurchaseRate;
                    MaxPurchaseReached?.Invoke(maxPurchaseRate);
                }
                if (ExchangePurchaseRate < minPurchaseRate)
                {
                    minPurchaseRate = ExchangePurchaseRate;
                    MinPurchaseReached?.Invoke(minPurchaseRate);
                }
                Console.WriteLine($"\t New Purchase Rate: {ExchangePurchaseRate}");
            }
            UpdatePurchaseRate?.Invoke(ExchangePurchaseRate);
        }
        public void UpdateRateSelling(double newRate)
        {
            if (newRate != ExchangeSellingRate)
            {
                ExchangeSellingRate = newRate;
                if (ExchangeSellingRate > maxSellingRate)
                {
                    maxSellingRate = ExchangeSellingRate;
                    MaxSellingReached?.Invoke(maxSellingRate);
                }
                if (ExchangeSellingRate < minSellingRate)
                {
                    minSellingRate = ExchangeSellingRate;
                    MinSellingReached?.Invoke(minSellingRate);
                }
                Console.WriteLine($"\t New Selling Rate: {ExchangeSellingRate}");
            }
            UpdateSellingRate?.Invoke(ExchangeSellingRate);
        }
    }
}
