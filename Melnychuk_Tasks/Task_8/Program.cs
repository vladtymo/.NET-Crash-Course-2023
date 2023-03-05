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
        
        public  string GetName()
        { return Name; }
        public virtual void Move()
        {
            Console.WriteLine("The animal is moving");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("*shhshshshs*");
        }
        public virtual void Show()
        {
            Console.WriteLine($"\n\t\t Name:{Name??"Noname"}|Kind:{Kind} |Speed:{Speed}km/h |Habitat:{Habitat} kg|Weight:{Weight}");
        }

    }


    class Bird : Animal
    {
        private readonly bool the_ability_to_fly;

        public Bird(string name, string kind, int speed, string habitat, float weight,bool the_ability_to_fly)
            :base( name,  kind,  speed,  habitat,  weight)
        {
            this.the_ability_to_fly = the_ability_to_fly;
        }

        public override void Move()
        {
            Console.WriteLine($"Bird {GetName()} flies");
        }
        public override void MakeSound()
        {
            Console.WriteLine("*birdsong*");
        }
        public override void Show()
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


        public override void Move()
        {
            Console.WriteLine($"The reptile {GetName()} crawls");
        }
        public override void MakeSound()
        {
            Console.WriteLine("*the sound of a reptile*");
        }
        public override void Show()
        {
            base.Show();
            Console.Write($"|color:{color}");
        }
    }

    class Fish : Animal
    {
        private readonly bool the_presence_of_scales;

       public Fish(string name, string kind, int speed, string habitat, float weight, bool the_presence_of_scales)
            : base(name, kind, speed, habitat, weight)
        {
            this.the_presence_of_scales = the_presence_of_scales;
        }

        public override void Move()
        {
            Console.WriteLine($"Fish {GetName()} swims");
        }
        public override void MakeSound()
        {
            Console.WriteLine("*silence, bul bul*");
        }
        public override void Show()
        {
            base.Show();
            Console.Write($"|the presence of scales:{the_presence_of_scales}");
        }
    }


    public static void Main(string[] args)
    {
        Bird bird = new Bird("Raven", "bird", 20, "mountain forest", 1.3F, true);
        Reptile reptile = new Reptile("Pangolin", "reptile", 3, "jungle", 0.8F, "green");
        Fish fish = new Fish("Doroty", "fish", 13, "sea", 0.2F, true);

        Animal[] zoo = {bird, reptile, fish};

        for (int i = 0; i < zoo.Length; i++)
        {
            zoo[i].Show();
            zoo[i].MakeSound();
            zoo[i].Move();
        }

    }

}