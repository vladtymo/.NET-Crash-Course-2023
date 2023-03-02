namespace Tasks_9.Task_2
{
	public abstract class Animal : IAnimal
	{
		public enum DietType { Carnivore = 1, Herbivore, Omnivore }
		public string Kind { get; set; }
		public string Breed { get; set; }
		public double Weight { get; set; }
		public string Habitat { get; set; }
		public int LifeSpan { get; set; }
		public DietType Diet { get; set; }

		public Animal(string kind, string breed, double weight, string habitat, int lifeSpan, DietType diet)
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
}
