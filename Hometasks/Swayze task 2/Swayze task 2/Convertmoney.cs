using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swayze_task_2
{
    enum Wallet { USD = 1, EUR, PLN=3};
    internal class Convertmoney
    {
        public void Convert()
        {
            const double usd = 37.45;
            const double eur = 41.84;
            const double pln = 9.39;

            Console.Write("Enter money in UAH:");
            int value_money = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number wallet to convert:\n"
                + $"{(int)Wallet.USD} - USD\n"
                + $"{(int)Wallet.EUR} - EUR\n"
                + $"{(int)Wallet.PLN} - PLN.");

            Wallet select_wallet = (Wallet)Enum.Parse(typeof(Wallet), Console.ReadLine());

            switch (select_wallet)
            {
                case Wallet.USD:
                    Console.WriteLine($"Money after convert = {Math.Round(value_money / usd, 2)}");
                    break;
                case Wallet.EUR:
                    Console.WriteLine($"Money after convert = {Math.Round(value_money / eur,2)}");
                    break;
                case Wallet.PLN:
                    Console.WriteLine($"Money after convert = {Math.Round(value_money / pln,2)}");
                    break;
                default:
                    Console.WriteLine("Select number of menu.");
                    break;
            }
        }
    }
}
