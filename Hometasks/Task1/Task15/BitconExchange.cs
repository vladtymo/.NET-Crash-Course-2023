using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Task15
{
    public class BitconExchange
    {
        delegate void HasMinimumPrice(Bitcoin bitcoin);
        delegate Bitcoin HasMaximumPrice();
        event HasMinimumPrice hasMinimumPrice;
        event HasMaximumPrice hasMaximumPrice;

        public BitconExchange(params Bitcoin[] bitcoins)
        {
            SellQueue = new Queue<Trader>();
            BuyQueue = new Queue<Trader>();

            Bitcoins = new List<Bitcoin>();
            foreach (Bitcoin bitcoin in bitcoins)
            {
                Bitcoins.Add(bitcoin);
            }
        }

        private List<Bitcoin> Bitcoins { get; set; }
        
        public Queue<Trader> SellQueue { get; }
        public Queue<Trader> BuyQueue { get; }

        public void Buy(Bitcoin coin)
        {
            Bitcoins.Add(coin);
            if (CheckCoinPrice(coin))
            {
                Bitcoins.Remove(coin);
            }
        }

        public Bitcoin Sell(Bitcoin coin)
        {
            var buyed = Bitcoins.Last();
            Bitcoins.Remove(buyed);
            
            while (Bitcoins.Count > 0)
            {
                if (CheckCoinPrice(Bitcoins.Last()))
                {
                    Bitcoins.Remove(Bitcoins.Last());
                }
            }

            return buyed;
        }

        public bool CheckCoinPrice(Bitcoin bitcoin)
        {
            double min = Bitcoins.Min(coin => coin.Price);
            if (bitcoin.Price <= min)
            {
                if (!BuyQueue.TryDequeue(out Trader buyer))
                {
                    return false;
                }

                hasMinimumPrice += buyer.Buy;
                hasMinimumPrice.Invoke(bitcoin);
                hasMinimumPrice -= buyer.Buy;

                return true;
            }

            double max = Bitcoins.Max(coin => coin.Price);
            if (bitcoin.Price >= max)
            {
                if (!SellQueue.TryDequeue(out Trader seller))
                {
                    return false;
                }

                hasMaximumPrice += seller.Sell;
                hasMaximumPrice.Invoke();
                hasMaximumPrice -= seller.Sell;

                return true;
            }

            return false;
        }

        public void SubscribeToSell(Trader trader)
        {
            SellQueue.Enqueue(trader);
        }

        public void SubscribeToBuy(Trader trader)
        {
            BuyQueue.Enqueue(trader);
        }

        public void PrintRate()
        {
            Console.Clear();

            int windowBottomPosition = Console.WindowHeight;
            int windowRightPosition = Console.WindowWidth;

            // Print left border
            for (int i = 0; i < windowBottomPosition; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('*');
            }

            // Print bottom border
            for (int i = 0; i < windowRightPosition; i++)
            {
                Console.SetCursorPosition(i, windowBottomPosition - 1);
                Console.Write("*");
            }

            // Take last coins
            List<Bitcoin> lastExchanges = Bitcoins
                .TakeLast(windowRightPosition - 1)
                .ToList();

            // Find max and min price border
            double maxPrice = lastExchanges.Max(coin => coin.Price);
            double minPrice = lastExchanges.Min(coin => coin.Price);

            // Print price borders
            Console.SetCursorPosition(0, 0);
            Console.Write(maxPrice);
            Console.SetCursorPosition(0, windowBottomPosition - 1);
            Console.Write(minPrice);

            // Print chart
            double onePercent = maxPrice - minPrice;
            for(int i = 1; i < lastExchanges.Count; i++)
            {
                int top = (int)(((lastExchanges[i].Price - minPrice) / onePercent) * (windowBottomPosition - 1));
                Console.SetCursorPosition(i, top);
                Console.Write('@');
            }
        }
    }
}