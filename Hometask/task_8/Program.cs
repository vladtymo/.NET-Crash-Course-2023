namespace task_8
{
    class Animals
    {
        private bool isMove = false;
        private readonly string family;
        public int Weight { get; set; }
        public double Speed { get; set; }
        public string LiveEnviroment { get; set; }

        public Animals(string kind, double speed, int weight, string liveEnviroment)
        {
            this.family= kind;
            Speed = speed > 0 ? speed : 0;
            Weight = weight > 0 ? weight : 0;
            LiveEnviroment = liveEnviroment;
        }

        public void Move()
        {
            if (isMove)
                Console.WriteLine("The animal runs");
            else
                Console.WriteLine("The animal stopped");
            isMove = !isMove;
        }

        public void MakeSound(string sound)
        {
            Console.WriteLine(sound);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Family: {family}\n" +
                $"Speed: {Speed} km/h\n" +
                $"Weight: {Weight} kg\n" +
                $"Live enviroment: {LiveEnviroment}\n");
        }
    }

     class Bird : Animals
    {
        public int FlightHeight { get; set; }
        public int FlightRange { get; set; }




        public Bird(string kind, double speed, int weight, string liveEnviroment, int flightHeight, int fligthRange) : base(kind, speed, weight, liveEnviroment)
        {
            FlightHeight = flightHeight > 0 ? flightHeight : 0 ;
            FlightRange = fligthRange > 0 ? fligthRange : 0 ;

        }

        public void Flight(int range)
        {
            if (range > FlightRange)
                Console.WriteLine("The bird is tired and cannot fly\n");
            else
            {
                Console.WriteLine($"The bird flies!" +
                    $"Flight time: {range/Speed} \n");

            }
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Flight height: {FlightHeight} m\n" +
                $"Flight range: {FlightRange} m\n");
        }
    }

    class Reptile : Animals
    {
        public int CountEggs { get; set; }
        public int CountShedding { get; set; }
        public Reptile(string kind, double speed, int weight, string liveEnviroment, int countEggs, int countShedding) : base(kind, speed, weight, liveEnviroment)
        {
            CountEggs = countEggs > 0 ? countEggs : 0;
            CountShedding = countShedding > 0 ? countShedding : 0; 
        }

        public int AddEggs()
        {
            CountEggs++;
            return CountEggs;
        }

        public void Shedding()
        {
            Console.WriteLine("Reptile was shed the skin");
            CountShedding++;
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Number of eggs: {CountEggs}\n" +
                $"Number of shedding: {CountShedding} \n");
        }
    }

    class Fish : Animals
    {
        public int DepthOfSwimming { get; set; }
        public Fish(string kind, double speed, int weight, string liveEnviroment, int depthSwimming) : base( kind,  speed,  weight,  liveEnviroment)
        {
            DepthOfSwimming = depthSwimming > 0 ? depthSwimming : 0;
        }

        public void Swimmming()
        {
            Console.WriteLine($"The fish swims in the deep {DepthOfSwimming} m");
        }
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Depth of swimming {DepthOfSwimming} m\n");
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            Animals [] zoo = new Animals[3];

            Bird sparrow = new Bird("Passeridae", 46,1, "city",500,10000 );
            Reptile anaconda = new Reptile("Boidae", 10, 400, "river", 2, 5);
            Fish crucian = new Fish("Cyprinidae", 25, 3, "pond", 5);
            zoo[0] = sparrow;
            zoo[1] = anaconda;
            zoo[2] = crucian;

            foreach (var z in zoo)
            {
                z.ShowInfo();
                z.Move();
                z.MakeSound("Babaababa!");
                z.Move();
                Console.WriteLine("\n\n\n");
            }
            

        }
    }
}