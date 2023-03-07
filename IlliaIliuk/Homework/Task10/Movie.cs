namespace Task10
{
    public enum Genre
    {
        Comedy,
        Horror,
        Adventure,
        Drama,
        Historical,
        Fantasy
    }
    

    internal class Movie :ICloneable, IComparable<Movie>
    {
        private string title;
        private Director director;
        private string country;
        private Genre genre;
        private int year;
        private short rating;

        public int Year => year;
        public short Rating => rating;

        public Movie(string title, Director director, string country, Genre genre, int year, short rating)
        {
            this.title = title;
            this.director = director;
            this.country = country;
            this.genre = genre;
            this.year = year;
            this.rating = rating;
        }

        public object Clone()
        {
            var clone = (Movie)this.MemberwiseClone();
            
            return clone;
        }

        public int CompareTo(Movie? other)
        {
            return this.title.CompareTo(other.title);
        }
        public int CompareByYear(Movie? other)
        {
            return this.year.CompareTo(other.year);
        }
        public int CompareByRating(Movie? other)
        {
            return this.rating.CompareTo(other.rating);
        }

        public override string ToString()
        {
            return $"Title - {title}, genre - {genre}, year - {year}, rating - {rating}.";
        }
    }
}
