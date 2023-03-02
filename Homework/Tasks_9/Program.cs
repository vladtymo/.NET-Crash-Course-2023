using Tasks_9.Task_2;

namespace Tasks_9
{
	public class Program
	{
		static void Main(string[] args)
		{
			Eagle eagle = new Eagle("Bird of prey", "Aquila audax", Animal.DietType.Carnivore, "Australia", 26, 3.5, 2000, 300, 2.3);
			Reptile reptile = new Reptile("Sea turtle", "Leatherback sea turtle (Dermochelys coriacea)", 900, "All oceans", 50, Animal.DietType.Carnivore, true, false, false);
			Fish fish = new Fish("Coelacanth", "Latimeria chalumnae and Latimeria menadoensis", 90, "Deep underwater caves", 100, Animal.DietType.Carnivore, 1.6, Fish.WaterType.Saltwater);

		}
	}
}