namespace Task9.Entities
{
    internal class Reptile : Animal
    {
        public Reptile(string kind, float speed, float weight, Enums.Environment environment, string voise) 
            : base(kind, speed, weight, environment, voise) { }
    }
}