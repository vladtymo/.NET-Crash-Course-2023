namespace OtherTask.Task8
{
    internal class Сrucian : Fish
    {
        public Сrucian()
        {
        }

        public Сrucian(string kind, float speed, float weight, string livingEnvironment, int numberOfScales) 
            : base(kind, speed, weight, livingEnvironment, numberOfScales)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Сrucian::MakeSound");
        }

        public override void Move()
        {
            Console.WriteLine("Сrucian::Move");
        }

        public override void Swim()
        {
            Console.WriteLine("Сrucian::Swim");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($", numberOfScales - {NmberOfScales}");
        }
    }
}
