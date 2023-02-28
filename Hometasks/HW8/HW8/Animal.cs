using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    enum AnimalType { Bird, Reptile, Fish }
    enum LivivngEnvironment { Forest, Ocean, Steppe, Desert }
    internal class Animal
    {
        public AnimalType? Type { get; set; }
        public decimal Speed { get; set; }
        public decimal Weight { get; set; }
        public LivivngEnvironment? Environment { get; set; }

        public Animal(AnimalType type, decimal speed, decimal weight, LivivngEnvironment environment) 
        {
            Type = type;
            Speed = speed;
            Weight = weight;
            Environment = environment;
        }
        public override string ToString()
        {
            return $"Type: {Type};\nSpeed: {Speed};\nWeight: {Weight};\nLiving environment: {Environment}.\n";
        }
        public void Move()
        {
            try
            {
                Console.Write("Choose direction:\n[1] - forward;\n[2] - left;\n[3] - right;\n[4] - backward.\nEnter: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: Console.WriteLine("I moved 1 meter forward..."); break;
                    case 2: Console.WriteLine("I moved 1 meter left..."); break;
                    case 3: Console.WriteLine("I moved 1 meter right..."); break;
                    case 4: Console.WriteLine("I moved 1 meter backward..."); break;
                    default: Console.WriteLine("I stay put..."); break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void MakeSound(string sound)
        {
            Console.WriteLine(sound);
        }
    }
}
