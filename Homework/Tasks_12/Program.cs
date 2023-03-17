namespace Tasks_12
{
	public abstract class CombatVehicle
	{
		public string Type { get; set; }
		public string Model { get; set; }
		public double Health { get; set; }

		public bool isDestroyed()
		{
			if(Health <= 0)
			{
				return true;
			}
			return false;
		}
		public void ShowInfo()
		{
			Console.WriteLine(
				$"Type - {Type}\n" +
				$"Model - {Model}\n" +
				$"Health - {Health}\n");
		}
		public abstract double Attack();
		public abstract void Defense(double damage);
	}

	public class Tank : CombatVehicle
	{
		public double ReloadingTime { get; set; }
		public double FireAccuracy { get; set; }
		public double ArmorThickness { get; set; }

		public override double Attack() => (100 * FireAccuracy / ReloadingTime);

		public override void Defense(double damage)
		{
			if (isDestroyed == null)
			{
				Console.WriteLine("Already destroyed");
			}
			else
			Health -= damage - ArmorThickness;
		}

		public new void ShowInfo()
		{
			base.ShowInfo();
			Console.WriteLine();
		}
	}

	//public class ArmoredCar : CombatVehicle
	//{

	//}

	//public class AirDefenseVehicle : CombatVehicle
	//{

	//}

	public class Program
	{
		static void Main(string[] args)
		{
			
		}
	}
}