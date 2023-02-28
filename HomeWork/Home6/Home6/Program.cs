using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Xml.Linq;

namespace Home6
{
    class Animal
    {
        string kind;
        int speed;
        int weight;
        string environment;
        public Animal(string kind, int speed, int weight, string environment)
        {
            this.kind = kind;
            this.speed = speed;
            this.weight = weight;
            this.environment = environment;
        }
        public void Move()
        {
            Console.WriteLine("Метод руху тварини");
        }
        public void MakeSound()
        {
            Console.WriteLine("Відтворення звуку");
        }
        public void Show()
        {
            Console.WriteLine($"вид: {kind}\n швидкість: {speed}\n вага: {weight}\n середовище мешкання:  {environment}" );
        }
    }
    class Bird: Animal
    {
        int sizeWings;

        public Bird(string kind, int speed, int weight, string environment) : base(kind, speed, weight, environment)
        {
            this.sizeWings = sizeWings;
        }

        public void Fly()
        {
            Console.WriteLine("Im flying");
        }
    }

    class Reptile : Animal
    {
        int numberOfLegs;
        public Reptile(string kind, int speed, int weight, string environment, int numberOfLegs)
        : base(kind, speed, weight, environment)
        {
            this.numberOfLegs = numberOfLegs;
        }
        public void Crawl()
        {
            Console.WriteLine("Im crawling");
        }
    }

    class Fish : Animal
    {
        string color;
        bool canswim;

        public Fish(string kind, int speed, int weight, string environment) : base(kind, speed, weight, environment)
        {
            this.color = color;
            this.canswim = canswim;
        }

        public void Swim()
        {
            Console.WriteLine("Im swiming");
        }
        public new void Show()
        {
            // base - reference to the base class
            base.Show();
            Console.WriteLine($"Color: {color}\n" +
                $"canswim: {canswim}");
        }
    }

    class Zootoca:Animal
    {
        int numberOfLegs;
        public Zootoca(string kind, int speed, int weight, string environment, int numberOfLegs)
: base(kind, speed, weight, environment)
        {
            this.numberOfLegs = numberOfLegs;
        }
        public new void Show()
        {
            // base - reference to the base class
            base.Show();
            Console.WriteLine($"Кількість ніг: {numberOfLegs}");
        }

    }
    class Dove : Animal
    {
        int sizeWings;
        public Dove(string kind, int speed, int weight, string environment, int sizeWings)
: base(kind, speed, weight, environment)
        {
            this.sizeWings = sizeWings;
        }
    }
    class Carp : Animal
    {
        bool canswim;
        string color;
        public Carp(string kind, int speed, int weight, string environment, bool canswim,string color)
: base(kind, speed, weight, environment)
        {
            this.canswim = canswim;
            this.color = color;
        }
        public new void Show()
        {
            // base - reference to the base class
            base.Show();
            Console.WriteLine($"Може плавати: {canswim}\n Колір: {color}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            Zootoca zootoca = new Zootoca("Рептилія", 40, 500, "земля", 6);
            zootoca.Show();
            zootoca.Move();
            zootoca.MakeSound();
            Console.WriteLine();

            Dove dove = new Dove("Рептилія", 40, 500, "земля", 2);
            dove.Show();
            dove.Move();
            dove.MakeSound();

            Console.WriteLine();

            Carp carp = new Carp("Карп", 25, 900, "Вода", true,"blue");
            carp.Show();
            carp.Move();
            carp.MakeSound();

            Console.ReadLine();
        }

    }
}
