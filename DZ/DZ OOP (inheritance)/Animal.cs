using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
  abstract  class Animal
    {

        public string kind { get; set; }
        public double speed { get; set; }
        public double weight { get; set; }
        public string habitat { get; set; }
        abstract public void move();
        abstract public void makeSound();
        public Animal(string kind, double speed, double weight, string habitat) 
        {
            this.kind = kind;
            this.speed = speed;
            this.weight = weight;
            this.habitat = habitat;

        }
        public void showInfo()
        {
            Console.WriteLine($"The kind: {kind}]\n speed: {speed}\n weight: {weight}\n habitat: {habitat} ");
        }
    }
}
