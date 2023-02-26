namespace OtherTask.Task8
{
    internal abstract class Reptile : Animal
    {
        private int tailLength;
        public Reptile() { }

        public Reptile(string kind, float speed, float weight, string livingEnvironment, int tailLength) 
            : base (kind, speed, weight, livingEnvironment)
        {
            this.tailLength = tailLength;
        }

        public int TailLength => tailLength;

    }
}
