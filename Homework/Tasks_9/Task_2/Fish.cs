using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_9.Task_2
{
	class Fish : Animal, IAnimal
	{
		public enum WaterType { Freshwater = 1, Saltwater, Brackishwater }
		public double SwimSpeed { get; set; }
		public WaterType Watertype { get; set; }

		public Fish(string kind, string breed, double weight, string habitat, int lifeSpan, DietType diet, double swimSpeed, WaterType watertype)
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
				$"{new string('`', 70)}";

		}

		public override void MakeSound()
		{
			Console.WriteLine("Bull-bull");
		}
	}
}
