namespace OtherTask.Task8
{
    internal abstract class Bird : Animal
    {
        private int maxFlightHeight;
        private int flightSpeed;
        public Bird() { }
        public Bird(string kind, float speed, float weight, string livingEnvironment, int maxFlightHeight, int flightSpeed) 
            : base(kind, speed, weight, livingEnvironment)
        {
            this.maxFlightHeight = maxFlightHeight; 
            this.flightSpeed = flightSpeed;
        }

        public int FlightSpeed => flightSpeed;
        public int MaxFlightHeight => maxFlightHeight;
        public abstract void Fly();
    }
}
