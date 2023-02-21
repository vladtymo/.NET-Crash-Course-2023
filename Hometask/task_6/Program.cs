namespace task_6
{
    class Plane
    {
        readonly string model;
        int flightDistance; // >0 <10000
        int? averegeFlightSpeed; //>0 <3540
        int tekeOfMass; // >0 <70000
        const int maxNumberPilots = 2;
        bool engineCondition;


        public Plane(string model)
        {
            this.model = model;
            averegeFlightSpeed = null;
            flightDistance = 1000;
            tekeOfMass = 100;
            engineCondition = false;
        }

        public Plane(string model, int averegeFlightSpeed, int flightDistance, int takeOfMass)
        {
            this.model = model;
            this.averegeFlightSpeed = averegeFlightSpeed > 0 & averegeFlightSpeed < 3540 ? averegeFlightSpeed : null;
            this.flightDistance = flightDistance > 0 & flightDistance < 10000 ? flightDistance : 0;
            this.tekeOfMass = takeOfMass > 0 & takeOfMass < 70000 ? takeOfMass : 0;
        }

        public void SwitchEngineCondition()
        {
            engineCondition = !engineCondition;
            Console.WriteLine("The engine is running");
        }
        public void ShowInformetion()
        {
            Console.WriteLine($"\nAircraft brand: {model}\n" +
                              $"Maximum flight distance: {flightDistance}\n" +
                              $"Averege flight speed: {(averegeFlightSpeed == null ? "unknown" : averegeFlightSpeed)}\n" +
                              $"Maximum weight: {tekeOfMass}\n" +
                              $"Maximum number of seats: {maxNumberPilots}\n" +
                              $"Engine condition: {engineCondition}");
        }
        public void Flight()
        {
            if (engineCondition)
                Console.WriteLine("Plane is flying");
            else
                Console.WriteLine("Plane cannot fly, because engine no power");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Plane[] airport = { new Plane("AN-224"), new Plane("Boieng 737", 500, 1500, 7000) };

            //The first plane
            Console.WriteLine("\n--------------  Plane - 0 --------------");
            airport[0].ShowInformetion();
            //The second plane
            Console.WriteLine("\n\n--------------  Plane - 1 --------------");
            airport[1].ShowInformetion();
            airport[1].Flight();
            airport[1].SwitchEngineCondition();
            airport[1].ShowInformetion();
            airport[1].Flight();






        }
    }
}