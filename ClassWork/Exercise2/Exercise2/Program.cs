using System;


namespace Exercise2
{

    public enum Currency { UAH, USD, EUR }
    class BantAccount
    {
        public static decimal UsdUAH = 40.4m;
        public static decimal EurUAH = 42.8m;

        public decimal UAH = 0;
        public decimal USD = 0;
        public decimal EUR = 0;

        public string Name;

        public void ConvertMany(Currency mainvalyta, Currency najakyminajemo, decimal amount)
        {
            if (mainvalyta == najakyminajemo)
                return;
            decimal amountUAH;
            switch (mainvalyta)
            {
                case Currency.UAH:
                    {
                        if (UAH < amount)
                            throw new ArgumentException("Немає стільки грошей на гривнему рахунку!");
                        else
                        {
                            amountUAH = amount;
                            UAH -= amount;
                        }
                    }
                    break;
                case Currency.USD:
                    {
                        if (USD < amount)
                            throw new ArgumentException("Немає стільки грошей на доларовому рахунку!");
                        else
                        {
                            amountUAH = amount * UsdUAH;
                            USD -= amount;
                        }
                    }
                    break;
                case Currency.EUR:
                    {
                        if (EUR < amount)
                            throw new ArgumentException("Немає стільки грошей на евро рахунку!");
                        else
                        {
                            amountUAH = amount * EurUAH;
                            EUR -= amount;
                        }
                    }
                    break;
                default:
                    throw new ArgumentException("Рахунку в цій валюті немає!");

            }

            switch (najakyminajemo)
            {
                case Currency.UAH: UAH += amountUAH; break;
                case Currency.USD: USD += amountUAH / UsdUAH; break;
                case Currency.EUR: EUR += amountUAH / EurUAH; break;
            }



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /// Відкриваємо рахунок 
            BantAccount account = new BantAccount() { Name = "Galushkin", UAH = 5000, USD = 0 };
            /// Обмін грн на долари
            account.ConvertMany(Currency.UAH, Currency.USD, 1000);
            account.ConvertMany(Currency.UAH, Currency.EUR, 1500);
            /// Наявний рахунок
            Console.WriteLine($"{account.Name}: " +
                $"{Currency.UAH}={account.UAH}, " +
                $"{Currency.USD}={account.USD}, " +
                $"{Currency.EUR}={account.EUR}");
        }
    }
}
