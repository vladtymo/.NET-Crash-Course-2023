namespace _15_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exchange exchange = new();
            Trader trader1 = new("Olena",1000.0);
            Trader trader2 = new("Petro",12345.0);

            trader1.Purchase(0.1);
            trader2.Purchase(0.25);

            List<Trader> list = new List<Trader>() { trader1, trader2 };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            exchange.UpdatePurchaseRate += trader2.Purchase;
            exchange.UpdateSellingRate += trader1.Selling;
            exchange.UpdatePurchaseRate += trader2.Purchase;
            //exchange.UpdateSellingRate += trader2.Selling; 
            exchange.Update();
            Console.WriteLine(new String('#', 20));

            exchange.MinPurchaseReached += minPurchaseRate => Console.WriteLine($"Min Purchase Rate : {minPurchaseRate}");
            exchange.MaxPurchaseReached += maxPurchaseRate => Console.WriteLine($"Max Purchase Rate : {maxPurchaseRate}");

            double newRate =10*new Random().NextDouble();
            exchange.UpdateRatePurchase(newRate);

            Console.WriteLine(new String('#', 20));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


        }
    }
}