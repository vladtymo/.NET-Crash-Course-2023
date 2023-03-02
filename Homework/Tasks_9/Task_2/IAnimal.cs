namespace Tasks_9.Task_2
{
	public interface IAnimal
	{
		string Breed { get; set; }
		Animal.DietType Diet { get; set; }
		string Habitat { get; set; }
		string Kind { get; set; }
		int LifeSpan { get; set; }
		double Weight { get; set; }

		string ToString();
	}
}