using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Events
{
    internal class Trader
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public double CompanyStocks { get; set; }
        public double PurchaseRate { get; set; }
        public double SellingRate { get; set; }
        public Trader(string name, double money)
        {
            Name = name;
            Money= money;
            CompanyStocks = 0;
            PurchaseRate = 0;
            SellingRate = new Random().NextDouble();
        }
        public void Purchase(double tradeRate )
        {
            if (PurchaseRate == 0)
            { 
                CompanyStocks = Money / tradeRate;
                Money -= CompanyStocks * tradeRate;
                PurchaseRate = tradeRate;
                Console.WriteLine("The purchase of the first share was successful!");
            }
            else if (tradeRate<PurchaseRate) 
            {
                Money += CompanyStocks * SellingRate;
                CompanyStocks = Money / tradeRate;
                Money -= CompanyStocks * tradeRate;
                PurchaseRate = tradeRate;
                Console.WriteLine("The share purchase was successful!");
            }
            else { Console.WriteLine($"Trader {Name} refrained from buying shares"); }
        }
        public void Selling(double salesRate)
        {
            if (salesRate > SellingRate)
            {
                Money += CompanyStocks * SellingRate;
                CompanyStocks =0;
                SellingRate = salesRate;
                Console.WriteLine("The share purchase was successful!");
            }
            else { Console.WriteLine($"Trader {Name} refrained from selling the shares"); }
        }
        public override string ToString()
        {
            return $"--------------------------\nTrader {Name}:\nMoney = {Money} \n CompanyStocks = {CompanyStocks} \n Last Purchase Rate ={PurchaseRate} \nLast Selling Rate ={SellingRate}";
        }
    }
}
