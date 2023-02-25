namespace Task9.Entities
{
    internal class Fish : Animal
    {
        public Fish(string kind, float speed, float weight, Enums.Environment environment) 
            : base(kind, speed, weight, environment, "Fish don't talk") { }
    }
}