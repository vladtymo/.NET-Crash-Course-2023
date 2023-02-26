using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Animal animal = new Animal("Harvey", 50, "animal", 890, "Forest", "Grrrr");
            animal.Show_info();
            animal.MakeSound();
            animal.Move();

            Bird bird = new Bird("Kesha", 20, "bird", 1, "Air", "Nothing");
            
            Fish fish = new Fish("Aqua", 2, "fish", 3, "Water", "Nothing");

            Reptile reptile = new Reptile("Hameleon", 15, "Reptile", 1 ,"Anything", "Nothing");

            List<string> zoo= new List<string>();

            zoo.Add(animal.names);
            zoo.Add(bird.names);
            zoo.Add(fish.names);
            zoo.Add(reptile.names);

            foreach(string s in zoo)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}
