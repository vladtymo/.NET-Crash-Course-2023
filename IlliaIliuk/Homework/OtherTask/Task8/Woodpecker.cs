namespace OtherTask.Task8
{
    internal class Woodpecker : Bird
    {
        public Woodpecker()
        {
        }

        public Woodpecker(string kind, float speed, float weight, string livingEnvironment, int maxFlightHeight, int flightSpeed) 
            : base(kind, speed, weight, livingEnvironment, maxFlightHeight, flightSpeed)
        {
        }

        public void LookForInsects()
        {
            Console.WriteLine("Woodpecker::LookForInsects()");
        }
        public override void Fly()
        {
            Console.WriteLine("Woodpecker::Fly()");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woodpecker::MakeSound()");
        }

        public override void Move()
        {
            Console.WriteLine("Woodpecker::Move()");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($", maxFlightHeight - {MaxFlightHeight}, flightSpeed - {FlightSpeed}");
        }
    }
}
