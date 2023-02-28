using System.Reflection;

namespace _14_interfaces
{
    internal interface ISoundMaker
    {
        // properties, methods, events, indexers
        double LoudeLevel { get; }
        void MakeSound();
    }
    interface IShowable
    {
        void Show();
    }

    interface IMovable
    {
        int Speed { get; set; }
        void Move();
    }

    class Guitar : ISoundMaker
    {
        public double LoudeLevel { get; init; }
        public int Strigns { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("Dryn dryn dryn!");
        }
    }

    class Penguin : ISoundMaker, IShowable, IMovable // can implement many interfaces
    {
        public double LoudeLevel { get; init; }
        public string Name { get; init; }
        public float Weight { get; set; }
        public int Age { get; set; }
        public int Speed { get; set; } = 8;

        public void Show()
        {
            Console.WriteLine($"Penguin with weight: {Weight}, age: {Age}");
        }
        public void MakeSound()
        {
            Console.WriteLine("Peee pip pppppppp!");
        }

        public void Move()
        {
            Console.WriteLine($"I am moving with {Speed}km/h");
        }
    }

    class Car : ISoundMaker, IMovable
    {
        public double LoudeLevel { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public string BodyType { get; set; }

        public void Show()
        {
            Console.WriteLine($"Model: {Model}, speed: {Speed}km/h");
        }
        public void MakeSound()
        {
            Console.WriteLine("Beep beeeeeppppp bepp!");
        }

        public void Move()
        {
            Console.WriteLine($"I am driving with {Speed}km/h");
        }
    }

    internal class Program
    {
        static void ShowFaster(IMovable obj1, IMovable obj2)
        {
            Console.WriteLine("Move the faster object!");
            if (obj1.Speed > obj2.Speed)
                obj1.Move();
            else
                obj2.Move();
        }
        static void TestSound(ISoundMaker item)
        {
            Console.Write($"Testing sound with loude level of {item.LoudeLevel}dB: ");
            item.MakeSound();
        }
        static void Show(IShowable item)
        {
            item.Show();
        }

        static void Main(string[] args)
        {
            Guitar guitar = new Guitar()
            {
                Model = "Epiphone",
                Color = "Black",
                Strigns = 6,
                LoudeLevel = 27,
            };

            Car car = new Car()
            {
                Model = "BMW M5",
                Speed = 90,
                BodyType = "Sedan",
                LoudeLevel = 85
            };

            Penguin penguin = new Penguin()
            {
                Age = 6,
                Weight = 22.5F,
                Name = "Bob",
                LoudeLevel = 9
            };

            // cannot create an instance of an interface
            //ISoundMaker soundMaker = new ISoundMaker();
            ISoundMaker soundMaker = car;

            TestSound(penguin);
            TestSound(guitar);
            TestSound(car);

            Show(penguin);
            //Show(guitar); not implemented

            ShowFaster(car, penguin);
        }
    }
}