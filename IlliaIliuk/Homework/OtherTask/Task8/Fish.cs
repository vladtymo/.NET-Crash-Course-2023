namespace OtherTask.Task8
{
    internal abstract class Fish : Animal
    {
        private int numberOfScales;
        public Fish() { }

        public Fish(string kind, float speed, float weight, string livingEnvironment, int numberOfScales) 
            : base(kind, speed, weight, livingEnvironment)
        {
            this.numberOfScales = numberOfScales;
        }

        public int NmberOfScales => numberOfScales;

        public abstract void Swim();
    }
}
