namespace Tasks_8
{
	abstract class Animal
	{
		public enum DietType { Carnivore=1, Herbivore, Omnivore }
		public string Kind { get; set; }
		public string Breed { get; set; }
		public double Weight { get; set; }
		public string Habitat { get; set; }
		public int LifeSpan { get; set; }
		public DietType Diet { get; set; }

		public Animal(string kind,string breed, double weight, string habitat, int lifeSpan, DietType diet)
		{
			Kind = kind;
			Breed = breed;
			Weight = weight;
			Habitat = habitat;
			LifeSpan = lifeSpan;
			Diet = diet;
		}
		public void Move()
		{
			Console.WriteLine($"{Kind} {Breed} is moving.");
		}
		public abstract void MakeSound();
		public override string ToString()
		{
			return $"Kind - {Kind}\n" +
				$"Breed - {Breed}\n" +
				$"Weight - {Weight}\n" +
				$"Habitat - {Habitat}\n" +
				$"Life span - {LifeSpan}\n" +
				$"Diet type - {Diet}";
		}
	}
	class Bird :Animal
	{
		public int FlightHeight { get; set; }
		public int FlightSpeed { get; set; }
		public double WingSpan { get; set; }

		public Bird(string kind, string breed, double weight, string habitat, int lifeSpan, DietType diet, int flightHeight, int flightSpeed, double wingSpan)
			:base(kind,breed,weight, habitat, lifeSpan,diet) 
		{
			FlightHeight= flightHeight;
			FlightSpeed= flightSpeed;
			WingSpan= wingSpan;
		}
		public override string ToString()
		{
			
			return 
				$"{base.ToString()}" +
				$"Flight height - {FlightHeight}\n" +
				$"Flight speed - {FlightSpeed}\n" +
				$"Wing span - {WingSpan}\n" +
				$"{new string('`', 70)}";
		}

		public override void MakeSound()
		{
			Console.WriteLine("Tweet tweet!");
		}
	}
	class Reptile : Animal
	{
		public bool IsColdBlooded { get; set; }
		public bool HasScales { get; set; }
		public bool IsVenomous { get; set; }

		public Reptile(string kind, string breed, double weight, string habitat, int lifeSpan, DietType diet, bool isColdBlooded, bool hasScales, bool isVenomous)
			: base(kind, breed, weight, habitat, lifeSpan, diet)
		{
			IsColdBlooded = isColdBlooded;
			HasScales = hasScales;
			IsVenomous = isVenomous;
		}
		public override string ToString()
		{
			return $"{base.ToString()}\n" +
				$"Is cold blooded - {IsColdBlooded}\n" +
				$"Has scales - {HasScales}\n" +
				$"Is venomous - {IsVenomous}\n" +
				$"{new string('`', 70)}";
		}

		public override void MakeSound()
		{
			Console.WriteLine("Hiss!");
		}
	}
	class Fish : Animal
	{
		public enum WaterType { Freshwater = 1,Saltwater,Brackishwater}
		public double SwimSpeed { get; set; }
		public WaterType Watertype { get; set; }

		public Fish(string kind, string breed,double weight, string habitat, int lifeSpan, DietType diet,double swimSpeed, WaterType watertype)
		: base(kind, breed, weight, habitat, lifeSpan, diet)
		{
			SwimSpeed = swimSpeed;
			Watertype = watertype;
		}
		public override string ToString()
		{
			return $"{base.ToString()}\n" +
				$"Swim speed - {SwimSpeed}\n" +
				$"Water type - {Watertype}\n" +
				$"{new string('`',70)}";

		}

		public override void MakeSound()
		{
			Console.WriteLine("Bull-bull");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			List<Animal> zoo = new List<Animal>();

			Bird bird = new Bird("Bird of prey", "Aquila audax", 5.5, "Australia", 26, Animal.DietType.Carnivore, 2000, 300, 2.3);
			Reptile reptile = new Reptile("Sea turtle", "Leatherback sea turtle (Dermochelys coriacea)", 900, "All oceans", 50, Animal.DietType.Carnivore, true, false, false);
			Fish fish = new Fish("Coelacanth", "Latimeria chalumnae and Latimeria menadoensis", 90, "Deep underwater caves", 100, Animal.DietType.Carnivore, 1.6, Fish.WaterType.Saltwater);
			zoo.Add(bird);
			zoo.Add(fish);
			zoo.Add(reptile);

			foreach(Animal item in zoo)
			{
				item.MakeSound();
				item.Move();
				Console.WriteLine(item.ToString());
				
			}

		//	Console.WriteLine(bird.ToString());
			//Console.WriteLine(reptile.ToString());
			//Console.WriteLine(fish.ToString());

			Console.ReadKey();
		}
	}
}