namespace OtherTask.Task8
{
    internal abstract class Animal
    {
        private String kind;
        private float speed;
        private float weight;
        private String livingEnvironment;

        public Animal() { }
        public Animal(string kind, float speed, float weight, string livingEnvironment)
        {
            this.kind = kind;
            this.speed = speed;
            this.weight = weight;
            this.livingEnvironment = livingEnvironment;
        }
        public string Kind => kind;
        public float Speed => speed;
        public float Weight => weight;
        public string LivingEnvironment => livingEnvironment;

        public abstract void Move();

        public abstract void MakeSound();

        public virtual void Show()
        {
            Console.Write($"kind - {kind}, speed - {speed}, weight - {weight}, livingEnvironment - {livingEnvironment}");
        }
    }
}
