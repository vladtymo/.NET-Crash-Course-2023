using System.Reflection.Metadata.Ecma335;

namespace Tasks_12
{
	public abstract class CombatVehicle
	{
		public string VehicleType { get; set; }
		public string VehicleModel { get; set; }
		public double HealthPoints { get; set; }

		public CombatVehicle(string Type,string Model,double Health)
		{
			this.VehicleType = Type;
			this.VehicleModel = Model;
			this.HealthPoints = Health;
		}

		public bool isDestroyed()
		{
			return HealthPoints < 1;
		}

		public void ShowInfo()
		{
			Console.WriteLine(
				$"Type - {VehicleType}\n" +
				$"Model - {VehicleModel}\n" +
				$"Health - {HealthPoints}\n" +
				$"Is destroyed - {isDestroyed()}");
		}
		public abstract double Attack();
		public abstract void Defense(double damage);
	}

	public class Tank : CombatVehicle
	{
		public double ReloadingTime { get; set; }
		public double FireAccuracy { get; set; }
		public double ArmorThickness { get; set; }
		public Tank(string Type, string Model, double Health,double ReloadingTime,double FireAccuracy,double ArmorThickness)
			:base(Type,Model,Health)
		{
		    this.ReloadingTime = ReloadingTime;
			this.FireAccuracy = FireAccuracy;
			this.ArmorThickness = ArmorThickness;
		}
		
		public override double Attack()
		{
			if (isDestroyed())
			{
				return 0;
			}
			else
				return (100 * FireAccuracy / ReloadingTime);
		}

		public override void Defense(double damage)
		{
			if (isDestroyed())
			{
				Console.WriteLine("Tank destroyed");
			}
			else
				HealthPoints -= damage - ArmorThickness;
		}

		public new void ShowInfo()
		{
			base.ShowInfo();
			Console.WriteLine(
				$"Reloading Time - {ReloadingTime}\n" +
				$"Fire accuracy - {FireAccuracy}\n" +
				$"Armor Thickness - {ArmorThickness}\n");
		}
	}

	public class ArmoredCar : CombatVehicle
	{
		public int WeaponNumber { get; set; }
		public int MaxSpeed { get; set; }

		public ArmoredCar(string Type, string Model, double Health, int WeaponNumber,int MaxSpeed)
			: base(Type, Model, Health)
		{
			this.WeaponNumber= WeaponNumber;
			this.MaxSpeed = MaxSpeed;
		}

		public override double Attack()
		{
			if (isDestroyed())
			{
				return 0;
			}
			else
				return 50 * WeaponNumber;
		}

		public override void Defense(double damage)
		{
			if (isDestroyed())
			{
				Console.WriteLine("Already destroyed");
			}
			else
				HealthPoints -= damage - (MaxSpeed / 2);
		}

		public new void ShowInfo()
		{
			base.ShowInfo();

			Console.WriteLine(
				$"Reloading Time - {WeaponNumber}\n" +
				$"Fire accuracy - {MaxSpeed}\n");
		}
	}

	public class AirDefenseVehicle : CombatVehicle
	{
		public double Range { get; set; }
		public short Mobility { get; set; }
		public int RateOfFire { get; set; }

		public AirDefenseVehicle(string Type, string Model, double Health, double Range, short Mobility,int RateOfFire)
			: base(Type, Model, Health)
		{
			this.Range= Range;
			if(Mobility > 0 && Mobility < 11) this.Mobility= Mobility;
			this.RateOfFire = RateOfFire;
		}

		public override double Attack()
		{
			if (isDestroyed())
			{
				return 0;
			}
			else return 150 + Range * (RateOfFire / 10);
			
		}

		public override void Defense(double damage)
		{
			if (isDestroyed())
			{
				Console.WriteLine("Already destroyed");
			}
			else
				HealthPoints = damage / Mobility;
		}

		public new void ShowInfo()
		{
			base.ShowInfo();
			Console.WriteLine($"Range - {Range}\n" +
				$"Mobility level - {Mobility}\n" +
				$"Rate of Fire - {RateOfFire}\n");
		}
	}

	public class Program
	{
		public static bool Round(CombatVehicle combat1, CombatVehicle combat2)
		{
				combat2.Defense(combat1.Attack());
				combat1.Defense(combat2.Attack());

			if (combat1.isDestroyed())
			{
				return false;
			}
			return true;
		}
		static void Main(string[] args)
		{
			bool armyOneIsDestroyed = false;
			bool armyTwoIsDestroyed = false;
			List<CombatVehicle> armyOne = new List<CombatVehicle>();
			List<CombatVehicle> armyTwo = new List<CombatVehicle>();
			for(int i=0; i<5; i++)
			{
				armyOne.Add(new Tank("pdf", "mod", 10, 2, 1, 4));
				armyTwo.Add(new Tank("pdf", "mod", 90, 3, 2, 3));
			}
		    while(!armyOneIsDestroyed && !armyTwoIsDestroyed)
			{
				for (int i = 0; i < 5; i++)
				{
					Round(armyOne[i], armyTwo[i]);
				}
				int armyOneDestroyedCount = 0;
				int armyTwoDestroyedCount = 0;
				for (int y = 0; y < 5; y++)
				{
					if (armyOne[y].isDestroyed())
					{
						armyOneDestroyedCount++;
					}
					if (armyTwo[y].isDestroyed())
					{
						armyTwoDestroyedCount++;
					}
				}
				if (armyOneDestroyedCount == armyOne.Count)
				{
					armyOneIsDestroyed = true;
				}
				if (armyTwoDestroyedCount == armyTwo.Count)
				{
					armyTwoIsDestroyed = true;
				}
			}

			if (armyOneIsDestroyed)
			{
				Console.WriteLine("Second team win");
			}
			else Console.WriteLine("First team win");
			Console.ReadKey();		
		}
	}
}