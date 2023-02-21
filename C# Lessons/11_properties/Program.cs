using System.Drawing;

namespace _11_properties
{
    class Airplane
    {
        // replace with the auto-properties
        //private string model;
        //private readonly DateOnly manufactureDate;

        private int maxPassangers;
        private int passangerCount;

        private float maxSpeed;

        // properties
        // snippet: propfull - create field with property
        public int Passengers
        {
            get 
            {
                return this.passangerCount;
            }
            set 
            {
                // value - parameter value
                if (value >= 0 && value <= maxPassangers)
                    this.passangerCount = value;
                else
                    Console.WriteLine("Invalid passengers value!");
            }
        }

        // use lambda expressions with properties
        public float MaxSpeed
        {
            get => maxSpeed;
            set => maxSpeed = value >= 0 ? value : 0;
        }

        // readonly property - has get block only
        public int FreePlaces 
        { 
            get
            {
                return maxPassangers - passangerCount;
            }
        }

        // auto-property - has a hidden field and get/set property
        // snippet: prop
        public string Model { set; get; }
        public DateOnly ManufactureDate { get; } // readonly property
        public int MyProperty { get; private set; }
        public List<int> MyList { get; } = new List<int>();
        public string Color { get; init; } = "White";

        public Airplane(string model, DateOnly manufacture)
        {
            this.Model = model;
            this.ManufactureDate = manufacture;
            maxPassangers = 100;
            passangerCount = 0;
            maxSpeed = 850; // km/h

            MyProperty = 40;
        }

        // setters / getters
        public void SetPassangers(int value)
        {
            if (value >= 0 && value <= maxPassangers)
                this.passangerCount = value;
        }
        public int GetPassengers()
        {
            ++MyProperty;
            return this.passangerCount;
        }

        public void ShowInfo()
        {
            Console.WriteLine(new String('-', 23));
            Console.WriteLine("------ Airplane -------");
            Console.WriteLine($"Model: {Model}\n" +
                $"Manufacture: {ManufactureDate}\n" +
                $"Passangers: {passangerCount} of {maxPassangers}");
        }
    }

    class Rectangle
    {
        public char Filler { get; init; }
        public int Height { get; set; }
        public int Width { get; set; }
        //public long Square { get { return Height * Width; } }
        public long Square => Height * Width;

        public void Print()
        {
            for (int h = 0; h < Height; h++)
            {
                Console.WriteLine(new string(Filler, Width));
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane("Boeing 566", new DateOnly(2008, 4, 12));

            //airplane.SetPassangers(59);
            //Console.WriteLine("Passengers: " + airplane.GetPassengers());

            airplane.Passengers = 59;
            Console.WriteLine("Passengers: " + airplane.Passengers);

            airplane.Passengers = -90; // ignore

            airplane.ShowInfo();

            //airplane.FreePlaces = 0; // readonly property
            Console.WriteLine("Free places: " + airplane.FreePlaces);

            airplane.Model = "Skyline blackstart 44";
            Console.WriteLine("New airplane model: " + airplane.Model);

            //airplane.ManufactureDate = DateOnly.MaxValue;
            Console.WriteLine("Manufacture date: " + airplane.ManufactureDate.ToLongDateString());

            airplane.MyList.Add(3);

            Airplane newAirplane = new Airplane("Boeing 123", new DateOnly(2018, 4, 7))
            {
                // initialize properties
                Color = "Black",
                Passengers = 33
            };
            //newAirplane.Color = "Black",
            newAirplane.Passengers = 55;

            Rectangle rectangle = new Rectangle()
            {
                Height = 5,
                Width = 10,
                Filler = '#'
            };
            rectangle.Print();
        }
    }
}