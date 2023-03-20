using System.Collections;

namespace task10
{
    enum Genre { Comedy = 1, Horror, Adventure, Drama }
    public class Program
    {
        static void Main(string[] args)
        {
            Director dr = new Director("Antony", "Hilltone");
            dr.ToString();
        }
    }

    class Director : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Director(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public object Clone()
        {
            return new Director(FirstName, LastName);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    class Movie : IComparable<Movie>, ICloneable
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Director Director { get; set; }
        public string Country { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public double Rating { get; set; }

        public Movie(string title, string description, Director director, string country, Genre genre, int year, double rating)
        {
            Title = title;
            Description = description;
            Director = director;
            Country = country;
            Genre = genre;
            Year = year;
            Rating = rating;
        }

        public int CompareTo(Movie other)
        {
            return Title.CompareTo(other.Title);
        }

        public object Clone()
        {
            return new Movie(Title, Description, (Director)Director.Clone(), Country, Genre, Year, Rating);
        }

        public override string ToString()
        {
            return $"{Title} ({Year}), {Genre}, directed by {Director}, rated {Rating}";
        }
    }

    class Cinema : IEnumerable<Movie>
    {
        private List<Movie> movies = new List<Movie>();

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public void SortByTitle()
        {
            movies.Sort();
        }

        public void SortByRating()
        {
            movies.Sort((a, b) => b.Rating.CompareTo(a.Rating));
        }

        public IEnumerator<Movie> GetEnumerator()
        {
            return movies.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}