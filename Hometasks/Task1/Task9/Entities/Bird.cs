namespace Task9.Entities
{
    internal class Bird : Animal
    {
        public Bird(string kind, float speed, float weight) 
            : base(kind, speed, weight, Enums.Environment.Sky, "Tsvirin'") { }
    }
}