using System;

namespace CurrencyConverter{
    class Program{
        enum Currency{
            USD = 1,
            EUR,
            UAN,
            PLN
        }
        static void Main(string[] args){
            Console.WriteLine("Enter the number of UAN:");
            double uan = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select the target currency: ");
            Console.WriteLine("1. USD");
            Console.WriteLine("2. EUR");
            Console.WriteLine("3. UAN");
            Console.WriteLine("4. PLN");
            int choice = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            Currency targetCurrency = (Currency)choice;
            switch (targetCurrency){
                case Currency.USD:
                    result = uan / 36.74;
                    Console.WriteLine($"{uan} UAN is equal to {result} USD");
                    break;
                case Currency.EUR:
                    result = uan / 39.28;
                    Console.WriteLine($"{uan} UAN is equal to {result} EUR");
                    break;
                case Currency.UAN:
                    Console.WriteLine($"{uan} UAN is equal to {uan} UAN");
                    break;
                case Currency.PLN:
                    result = uan / 8.26;
                    Console.WriteLine($"{uan} UAN is equal to {result} PLN");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}

