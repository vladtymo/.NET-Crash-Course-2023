using HomeWork8;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace HomeWork8
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Director : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"Director FirstName: {FirstName}, LastName: {LastName}";
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
    {
        Action = 1,
        Comedy,
        Drama,
        Horror,
        Romance,
        Thriller
    }

    public class Movie : IComparable<Movie>, ICloneable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Director Director { get; set; }
        public string Country { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public float Rating { get; set; }

        public Movie(string name, string description, Director director, string country, Genre genre, int year, float rating)
        {
            Name = name;
            Description = description;
            Director = director;
            Country = country;
            Genre = genre;
            Year = year;
            Rating = rating;
        }

        public int CompareTo(Movie other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public object Clone()
        {
            var copy = (Movie)this.MemberwiseClone();
            copy.Name = (string)this.Name.Clone();
            copy.Description = (string)this.Description.Clone();
            copy.Director = (Director)this.Director.Clone();
            copy.Country = (string)this.Country.Clone();

            return copy;
        }

        public override string ToString()
        {
            return $"Movie Name: {Name}\nDescription: {Description}\nDirector: {Director}\nCountry: {Country}\nGenre: {Genre}\nYear: {Year}\nRating: {Rating}";
        }
    }
    public class Cinema : IEnumerable<Movie>
    {
        private List<Movie> movies;

        public Cinema()
        {
            movies = new List<Movie>()
        {
            new Movie("The Dark Knight", "Description#1", new Director { FirstName = "Christopher", LastName = "Nolan" }, "USA", Genre.Action, 2008, 9.0f),
            new Movie("The Shawshank Redemption", "Description#2", new Director { FirstName = "Frank", LastName = "Darabont" }, "USA", Genre.Drama, 1994, 9.3f),
            new Movie("Forrest Gump", "Description#3", new Director { FirstName = "Robert", LastName = "Zemeckis" }, "USA", Genre.Drama, 1994, 8.8f)
        };
        }

        public IEnumerator<Movie> GetEnumerator()
        {
            return movies.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void SortByRating()
        {
            movies.Sort(new CompareByRating());
        }

        public void SortByYear()
        {
            movies.Sort(new CompareByYear());
        }

        private class CompareByRating : IComparer<Movie>
        {
            public int Compare(Movie x, Movie y)
            {
                return y.Rating.CompareTo(x.Rating);
            }
        }

        private class CompareByYear : IComparer<Movie>
        {
            public int Compare(Movie x, Movie y)
            {
                return x.Year.CompareTo(y.Year);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema();

            // Sort movies by rating
            cinema.SortByRating();

            // Print all movies
            Console.WriteLine("All movies sorted by rating:");
            foreach (Movie movie in cinema)
            {
                Console.WriteLine(movie);
            }

            // Sort movies by year
            cinema.SortByYear();

            // Print all movies
            Console.WriteLine("\nAll movies sorted by year:");
            foreach (Movie movie in cinema)
            {
                Console.WriteLine(movie);
            }

            // Create a deep copy of the first movie
            Movie copy = (Movie)cinema.ElementAt(0).Clone();

            // Modify the copy
            copy.Name = "The Dark Knight Rises";
            copy.Year = 2012;

            // Print the original movie and the copy
            Console.WriteLine("\nOriginal movie:");
            Console.WriteLine(cinema.ElementAt(0));
            Console.WriteLine("\nCopy of the first movie:");
            Console.WriteLine(copy);
        }
    }
}