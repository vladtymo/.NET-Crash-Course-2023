namespace OtherTask.Task8
{
    internal class Lizard : Reptile
    {
        public Lizard()
        {
        }

        public Lizard(string kind, float speed, float weight, string livingEnvironment, int tailLength) 
            : base(kind, speed, weight, livingEnvironment, tailLength)
        {
        }
        public void GrowATail()
        {
            Console.WriteLine("Lizard::GrowATail()");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Lizard::MakeSound()");
        }

        public override void Move()
        {
            Console.WriteLine("Lizard::Move()");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($", tailLength - {TailLength}");
        }
    }
}
