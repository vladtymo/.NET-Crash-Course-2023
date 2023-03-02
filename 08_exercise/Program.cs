using System;

public class Animal
{
    public string Species { get; set; }
    public double Speed { get; set; }
    public double Weight { get; set; }
    public string Habitat { get; set; }

    public virtual void Move()
    {
        Console.WriteLine($"The {Species} is moving at {Speed} km/h.");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"The {Species} is making a sound.");
    }

    public void Show()
    {
        Console.WriteLine($"Species: {Species}");
        Console.WriteLine($"Speed: {Speed} km/h");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine($"Habitat: {Habitat}");
    }
}

public class Bird : Animal
{
    public bool CanFly { get; set; }

    public override void Move()
    {
        if (CanFly)
        {
            Console.WriteLine($"The {Species} is flying at {Speed} km/h.");
        }
        else
        {
            Console.WriteLine($"The {Species} is running at {Speed} km/h.");
        }
    }

    public override void MakeSound()
    {
        Console.WriteLine($"The {Species} is chirping.");
    }
}

public class Reptile : Animal
{
    public bool IsColdBlooded { get; set; }

    public override void Move()
    {
        Console.WriteLine($"The {Species} is slithering at {Speed} km/h.");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"The {Species} is hissing.");
    }
}

public class Fish : Animal
{
    public bool IsSaltwater { get; set; }

    public override void Move()
    {
        Console.WriteLine($"The {Species} is swimming at {Speed} km/h.");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"The {Species} is not making a sound.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal[] zoo = new Animal[3];

        Bird bird = new Bird
        {
            Species = "Bald Eagle",
            Speed = 120,
            Weight = 6.5,
            Habitat = "Forests",
            CanFly = true
        };
        zoo[0] = bird;

        Reptile reptile = new Reptile
        {
            Species = "Green Anaconda",
            Speed = 10,
            Weight = 250,
            Habitat = "Rivers",
            IsColdBlooded = true
        };
        zoo[1] = reptile;

        Fish fish = new Fish
        {
            Species = "Great White Shark",
            Speed = 56,
            Weight = 1900,
            Habitat = "Oceans",
            IsSaltwater = true
        };
        zoo[2] = fish;

        foreach (Animal animal in zoo)
        {
            animal.Show();
            animal.Move();
            animal.MakeSound();
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}