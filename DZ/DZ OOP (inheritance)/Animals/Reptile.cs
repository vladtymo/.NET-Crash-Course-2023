using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    class Reptile:Animal
    {
        public Reptile(string kind, double speed, double weight, string habitat): base(kind, speed, weight, habitat)
        {
           
        }
        public override void makeSound()
        {
            Console.WriteLine("KWA");
        }
        public override void move()
        {
            Console.WriteLine("The reptile walks on two legs");
        }
    }
}
