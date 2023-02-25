namespace Task9.Entities
{
    internal class Mammal : Animal
    {
        public Mammal(string kind, float speed, float weight, Enums.Environment environment, string voise) 
            : base(kind, speed, weight, environment, voise) { }
    }
}