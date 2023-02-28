using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    class Fish : Animal
    {
        public Fish(string kind, double speed, double weight, string habitat):base (kind, speed, weight, habitat)
        {
        
        }
        public override void makeSound()
        {
            Console.WriteLine("bite");

        }
        public override void move()
        {
            Console.WriteLine("The Fish is swimming");
        }

    }
}
