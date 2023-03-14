internal class Program
{
    public interface IMotorVehicle
    {
        void StartEngine();
        void StopEngine();
    }
    public interface IPrintInfo
    {
        void PrintInfo();
    }
    public interface IPassengerCarrier
    {
        void LoadPassengers(int numberOfPassengers);
        void UnloadPassengers(int numberOfPassengers);
    }

    public class WheeledVehicle : IMotorVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }

    public class FlyingTransport: IMotorVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }

        public void TakeOff()
        {
            Console.WriteLine("Taking off.");
        }

        public void Land()
        {
            Console.WriteLine("Landing.");
        }
    }
    public class Airplane : FlyingTransport,IPrintInfo
    {
        public string Route {get;set;}
        public double Distance {get;set;}
        public void PrintInfo(){
            Console.WriteLine("Route: {0},Distance: {1}",Route,Distance);
        }

    }

    public class Ship : IMotorVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }

        public void Sail()
        {
            Console.WriteLine("Sailing.");
        }
    }


    public class Bus : WheeledVehicle, IPassengerCarrier
    {
        private int passengerCount;
        private const int maxPassengerCount = 40;

        public void LoadPassengers(int numberOfPassengers)
        {
            passengerCount += numberOfPassengers;
            if(passengerCount > maxPassengerCount){
                Console.WriteLine("Sory,we can only have {0} passengers", maxPassengerCount);
                passengerCount = maxPassengerCount;
            }else{
                Console.WriteLine("{0} passengers loaded.", numberOfPassengers);
            }
            
        }

        public void UnloadPassengers(int numberOfPassengers)
        {
            passengerCount -= numberOfPassengers;
            if(passengerCount < 0){
                Console.WriteLine("Wait, how is that even possible?");
                passengerCount = 0;
            }else{
                Console.WriteLine("{0} passengers unloaded.", numberOfPassengers);
            }
            
        }
    }

    public class Car : WheeledVehicle, IPassengerCarrier
    {
        private int passengerCount;
        private const int maxPassengerCount = 6;

        public void LoadPassengers(int numberOfPassengers)
        {
            passengerCount += numberOfPassengers;
            if(passengerCount > maxPassengerCount){
                Console.WriteLine("Sory,we can only have {0} passengers", maxPassengerCount);
                passengerCount = maxPassengerCount;
            }else{
                Console.WriteLine("{0} passengers loaded.", numberOfPassengers);
            }
        }

        public void UnloadPassengers(int numberOfPassengers)
        {
            passengerCount -= numberOfPassengers;
            if(passengerCount < 0){
                Console.WriteLine("Wait, how is that even possible?");
                passengerCount = 0;
            }else{
                Console.WriteLine("{0} passengers unloaded.", numberOfPassengers);
            }
        }
    }
    private static void Main(string[] args)
    {
        Airplane a = new Airplane(){Route = "Київ - США",Distance = 7830};
        Car c = new Car();
        Bus b = new Bus();
        Ship s = new Ship();
        a.StartEngine();
        a.TakeOff();
        a.PrintInfo();
        a.StopEngine();
        c.LoadPassengers(4);
        c.UnloadPassengers(3);
        b.LoadPassengers(30);
        b.UnloadPassengers(40);
    }
}