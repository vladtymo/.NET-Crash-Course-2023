using System;
using System.Collections.Generic;

interface IAnimal
{
    void ObtainingNutrients();
    void Respiration();
    void Circulation();
    void Movement();
    void SensingTheEnvironment();
    void Reproduction();
    void Growth();
    void DefenseHome();
    void Communication();
}

interface IInvertabrates : IAnimal
{
    void Invertebrates();
}

interface IVertebrates : IAnimal
{
    void Vertebrates();
}

interface IMammals : IVertebrates
{
    void Mammals();
}
interface IBirds : IVertebrates
{
    void Birds();
}
interface IFish : IVertebrates
{
    void Fish();
}
interface IReptiles  : IVertebrates
{
    void Reptiles();
}

interface IAmphibians : IVertebrates
{
    void Amphibians();
}

interface IInsects : IInvertabrates
{
    void Insects();
}

class Animal : IAnimal
{
    public void ObtainingNutrients()
    {
        Console.WriteLine("Animals need to consume food in order to obtain nutrients necessary for growth, repair, and maintenance of their bodies.");
    }
    public void Respiration()
    {
        Console.WriteLine("All animals need to breathe in oxygen and exhale carbon dioxide, in order to release energy from their food and to get rid of waste products.");
    }
    public void Circulation()
    {
        Console.WriteLine("Animals have a circulatory system that transports oxygen, nutrients, and other vital substances throughout their bodies.");
    }
    public void Movement()
    {
        Console.WriteLine("Most animals are capable of some kind of movement, whether it's crawling, swimming, flying, or running. This enables them to search for food, escape predators, or find mates.");
    }
    public void SensingTheEnvironment()
    {
        Console.WriteLine("Animals have specialized organs and sensory systems that allow them to perceive their environment and respond to changes in it.");
    }
    public void Reproduction()
    {
        Console.WriteLine("All animals have a mechanism for reproducing");
    }
    public void Growth()
    {
        Console.WriteLine("All animals can grow");
    }
    public void DefenseHome()
    {
        Console.WriteLine("All animals have a reflex to protect their home");
    }
    public void Communication()
    {
        Console.WriteLine("All animals should strive to communicate");
    }
}

class Cat : Animal, IAnimal, IVertebrates, IMammals
{
    public void Vertebrates()
    {
        Console.WriteLine("Cats is included in the class of vertebral");
    }
    public void Mammals()
    {
        Console.WriteLine("Cats are included in the class of mammals");
    }
}

class Ant : Animal, IAnimal, IInvertabrates, IInsects
{
    public void Invertebrates()
    {
        Console.WriteLine("Ants belong to the class of invertebrates");
    }
    public void Insects()
    {
        Console.WriteLine("ant belongs to the class of insects");
    }
}

class Rebbiit : Animal, IAnimal, IVertebrates, IMammals
{
    public void Vertebrates()
    {
        Console.WriteLine("The rabbit belongs to the vertebrate class");
    }
    public void Mammals()
    {
        Console.WriteLine("The rabbit is included in the class of mammals");
    }
}

class Snake : Animal, IAnimal, IVertebrates, IReptiles
{
    public void Vertebrates()
    {
        Console.WriteLine("The snake belongs to the vertebrate class");
    }
    public void Reptiles()
    {
        Console.WriteLine("The snake belongs to the reptile class");
    }
}

class Slark : Animal, IAnimal, IVertebrates, IAmphibians
{
    public void Vertebrates()
    {
        Console.WriteLine("The slark belongs to the vertebrate class");
    }
    public void Amphibians()
    {
        Console.WriteLine("The shark belongs to the amphibian class");
    }
}

class lesson_10_2
{
    static void Main(string[] args)
    {
        Cat cat = new Cat();
        Ant ant = new Ant();
        Rebbiit rebbiit = new Rebbiit();
        Snake snake = new Snake();
        Slark slark = new Slark();

        cat.ObtainingNutrients();
        cat.Respiration();
        cat.Circulation();
        cat.Movement();
        cat.SensingTheEnvironment();
        cat.Reproduction();
        cat.Growth();
        cat.DefenseHome();
        cat.Communication();
        cat.Vertebrates();
        cat.Mammals();

        ant.ObtainingNutrients();
        ant.Respiration();
        ant.Circulation();
        ant.Movement();
        ant.SensingTheEnvironment();
        ant.Reproduction();
        ant.Growth();
        ant.DefenseHome();
        ant.Communication();
        ant.Invertebrates();
        ant.Insects();

        rebbiit.ObtainingNutrients();
        rebbiit.Respiration();
        rebbiit.Circulation();
        rebbiit.Movement();
        rebbiit.SensingTheEnvironment();
        rebbiit.Reproduction();
        rebbiit.Growth();
        rebbiit.DefenseHome();
        rebbiit.Communication();
        rebbiit.Vertebrates();
        rebbiit.Mammals();

        snake.ObtainingNutrients();
        snake.Respiration();
        snake.Circulation();
        snake.Movement();
        snake.SensingTheEnvironment();
        snake.Reproduction();
        snake.Growth();
        snake.DefenseHome();
        snake.Communication();
        snake.Vertebrates();
        snake.Reptiles();

        slark.ObtainingNutrients();
        slark.Respiration();
        slark.Circulation();
        slark.Movement();
        slark.SensingTheEnvironment();
        slark.Reproduction();
        slark.Growth();
        slark.DefenseHome();
        slark.Communication();
        slark.Vertebrates();
        slark.Amphibians();

        Console.ReadKey();
    }
}