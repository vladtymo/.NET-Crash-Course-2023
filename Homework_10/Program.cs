using System.Collections;

namespace Task
{
    public class Director : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Director(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Director: {FirstName} {LastName}";
        }

        public object Clone()
        {
            var copy = (Director)this.MemberwiseClone();
            copy.FirstName = (string)this.FirstName.Clone();
            copy.LastName = (string)this.LastName.Clone();
            return copy;
        }
    }
    public enum Genre
    { Comedy, Horror, Adventure, Drama}
    public class Movie: IComparable<Movie>, ICloneable
    {
        public string Title { get; set; }
        public Director Director { get; set; } 
        public string Country { get; set; }
        public Genre Genre { get; }
        public int Year { get; set; }
        public double Rating { get; set; }

        public Movie(string title, string firstname, string lastname, string country, Genre genre, int year, double rating) 
        { 
            Title = title;
            Director.FirstName = firstname;
            Director.LastName = lastname;
            Country = country;
            Genre = genre;
            Year = year;
            Rating = rating;
        }
        public int CompareTo(Movie? other)
        {
            if(other == null) return 1;

            return this.Rating.CompareTo(other.Rating);
        }
        public override string ToString()
        {
            return $"Title: {Title}, Director: {Director}, Country: {Country}, Genre:{Genre}, Year: {Year}, Rating:{Rating}";
        }
        public object Clone()
        {
            var copy = (Movie)this.MemberwiseClone();

            copy.Title = (string)this.Title.Clone();
            copy.Director = (Director)this.Director.Clone();
            copy.Country = (string)this.Country.Clone();
            return copy;
        }
    }
    class Cinema: IEnumerable
    {
        private Movie[] movies = null;
        public string Address { get; set; }

        public Cinema()
        {
            movies = new[]
            {
                new Movie("Spider Man", "Sam", "Rayme", "USA", Genre.Adventure, 2002, 7.4),
                new Movie("The Shawshank Redemption", "Frank", "Darabont", "USA", Genre.Drama, 1994, 9.3),
                new Movie("The Dark Knight", "Christopher", "Nolan", "USA", Genre.Adventure, 2008, 9.0),
                new Movie("Schindler's List", "Steven", "Spielberg", "USA", Genre.Drama, 1993, 9.0),
            };
            Address = "майдан Незалежності, 2, Рівне, Рівненська область, 33000";
        }

        public IEnumerator GetEnumerator()
        { return movies.GetEnumerator(); }

        public void SortMovies()
        {
            Array.Sort(movies);
        }

        public void ShowInfo() 
        {
            foreach (var item in movies)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Address of the cinema is {Address}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema();
            
            cinema.ShowInfo();
        }
    }
}
