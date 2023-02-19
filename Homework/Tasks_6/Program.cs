using System.Net.Http.Headers;

namespace Tasks_6
{
	class Motorcycle
	{
		readonly string brand;
		readonly string model;
		readonly DateOnly releaseDate;
		const int maxHorsePower = 400;
		int? weight;
		int? horsepower;
		string color;
		public Motorcycle(string brand,string model,DateOnly date, int weight,int horsepower,string color)
		{
			this.brand = brand;	
			this.model = model;
			if (date < new DateOnly(1885, 1, 1))
			{
				throw new ArgumentException("Release date cannot be earlier than 1885");
			}
			this.releaseDate = date;
            if (weight < 1 )
				throw new ArgumentException("Weight cannot be less \"1\".");
			this.weight = weight;
			if (horsepower < 1) 
				throw new ArgumentException("Horsepower cannot be less \"1\".");
			if (horsepower > maxHorsePower)
				throw new ArgumentException("Horsepower cannot be more than 400");
			this.horsepower = horsepower;
			this.color = color;
		}
		public Motorcycle():this(new DateOnly(1885, 1, 1),100,100){}
		public Motorcycle(string brand, string model, DateOnly date, int weight, int horsepower):this(brand,model,date,weight,horsepower,"Black"){}
		public Motorcycle(string brand, DateOnly date, int weight, int horsepower) : this(brand, "Unknown", date, weight, horsepower, "Black") { }
		public Motorcycle(DateOnly date, int weight, int horsepower) : this("Unknown", "Unknown", date, weight, horsepower, "Black") { }
		public Motorcycle(int weight, int horsepower) : this("Unknown", "Unknown", new DateOnly(1885, 1, 1), weight, horsepower, "Black") { }
		public void UpdateEngine(int? horses, int? weight)
		{
			if(horses.HasValue && horses > 1 && horses <= maxHorsePower)
				horsepower = horses;
			else Console.WriteLine("Write correct horsepower");
			if(weight.HasValue && weight > 1) 
				this.weight = weight;
			else Console.WriteLine("Write correct weight");
		}
		public void ChangeColor(string color)
		{
			if (string.IsNullOrEmpty(color))
				Console.WriteLine("Color field cannot be empty");
			else
				this.color = color;
		}
		public override string ToString()
		{
			return $"Brand - {brand}\n" +
				$"Model - {model}\n" +
				$"Release Date - {releaseDate}\n" +
				$"Weight - {weight}\n" +
				$"Horsepower - {horsepower}\n" +
				$"Color - {color}\n" +
				$"{new string('`',70)}";
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Motorcycle defaultMotorcycle = new Motorcycle();
			Console.WriteLine(defaultMotorcycle.ToString());
			Motorcycle coolMotorcycle = new Motorcycle("BMW", "S 1000 RR",new DateOnly(2023,01,23),250,300,"Black Storm Metallic");
			Console.WriteLine(coolMotorcycle.ToString());
			coolMotorcycle.UpdateEngine(300, 400);
			coolMotorcycle.ChangeColor("Racing Red");
			Console.WriteLine("After modification:");
			Console.WriteLine(coolMotorcycle.ToString());
			Motorcycle prototypeMotorcycle = new Motorcycle(400, 400);
			Console.WriteLine(prototypeMotorcycle.ToString());
			
			Console.ReadKey();
		}
	}
}