namespace Animals_Zoo
{
    class Animal
    {
        public string Species { get; set; }
        public double Speed { get; set; }
        public double Weight { get; set; }
        public string Habitat { get; set; }

        public Animal(string species, double speed, double weight, string habitat)
        {
            Species = species;
            Speed = speed;
            Weight = weight;
            Habitat = habitat;
        }

        public virtual void Move()
        {
            Console.WriteLine("The animal is moving.");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal is making a sound.");
        }

        public virtual void Show()
        {
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("Speed: " + Speed + " m\\s");
            Console.WriteLine("Weight: " + Weight + " kg");
            Console.WriteLine("Habitat: " + Habitat);
        }
    }
    class Bird : Animal
    {
        public double Wingspan { get; set; }

        public Bird(string species, double speed, double weight, string habitat, double wingspan)
            : base(species, speed, weight, habitat)
        {
            Wingspan = wingspan;
        }

        public Bird(string species, double speed, double weight, string habitat) : base(species, speed, weight, habitat)
        {
        }

        public override void Move()
        {
            Console.WriteLine("The bird is flying.");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Wingspan: " + Wingspan + " m");
        }
    }
    class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }

        public Reptile(string species, double speed, double weight, string habitat, bool isColdBlooded)
            : base(species, speed, weight, habitat)
        {
            IsColdBlooded = isColdBlooded;
        }

        public override void Move()
        {
            Console.WriteLine("The reptile is slithering or crawling.");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Cold Blooded: " + IsColdBlooded);
        }
    }
    class Fish : Animal
    {
        public string WaterType { get; set; }

        public Fish(string species, double speed, double weight, string habitat, string waterType)
            : base(species, speed, weight, habitat)
        {
            WaterType = waterType;
        }

        public override void Move()
        {
            Console.WriteLine("The fish is swimming.");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Water Type: " + WaterType);
        }
    }
    class Sparrow : Bird
    {
        public Sparrow() : base("Sparrow", 20, 0.02, "air",0.2) { }
    }
    class Eagle : Bird
    {
        public Eagle() : base("Eagle", 120, 3.0, "air",2) { }
    }
    class Turtle : Reptile
    {
        public Turtle() : base("Turtle", 0.2, 10.0, "land",true) { }
    }
    class Cobra : Reptile
    {
        public Cobra() : base("Cobra", 2.0, 5.0, "land",true) { }
    }
    class Salmon : Fish
    {
        public Salmon() : base("Salmon", 10, 0.8, "water","water") { }
    }
    class Shark : Fish
    {
        public Shark() : base("Shark", 80, 2.0, "water","salt") { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Unknown", 0, 0, "Unknown environment");
            animal.Show();
            animal.Move();
            animal.MakeSound();

            Console.WriteLine();

            Bird eagle = new Bird("Eagle", 100, 5, "Sky", 2.5);
            eagle.Show();
            eagle.Move();
            eagle.MakeSound();

            Console.WriteLine();

            Reptile crocodile = new Reptile("Crocodile", 30, 500, "Water", true);
            crocodile.Show();
            crocodile.Move();
            crocodile.MakeSound();

            Console.WriteLine();

            Fish salmon = new Fish("Salmon", 20, 10, "Water", "Pink");
            salmon.Show();
            salmon.Move();
            salmon.MakeSound();
            Console.WriteLine();
            Sparrow sparrow = new Sparrow();
            sparrow.Show();
            Eagle eagle1 = new Eagle();
            eagle1.Show();
            Turtle turtle = new Turtle();
            turtle.Show();
            Cobra cobra = new Cobra();
            cobra.Show();
            Salmon salmon1 = new Salmon();
            salmon1.Show();
            Shark shark = new Shark();
            shark.Show();
            Animal[] zoo = new Animal[]{
    new Bird("Eagle", 120, 5.5, "Sky"),
    new Bird("Penguin", 20, 1.5, "Ice",1),
    new Reptile("Crocodile", 30, 500, "Water",true),
    new Reptile("Lizard", 5, 0.2, "Land",true),
    new Fish("Salmon", 40, 4, "Water","water"),
    new Fish("Clownfish", 15, 0.1, "Water","salt")
};
            foreach (Animal a in zoo)
            {
                Console.WriteLine($"Spec: {a.Species}");
                a.Move();
                a.MakeSound();
                a.Show();
                Console.WriteLine();
            }


        }
    }
}