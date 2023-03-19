
namespace lesson_10_HW
{
    public class Movie : IComparable<Movie>, ICloneable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
        public double Rating { get; set; }

        public Director director;

        public List<Genres> genres;


        public override string ToString()
        {
            string info = $"Name: {Name}\nDescription: {Description}\n" +
                $"Country: {Country}\nYear: {Year}\n" +
                $"Rating: {Rating}\n Producer: {director.FirstName} {director.LastName}\nЖанри: ";

            foreach(Genres genre in Enum.GetValues(typeof(Genres)))
            {
                if (genres.Last() == genre)
                    info += genre;
                else
                    info += genre + ", ";
            }
            return info;
        }

        public int CompareTo(Movie? otherMovie)
        {
            if(otherMovie == null) return 1;
            return this.Year.CompareTo(otherMovie.Year);
        }

        public object Clone()
        {
            return (Movie)this.MemberwiseClone();
        }
    }
}
