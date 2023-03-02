using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_9.Task_2
{
	class Reptile : Animal, IAnimal
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
}
