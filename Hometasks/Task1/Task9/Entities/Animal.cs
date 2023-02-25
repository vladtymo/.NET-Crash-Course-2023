using Task9.Enums;

namespace Task9.Entities
{
    internal abstract class Animal
    {
        public string Kind { get; set; }
        public float Speed { get; set; }
        public float Weight { get; set; }
        public Enums.Environment Environment { get; set; }
        public string Voise { get; }

        public Animal(string kind, float speed, float weight, Enums.Environment environment, string voise)
        {
            Kind = kind;
            Speed = speed;
            Weight = weight;
            Environment = environment;
            Voise = voise;
        }

        public virtual void Move(MoveType move)
        {
            Console.WriteLine($"I'm {move} with speed {Speed}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine(Voise);
        }

        public virtual void Show()
        {
            Console.WriteLine($"Type: {this.GetType()}; Kind: {Kind}; Speed: {Speed}; Weight: {Weight}; Environment: {Environment};");
        }
    }
}