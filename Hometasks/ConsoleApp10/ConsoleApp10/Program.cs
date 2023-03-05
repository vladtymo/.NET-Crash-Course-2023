using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp10
{
    public enum Genre
    {
        Action,
        Comedy,
        Drama,
        Horror,
        Romance,
        Thriller
    }


    public class Cinema : IEnumerable<Movie>
    {
        List<Movie> movies = new List<Movie>();
        public string address { get; set; }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }
        public void RemoveMovie(Movie movie)
        {
            movies.Remove(movie);
        }
        public void SortMovies()
        {
            movies.Sort();
        }

        public void SortMovies(IComparer<Movie> comp)
        {
            movies.Sort(comp);
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

    public class Movie : IComparable<Movie>, ICloneable
    {
        public string title { get; set; }
        public Director Director { get; set; }
        public string country { get; set; }
        public Genre Genre { get; set; }
        public int year { get; set; }
        public short rating { get; set; }

        public Movie(string title, Director director, string country, Genre genre, int year, short rating)
        {
            this.title = title;
            this.Director = director;

            this.country = country;
            this.Genre = genre;
            this.year = year;
            this.rating = rating;
        }

        public object Clone()
        {
            return new Movie(title, Director, country, Genre, year, rating);
        }

        public int CompareTo(Movie other)
        {
            return title.CompareTo(other.title);
        }

        public override string ToString()
        {
            return $"Назва: {title}.\nРежиccер: {(Director != null ? Director.ToString() : "Не встановлено")}.\nКраїна: {country}.\nЖанр: {Enum.GetName(typeof(Genre), Genre)}.\nРік: {year}.\nРейтинг:{rating}";
        }

    }
    class MovieComp : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y)
        {
            return x.rating.CompareTo(y.rating);
        }
    }

    public class Director : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Director(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public object Clone()
        {
            return new Director(FirstName, LastName);
        }
        public override string ToString()
        {
            return $"Імя: {FirstName}, Фамілія: {LastName}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var cinema = new Cinema();
            cinema.AddMovie(new Movie("Fast and Furious 3", new Director("Nazar", "Koval"), "USA", Genre.Action, 2007, 9));
            cinema.AddMovie(new Movie("Fast and Furious 5", new Director("Nazar", "Koval"), "USA", Genre.Action, 2014, 10));
            cinema.AddMovie(new Movie("Fast and Furious 4", new Director("Nazar", "Koval"), "USA", Genre.Action, 2011, 9));
            foreach (var movie in cinema)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();

            cinema.SortMovies();

            foreach (var movie in cinema)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();
            cinema.SortMovies(new MovieComp());
            foreach (var movie in cinema)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();


        }
    }
}
