namespace Task8
{
    class Animal
    {
        public string Species { get; set; }
        public int Speed { get; set; }
        public int Weight { get; set; }
        public string Habitat { get; set; }

        public virtual void Move()
        {
            Console.WriteLine("The animal moves.");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Species: {Species}\n" +
           $"Speed: {Speed}\n" + 
            $"Weight: {Weight}\n "+
            $"Habitat: {Habitat}\n");
        }
    }

    class Bird : Animal
    {
        public string FeatherColor { get; set; }
        public override void Move()
        {
            Console.WriteLine("The bird flies.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The bird chirps.");
        }

        public virtual void BuildNest()
        {
            Console.WriteLine("The bird builds a nest.");
        }
    }

    class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public override void Move()
        {
            Console.WriteLine("The reptile crawls.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The reptile hisses.");
        }

        public virtual void LayEggs()
        {
            Console.WriteLine("The reptile lays eggs.");
        }
    }

    class Fish : Animal
    {
        public int MaxDepth { get; set; }
        public override void Move()
        {
            Console.WriteLine("The fish swims.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The fish doesn't make a sound.");
        }

        public virtual void BreatheUnderwater()
        {
            Console.WriteLine("The fish breathes underwater.");
        }
    }

    class Eagle : Bird
    {
        public Eagle()
        {
            Species = "Eagle";
            Speed = 120;
            Weight = 7;
            FeatherColor = "Brown";
            Habitat = "Mountains";
        }

        public override void Move()
        {
            Console.WriteLine("The Eagle flies.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The eagle screams.");
        }

        public override void BuildNest()
        {
            Console.WriteLine("The Eagle builds nest.");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Species: {Species}\n" +
           $"Speed: {Speed}\n" +
            $"Weight: {Weight}\n " +
            $"Fether color: {FeatherColor}\n " +
            $"Habitat: {Habitat}\n");
        }
    }

    class Turtle : Reptile
    {
        public Turtle()
        {
            Species = "Turtle";
            Speed = 5;
            Weight = 200;
            IsColdBlooded = true;
            Habitat = "Water";
        }

        public override void Move()
        {
            Console.WriteLine("The turtle crawls.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The turtle doesn't make a sound.");
        }
        public override void LayEggs()
        {
            Console.WriteLine("The turtle lays eggs");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Species: {Species}\n" +
           $"Speed: {Speed}\n" +
            $"Weight: {Weight}\n " +
            "Is cold blooded?" + (IsColdBlooded ? " yes\n" : " no\n") +
            $"Habitat: {Habitat}\n");
        }
    }

    class Shark : Fish
    {
        public Shark()
        {
            Species = "Shark";
            Speed = 50;
            Weight = 2000;
            MaxDepth = 100;
            Habitat = "Ocean";
        }

        public override void Move()
        {
            Console.WriteLine("The shark swims.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The shark doesn't make a sound.");
        }
        public override void BreatheUnderwater()
        {
            Console.WriteLine("The shark breaths under water");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Species: {Species}\n" +
           $"Speed: {Speed}\n" +
            $"Weight: {Weight}\n " +
            $"MaxDepth: {MaxDepth}\n " +
            $"Habitat: {Habitat}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Eagle bird = new Eagle();

            bird.Move();
            bird.MakeSound();
            bird.BuildNest();
            bird.ShowInfo();

            Turtle reptile = new Turtle();

            reptile.Move();
            reptile.MakeSound();
            reptile.LayEggs();
            reptile.ShowInfo();

            Shark fish = new Shark();

            fish.Move();
            fish.MakeSound();
            fish.BreatheUnderwater();
            fish.ShowInfo();
        }
    }
}