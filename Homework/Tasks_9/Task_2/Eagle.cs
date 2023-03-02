namespace Tasks_9.Task_2
{
	public class Eagle : IBird,IAnimal
	{
		public string Kind { get; set; }
		public string Breed { get; set; }
		public Animal.DietType Diet { get; set; }
		public string Habitat { get; set; }
		public int LifeSpan { get; set; }
		public double Weight { get; set; }
		public int FlightHeight { get; set; }
		public int FlightSpeed { get; set; }
		public double WingSpan { get; set; }

		public Eagle() { }
		public Eagle(string kind, string breed, Animal.DietType diet, string habitat, int lifeSpan, double weight, int flightHeight, int flightSpeed, double wingSpan)
		{
			Kind = kind;
			Breed = breed;
			Diet = diet;
			Habitat = habitat;
			LifeSpan = lifeSpan;
			Weight = weight;
			FlightHeight = flightHeight;
			FlightSpeed = flightSpeed;
			WingSpan = wingSpan;
		}

		public void Fly()
		{
			Console.WriteLine($"{Kind} {Breed} is flying.");
		}
		public override string ToString()
		{

			return
				$"Eagle breed - {Breed}" +
				$"Flight height - {FlightHeight}\n" +
				$"Flight speed - {FlightSpeed}\n" +
				$"Wing span - {WingSpan}\n" +
				$"{new string('`', 70)}";
		}
	}
}
