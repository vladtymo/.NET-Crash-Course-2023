namespace Task15
{
    public class Trader
    {
        private static long _id;

        static Trader()
        {
            _id = 0;
        }

        public Trader(params Bitcoin[] bitcoins)
        {
            Id = _id++;
            Bitcoins = bitcoins.ToList();
        }
        
        public long Id { get; }
        public List<Bitcoin> Bitcoins { get; }

        public Bitcoin Sell()
        {
            Bitcoin bitcoin = Bitcoins.Last();
            Bitcoins.Remove(bitcoin);

            Console.WriteLine($"Trader[{Id}] selled Bitcoin[{bitcoin.Id}]");

            return bitcoin;
        }

        public void Buy(Bitcoin coin)
        {
            Bitcoins.Add(coin);
            Console.WriteLine($"Trader[{Id}] buyed Bitcoin[{coin.Id}]");
        }
    }
}