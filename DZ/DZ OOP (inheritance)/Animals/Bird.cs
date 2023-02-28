using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    class Bird : Animal
    {
        public Bird(string kind,double speed,double weight ,string habitat):base (kind,speed,weight,habitat)
        {
         
        }
        public override void makeSound()
        {
            Console.WriteLine("Tweets");

        }
        public override void move()
        {
            Console.WriteLine("The bird is flying");
        }
    }
}
