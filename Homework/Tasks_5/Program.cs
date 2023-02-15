using Newtonsoft.Json;
namespace Tasks_5
{
    public class Weapon
	{
		
		public int range;
		public float caliber;
		public int magazine;
		public int maxSize;
	    public	Weapon() { }
		public  Weapon(int range, float caliber, int maxSize)
		{
			this.range = range;
			this.caliber = caliber;
			this.magazine = maxSize;
			this.maxSize = maxSize;
		}
		public void Initialize(int range, float caliber, int maxSize)
		{
			this.range = range;
			this.caliber = caliber;
			this.maxSize = maxSize;
			magazine = maxSize;
		}
		public bool Shot()
		{
			if (magazine > 0)
			{
				magazine -= 1;
				return true;
			}
			else return false;
		}
		public void Recharge()
		{
			this.magazine = maxSize;
		}
		public void Save()
		{
			File.WriteAllText("Data.json", JsonConvert.SerializeObject(this));
		}
		public static Weapon Load()
		{
			return JsonConvert.DeserializeObject<Weapon>(File.ReadAllText("Data.json"));
		}
		public override string ToString()
		{
			return 
				$"Range - {this.range} m\n" +
				$"Caliber - {this.caliber}\n" +
				$"Max Ammo in magazine - {this.maxSize}\n" +
				$"Current number of bullets in magazine - {this.magazine}\n" +
				$"{new string('-',70)}";
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{ 
			Weapon weapon = new Weapon();

			weapon.Initialize(1000, 5.45F, 10);
			Console.WriteLine(weapon.ToString());
			weapon.Shot();
			weapon.Save();
			Weapon weapon1 = Weapon.Load();
			Console.WriteLine(weapon1.ToString());
			Console.ReadKey();
		}
	}
}