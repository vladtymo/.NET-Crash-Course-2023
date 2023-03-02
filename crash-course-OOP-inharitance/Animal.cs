using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_OOP_inharitance
{
    internal class Animal
    {
        private string Species { get; }
        private float Speed { get; set; }
        private int Weight { get; set; }
        private string Environment { get; }

        public Animal(string species, float speed, int weight, string environment)
        { 
            Species = species;
            Speed = speed;
            Weight = weight;
            Environment = environment;
        }

        public void Move()
        {
            Console.WriteLine("Animal is moving");
        }

        public void MakeSound()
        {
            Console.WriteLine("Animal makes sound");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Animal info\n" +
                $"Species: {Species}\n" +
                $"Speed: {Speed} km/h\n" +
                $"Weight: {Weight} kg\n" +
                $"Environment: {Environment}\n");
        }
    }
}
