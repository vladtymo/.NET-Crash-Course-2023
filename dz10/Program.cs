using System;
using System.Collections;
using System.Collections.Generic;

namespace dz10
{
    public enum Genre { Action, Comedy, Drama, Horror }

    public class Cinema : IEnumerable<Movie>
    {   
        private Movie[] movies;
        private string Address { get; set; }

        public Cinema(string Address){
            this.Address = Address;
            movies = new Movie[0];
        }
        public void AddMovie(Movie m){
            movies = movies ?? new Movie[0];
            Array.Resize(ref movies, movies.Length + 1);
            movies[movies.Length - 1] = m;
        }
        public IEnumerator<Movie> GetEnumerator()
        {
            return ((IEnumerable<Movie>)movies).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(movies);
        }
        public void ShowObjects()
        {
            foreach (var film in movies)
            {
                Console.WriteLine(film);
            }
        }
        public void Sort(IComparer<Movie> comparer)
        {
            Array.Sort(movies,comparer);
        }
    }
    public class CompareByYear : IComparer<Movie>{
        public int Compare(Movie? x, Movie? y){
            if (x == null || y == null){return 0;}
            else return x.Year.CompareTo(y.Year);
        }
    }
    public class CompareByRating : IComparer<Movie>{
        public int Compare(Movie? x, Movie? y){
            if (x == null || y == null){return 0;}
            else return x.Rating.CompareTo(y.Rating);
        }
    }
    public class Director : ICloneable
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
            return $"Director: {FirstName}, {LastName}";
        }
    }

    public class Movie : IComparable<Movie>, ICloneable
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Director Director { get; set; }
        public string Country { get; set; }
        public Genre MovieGenre { get; set; }
        public int Year { get; set; }
        public double Rating { get; set; }

        public Movie(string title, string description, Director director, string country, Genre genre, int year, double rating)
        {
            Title = title;
            Description = description;
            Director = director;
            Country = country;
            MovieGenre = genre;
            Year = year;
            Rating = rating;
        }

        public int CompareTo(Movie? other)
        {
            if (other == null) return 1;
            return Title.CompareTo(other.Title);
        }

        public object Clone()
        {
            return new Movie(Title, Description, (Director)Director.Clone(), Country, MovieGenre, Year, Rating);
        }

        public override string ToString()
        {
            return $"Title: {Title}, Description: {Description}, {Director}, Country: {Country}, Genre: {MovieGenre}, Year: {Year}, Rating: {Rating}";
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Cinema cinema = new Cinema("123 Main St");
            Director director1 = new Director("Entoni,Joe", "Russo");
            Director director2 = new Director("Tom", "Shedyak");
            Director director3 = new Director("Gore", "Verbinski");
            Movie movie1 = new Movie("Avangers Final", "time travel hehehe", director1, "USA", Genre.Action, 2019, 9.7);
            Movie movie2 = new Movie("Ace ventura", "just relax and look at Jim Carry", director2, "USA", Genre.Comedy, 1994, 9.1);
            Movie movie3 = new Movie("Pirates of the Caribbean", "just relax and look at Johny Dep", director3, "USA", Genre.Drama, 1990, 7.1);
            cinema.AddMovie(movie1);
            cinema.AddMovie(movie2);
            cinema.AddMovie(movie3);

            Movie copyMovie = (Movie)movie1.Clone();
            Director copyDirector = (Director)director1.Clone();


            movie1.Year = 2000;
            Console.WriteLine("--------Original movie-------");
            Console.WriteLine(movie1);
            
            Console.WriteLine("--------Copy movie-------");
            Console.WriteLine(copyMovie);
            Console.WriteLine("--------default Sorting by Title-------");
            cinema.Sort();
            cinema.ShowObjects();
            Console.WriteLine("--------Sorting using IComparer by Rating-------");
            cinema.Sort(new CompareByRating());
            cinema.ShowObjects();
        }
    }
}
