using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Animal
    {
        string name;
        public string names { 
            get
            {
                return name;
            } 
        }
        int speed;
        string type;
        int weight;
        string living;
        string sound;

        public Animal(string name, int speed, string type, int weight, string living, string sound)
        {
            this.name = name;
            this.speed = speed;
            this.type = type;
            this.weight = weight;
            this.living = living;
            this.sound = sound;
        }

        public void Move()
        {
            Random rnd = new Random();

            Console.WriteLine($"{type}'s has moved to {rnd.Next(1,10)} metrs");
        }

        public void MakeSound()
        {
            Console.WriteLine(sound);
        }
        public void Show_info()
        {
            Console.WriteLine($"Name of {type}: {name}\n" + 
                $"Speed of {type}: {speed}\n" +
                $"Weight of {type}: {weight}\n" +
                $"{type} living enviroment: {living}\n" +
                $"{name} have sound: {sound}");
        }

    }

    public class Bird : Animal
    {
        string name;
        public string names
        {
            get
            {
                return name;
            }
        }
        int speed;
        string type;
        int weight;
        string living;
        string sound;
        public Bird(string name, int speed, string type, int weight, string living, string sound) : base(name, speed, type, weight, living , sound)
        {
            this.name = name;
            this.speed = speed;
            this.type = type;
            this.weight = weight;
            this.living = living;
            this.sound = sound;
        }
    }
    public class Fish : Animal
    {
        string name;
        public string names
        {
            get
            {
                return name;
            }
        }
        int speed;
        string type;
        int weight;
        string living;
        string sound;
        public Fish(string name, int speed, string type, int weight, string living, string sound) : base(name, speed, type, weight, living, sound)
        {
            this.name = name;
            this.speed = speed;
            this.type = type;
            this.weight = weight;
            this.living = living;
            this.sound = sound;
        }

        public new void Move()
        {
            Console.WriteLine($"{type} is swimming");
        }

        public new void MakeSound()
        {
            Console.WriteLine($"{type} is not making any sound");
        }
    }
    public class Reptile : Animal
    {
        string name;
        public string names
        {
            get
            {
                return name;
            }
        }
        int speed;
        string type;
        int weight;
        string living;
        string sound;
        public Reptile(string name, int speed, string type, int weight, string living, string sound) : base(name, speed, type, weight, living, sound)
        {
            this.name = name;
            this.speed = speed;
            this.type = type;
            this.weight = weight;
            this.living = living;
            this.sound = sound;
        }
    }
}
