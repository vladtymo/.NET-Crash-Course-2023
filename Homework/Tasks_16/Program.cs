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
		public double _usdToEurRate = 0.85;
		
		public Exchange(double usdToEurRate)
		{
			_usdToEurRate = usdToEurRate;
		}

		public void ChangeRate(Func<double,double> rateChangeFunc) 
		{
			double oldPrice = _usdToEurRate;
		   _usdToEurRate = rateChangeFunc(_usdToEurRate);
			PriceChanged?.Invoke(this, new PriceChangedEventArgs(oldPrice, _usdToEurRate));
		}

		public event EventHandler<PriceChangedEventArgs> PriceChanged;

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
		public string Name { get; set; }
		public double currencyAmmount;

		public Customer(string Name,int currencyAmmount)
		{
			this.Name = Name;
			this.currencyAmmount = currencyAmmount;
		}
		public void BuyCurrency(double ammount) 
		{
			double oldAmmount = currencyAmmount;
			currencyAmmount += ammount;
			BalanceChanged?.Invoke(this, new BalanceChangedEventArgs(Name,oldAmmount, currencyAmmount));
		}
        public void SoldCurrency(double ammount) 
		{
			if (currencyAmmount - ammount < 0)
			{
				Console.WriteLine($"{Name} don`t have so currency");
			}
			else
			{
				double oldAmmount = currencyAmmount;
				currencyAmmount -= ammount;
				BalanceChanged?.Invoke(this, new BalanceChangedEventArgs(this.Name,oldAmmount, currencyAmmount));
			}
		}
		public event EventHandler<BalanceChangedEventArgs> BalanceChanged;
	}
	public class Program
	{
		private static void Stock_PriceChanged(object sender, PriceChangedEventArgs e)
		{
			Console.WriteLine($"Price changed from {e.OldPrice} to {e.NewPrice} at {e.ChangeTime:T}");
		}
		private static void Balance_Changed(object sender, BalanceChangedEventArgs e) 
		{
			Console.WriteLine($"{e.Name} make some changed in his balance was - {e.OldBalance}, new - {e.NewBalance}, Time - {e.ChangeTime:T}");
		}
		static void Main(string[] args)
		{
			Exchange exchange = new Exchange(1.0);
			exchange.PriceChanged += Stock_PriceChanged;
			Customer customer = new Customer("OLeg",1000);
			customer.BalanceChanged += Balance_Changed;

			customer.BuyCurrency(100);
			Console.WriteLine($"Curr - {exchange._usdToEurRate}");
			exchange.ChangeRate(rate => rate * 1.05);
			customer.SoldCurrency(500);
			Console.WriteLine($"Curr - {exchange._usdToEurRate}");
			Console.ReadKey();
		}
	}
}