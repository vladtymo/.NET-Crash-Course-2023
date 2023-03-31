namespace Tasks_16
{
	public class PriceChangedEventArgs : EventArgs
	{
		public double OldPrice { get; }
		public double NewPrice { get; }
		public DateTime ChangeTime { get; }
		public PriceChangedEventArgs(double oldPrice, double newPrice)
		{
			OldPrice = oldPrice;
			NewPrice = newPrice;
			ChangeTime = DateTime.Now;
		}
	}
	public class Exchange
	{
		//public double _usdToEurRate = 0.85;
		public Coin Coin { get; set; }
		public Exchange(Coin coin)
		{
			//_usdToEurRate = usdToEurRate;
			Coin = coin;
		}

		public void ChangeRate(Func<double,double> rateChangeFunc) 
		{
			double oldPrice = Coin.ValueUsd;//_usdToEurRate;
			Coin.ValueUsd = rateChangeFunc(Coin.ValueUsd);//_usdToEurRate);
			PriceChanged?.Invoke(this, new PriceChangedEventArgs(oldPrice, Coin.ValueUsd));
		}

		public event EventHandler<PriceChangedEventArgs> PriceChanged;
	}
	public class Coin
	{
		public string Name { get; set; }
		public double ValueUsd { get; set; }

		public Coin(string name, double valueUsd)
		{
			Name = name;
			ValueUsd = valueUsd;
		}

	}
	public class BalanceChangedEventArgs : EventArgs 
	{
		public string Name { get; }
	    public double OldBalance { get; }
		public double NewBalance { get; }
		public DateTime ChangeTime { get; }
		public BalanceChangedEventArgs(string name,double oldBalance, double newBalance)
		{
			Name = name;
			OldBalance = oldBalance;
			NewBalance = newBalance;
			ChangeTime = DateTime.Now;
		}
	}
	public class Customer
	{
		private double _balance;
		public string Name { get; set; }
		public List<Coin> CurrencyAmount { get; set; }
		public double Balance
		{ 
			get => _balance;
			set
			{
				double oldBalance = _balance;
				_balance = value;
				BalanceChanged?.Invoke(this, new BalanceChangedEventArgs(Name, oldBalance,_balance));
			}
		}
		public Customer(string Name,List<Coin> coins)
		{
			this.Name = Name;
			CurrencyAmount = coins;
		}
		public void BuyCurrency(List<Coin> coins) 
		{
			CurrencyAmount.AddRange(coins);
			Balance += CalculateTotalCost(coins);
		}
		public void SoldCurrency(List<Coin> coins)
		{
			double totalCost = CalculateTotalCost(coins);
			if (Balance - totalCost >= 0)
			{
				foreach (Coin coin in coins)
				{
					CurrencyAmount.Remove(coin);
				}
				Balance -= totalCost;
			}
			else
			{
				Console.WriteLine($"{Name} don't have enough currency");
			}
		}
		private double CalculateTotalCost(List<Coin> coins)
		{
			double totalCost = 0;
			foreach (Coin coin in coins)
			{
				totalCost += coin.ValueUsd;
			}
			return totalCost;
		}

		private double CalculateBalance()
		{
			double totalCost = 0;
			foreach (Coin coin in CurrencyAmount)
			{
				totalCost += coin.ValueUsd;
			}
			return totalCost;
		}
		public event EventHandler<BalanceChangedEventArgs> BalanceChanged;
	}
	public class Program
	{
		private static Exchange exchange = new Exchange(new Coin("Bitcoin", 27321));
		private static Customer customer = new Customer("OLeg", new List<Coin>());
		private static List<Coin> Coins1= new List<Coin>();
		private static List<Coin> Coins2 = new List<Coin>();
		private static void Stock_PriceChanged(object sender, PriceChangedEventArgs e)
		{
			Console.WriteLine($"Price changed from {e.OldPrice} to {e.NewPrice} at {e.ChangeTime:T}");
			foreach (Coin coin in customer.CurrencyAmount)
			{
				if (coin.Name == exchange.Coin.Name)
				{
					double oldCoinValue = coin.ValueUsd;
					coin.ValueUsd = e.NewPrice;
					double newCoinValue = coin.ValueUsd;

					double oldBalance = customer.Balance;
					double newBalance = oldBalance - oldCoinValue + newCoinValue;
					customer.Balance = newBalance;
					break;
				}
			}
		}
		private static void Balance_Changed(object sender, BalanceChangedEventArgs e) 
		{
			if (e.OldBalance <= e.NewBalance)
			{
				Console.ForegroundColor = ConsoleColor.Green;
			}
			else Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"{e.Name} make some changed in his balance was - {e.OldBalance}, new - {e.NewBalance}, Time - {e.ChangeTime:T}");
			Console.ForegroundColor = ConsoleColor.White;
		}
		static void Main(string[] args)
		{
			exchange.PriceChanged += Stock_PriceChanged;
			customer.BalanceChanged += Balance_Changed;
			for(int i= 0; i < 2;i++)
			{
				Coins1.Add(new Coin("Bitcoin", 27321));
			}
			for (int i = 0; i < 2; i++)
			{
				Coins2.Add(new Coin("Bitcoin", 27321));
			}
			customer.BuyCurrency(Coins1);
			customer.BuyCurrency(Coins2);
			exchange.ChangeRate(rate => rate * 1.05);
			customer.SoldCurrency(Coins2);
			Console.ReadKey();
		}
	}
}