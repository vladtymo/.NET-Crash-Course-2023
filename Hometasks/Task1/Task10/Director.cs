namespace Task10
{
    public class Director : ICloneable
    {
        public Director()
        {
            Movies = new List<Movie>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public ushort Age { get; set; }
        
        public ICollection<Movie> Movies { get; set; }

        public object Clone()
        {
            return new Director()
            {
                Name = Name,
                Surname = Surname,
                Age = Age,
                Movies = Movies
            };
        }
    }
}