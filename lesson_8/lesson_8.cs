using System;

class Animal{
    public string Kind;
    public double Speed;
    public double Weight;
    public string LivingEnvironment;

    public void Move() {
        Console.WriteLine("The {0} is moving", Kind);
    }

    public void MakeSound() {
        Console.WriteLine("The {0} is making a sound", Kind);
    }

    public void Show() {
        Console.WriteLine("Kind: {0}\nSpeed: {1}\nWeight: {2}\nLiving Environment: {3}\n", Kind, Speed, Weight, LivingEnvironment);
    }
}

class Bird : Animal {
    public bool CanFly;
    public string BeakType;
}

class Reptile : Animal {
    public bool HasScales;
    public string Habitat;
}

class Fish : Animal {
    public bool HasFins;
    public string WaterType;
}

class Eagle : Bird {
    public Eagle() {
        Kind = "Eagle";
        Speed = 120;
        Weight = 6;
        LivingEnvironment = "Mountains";
        CanFly = true;
        BeakType = "Hooked";
    }
}

class Snake : Reptile {
    public Snake() {
        Kind = "Snake";
        Speed = 5;
        Weight = 10;
        LivingEnvironment = "Desert";
        HasScales = true;
        Habitat = "Ground";
    }
}

class Shark : Fish {
    public Shark() {
        Kind = "Shark";
        Speed = 50;
        Weight = 1000;
        LivingEnvironment = "Ocean";
        HasFins = true;
        WaterType = "Saltwater";
    }
}

class Program {
    static void Main() {
        Animal[] zoo = new Animal[3];

        zoo[0] = new Eagle();
        zoo[1] = new Snake();
        zoo[2] = new Shark();

        foreach (Animal animal in zoo) {
            animal.Show();
            animal.MakeSound();
            animal.Move();
        }
    }
}

