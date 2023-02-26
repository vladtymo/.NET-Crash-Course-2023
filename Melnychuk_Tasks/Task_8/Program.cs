using System;


public class Task
{

    class Animal
    {
        private readonly string Name;
        private readonly string Kind;
        private int Speed { get; set; }
        private string Habitat { get; set; }
        private float Weight { get; set; }

        public Animal(string name, string kind, int speed, string habitat, float weight)
        {
            Name = name;
            Kind = kind;
            Speed = speed;
            Weight = weight;
        }
        
        public string GetName()
        { return Name; }
        public void Move()
        {
            Console.WriteLine("The animal is moving");
        }
        public  void MakeSound()
        {
            Console.WriteLine("*shhshshshs*");
        }
        public  void Show()
        {
            Console.WriteLine($"\n\t\t Name:{Name??"Noname"}|Kind:{Kind} |Speed:{Speed} |Habitat:{Habitat} |Weight:{Weight}");
        }

    }


    class Bird : Animal
    {
        private readonly bool the_ability_to_fly;

        Bird(string name, string kind, int speed, string habitat, float weight,bool the_ability_to_fly)
            :base( name,  kind,  speed,  habitat,  weight)
        {
            this.the_ability_to_fly = the_ability_to_fly;
        }

        public new void Move()
        {
            Console.WriteLine($"Bird {GetName()} flies");
        }
        public new void MakeSound()
        {
            Console.WriteLine("*birdsong*");
        }
        public new void Show()
        {
            base.Show();
            Console.Write($"|the ability to fly:{the_ability_to_fly}");
        }
    }

    class Reptile : Animal
    {
        private readonly string color;
        public Reptile(string name, string kind, int speed, string habitat, float weight, string color)
        : base(name, kind, speed, habitat, weight)
        {
            this.color = color;
        }


        public new void Move()
        {
            Console.WriteLine($"The reptile {GetName()} crawls");
        }
        public new void MakeSound()
        {
            Console.WriteLine("*the sound of a reptile*");
        }
        public new void Show()
        {
            base.Show();
            Console.Write($"|color:{color}");
        }
    }

    class Fish : Animal
    {
        private readonly bool the_presence_of_scales;

        Fish(string name, string kind, int speed, string habitat, float weight, bool the_presence_of_scales)
            : base(name, kind, speed, habitat, weight)
        {
            this.the_presence_of_scales = the_presence_of_scales;
        }

        public new void Move()
        {
            Console.WriteLine($"Fish {GetName()} swims");
        }
        public new void MakeSound()
        {
            Console.WriteLine("*silence, bul bul*");
        }
        public new void Show()
        {
            base.Show();
            Console.Write($"|the presence of scales:{the_presence_of_scales}");
        }
    }


    public static void Main(string[] args)
    {
    }

}