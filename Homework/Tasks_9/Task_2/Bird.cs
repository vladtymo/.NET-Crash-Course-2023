using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_9.Task_2
{
	public class Bird : Animal, IBird
	{
		public int FlightHeight { get; set; }
		public int FlightSpeed { get; set; }
		public double WingSpan { get; set; }

		public Bird(string kind, string breed, double weight, string habitat, int lifeSpan, DietType diet, int flightHeight, int flightSpeed, double wingSpan)
			: base(kind, breed, weight, habitat, lifeSpan, diet)
		{
			FlightHeight = flightHeight;
			FlightSpeed = flightSpeed;
			WingSpan = wingSpan;
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

		public void Fly()
		{
			Console.WriteLine($"{Kind} {Breed} is flying");
		}
	}
}
