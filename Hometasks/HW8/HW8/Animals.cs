using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal class Bird : Animal
    {
        public Bird(decimal speed, decimal weight, LivivngEnvironment environment)
            :base(AnimalType.Bird, speed, weight, environment) { }
    }

    internal class Reptile : Animal
    {
        public Reptile(decimal speed, decimal weight, LivivngEnvironment environment)
            : base(AnimalType.Reptile, speed, weight, environment) { }
    }

    internal class Fish : Animal
    {
        public Fish(decimal speed, decimal weight, LivivngEnvironment environment)
            : base(AnimalType.Fish, speed, weight, environment) { }
    }
}
