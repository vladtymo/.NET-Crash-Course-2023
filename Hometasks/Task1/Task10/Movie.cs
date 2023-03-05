namespace Task10
{
    public class Movie : ICloneable, IComparable<Movie>, IComparable
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Director Director { get; set; }
        public string Country { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public float Rate { get; set; }
        public int Views { get; set; }

        public object Clone()
        {
            return new Movie()
            {
                Country = Country,
                Director = Director.Clone() as Director,
                Description = Description,
                Genre = Genre,
                Rate = Rate,
                Title = Title,
                Views = Views,
                Year = Year,
            };
        }

        public int CompareTo(Movie? other)
        {
            if(other == null)
            {
                return 1;
            }

            for (int i = 0; i < Title.Length && i < other.Title.Length; i++)
            {
                if (Title[i] > other.Title[i])
                {
                    return 1;
                }

                if (Title[i] < other.Title[i])
                {
                    return -1;
                }
            }

            return 0;
        }

        public int CompareTo(object? obj)
        {
            Movie movie = obj as Movie;
            if (movie == null)
            {
                return 1;
            }
            return CompareTo(movie);
        }
    }
}