namespace dz_8
{
    class Animal
    {
        public string Name { get; set; }
        public virtual string Kind { get; set; }
        public float Speed { get; set; }
        public float Weight { get; set; }
        public string Areal { get; set; }

        public void Move(int x, int y)
        {
            Console.WriteLine($"Move (x)+{x} (y)+{y} done");
        }

        public void MakeSound(string sound)
        {
            Console.WriteLine(sound);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} \nKind: {Kind} \nSpeed: {Speed} \nWeight: {Weight} \nAreal: {Areal}");
        }

    }

    class Bird : Animal
    {
        public override string Kind => "Bird";
        public int NestsCount { get; set; }
        

        public void Move(int x, int y, int z)
        {
            Console.WriteLine($"Fly (x)+{x} (y)+{y} (z)+{z} done");
        }

        public void MakeANest()
        {
            ++NestsCount;
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"NestsCount: {NestsCount}");
        }
    }

    class Reptile : Animal
    {
        public override string Kind => "Reptile";
        public DateTime DateOfShedding { get; set; }

        public void Shedding()
        {
            DateOfShedding = DateTime.Now;
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"DateOfShedding: {DateOfShedding}");
        }
    }

    class Fish : Animal
    {
        public override string Kind => "Fish";
        public int EatedCorals { get; set; }

        public void Move(int x, int y, int z)
        {
            Console.WriteLine($"Swim (x)+{x} (y)+{y} (z)+{z} done");
        }

        public void EatTheCoral()
        {
            ++EatedCorals;
            Console.WriteLine("+1 coral eated");
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"EatedCorals: {EatedCorals}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal capybara = new Animal()
            {
                Name = "Capybara",
                Kind = "Mammal",
                Speed = 1,
                Weight = 25,
                Areal = "Tropical pond"
            };
            capybara.ShowInfo();
            capybara.MakeSound("Oink oink!");
            capybara.Move(1, 2);

            Console.WriteLine("-------------------------------------------");

            Bird eagle = new Bird()
            {
                Name = "Eagle",
                Speed = 30,
                Weight = 25,
                Areal = "Steppe"
            };
            eagle.ShowInfo();
            eagle.MakeSound("Skreeew...");
            eagle.Move(9, 4, 5);

            eagle.MakeANest();
            eagle.MakeANest();
            Console.WriteLine($"Nest count: {eagle.NestsCount}");

            Console.WriteLine("-------------------------------------------");

            Reptile gecko = new Reptile()
            {
                Name = "Gecko",
                Speed = 30,
                Weight = 30,
                Areal = "Desert"
            };
            gecko.ShowInfo();
            gecko.MakeSound("Reuw reuw");
            gecko.Move(4, 2);

            gecko.Shedding();
            Console.WriteLine($"Last shedding: {gecko.DateOfShedding}");

            Console.WriteLine("-------------------------------------------");

            Fish salmon = new Fish()
            {
                Name = "Salmon",
                Speed = 10,
                Weight = 5,
                Areal = "Ocean",
                EatedCorals = 6
            };
            salmon.ShowInfo();
            salmon.Move(5, 3, 8);
            salmon.MakeSound("Blurp blurp...");

            salmon.EatTheCoral();
            salmon.EatTheCoral();
            salmon.EatTheCoral();
            Console.WriteLine($"Eated Corals: {salmon.EatedCorals}");

        }
    }
}