using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15Events
{
    internal class Human
    {
        public Human(string name)
        {
            Name = name;
            Money = new Random().Next(1,1000);
            CompanyStocks = 0;
            PurchaseRate = 0;
        }

        public string Name { get; set; }
        public int Money { get; set; }
        public int CompanyStocks { get; set; }
        public int PurchaseRate { get; set; }

        public void Trading(int exchangeRate)
        {
            if (exchangeRate > this.PurchaseRate)
            {
                this.Money += this.CompanyStocks * exchangeRate;
                this.CompanyStocks = this.Money / exchangeRate;
                this.Money -= this.CompanyStocks * exchangeRate;
                this.PurchaseRate = exchangeRate;
                Console.WriteLine("Nice day");
            }
            else
            {
                Console.WriteLine("Another time");
            }
        }

        public override string ToString()
        {
            return $"Name {Name}, Money {Money}, CompanyStocks - {CompanyStocks}, PurchaseRate - {PurchaseRate}";
        }
    }
}
