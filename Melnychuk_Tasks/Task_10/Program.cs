using System;
using System.Collections;

public class Task
{
    enum Genre 
    {
        Comedy,
        Horror,
        Adventure,
        Drama
    }
    public class Cinema : IEnumerable
    {
        Movie[] movies;
        string address;

        public Cinema(Movie[] movies, string address)
        {
            this.movies = movies;
            this.address = address;
        }
        public void Sort() { Array.Sort(movies); }
        public void Sort(IComparable comparable)
        {
            Array.Sort(movies);
        }
        public IEnumerator GetEnumerator()
        {
            return movies.GetEnumerator();
        }
    }

    public class Movie : ICloneable, IComparable<Movie>
    {
        string title;
        Director director;
        string country;
        Genre genre;
        int year;
        short rating;

        public Movie(string title, Director director, string country, int genre, int year, short rating)
        {
            this.title = title;
            this.director = director;
            this.country = country;
            this.genre = (Genre)genre;    
            this.year = year;
            this.rating = rating;

        }
        public override string ToString()
        {
            return $"title:{title}| director:{director.ToString}| country: {country}| genre: {genre}| year: {year}| rating:{rating}";
        }
        public object Clone()
        {
            var copy = (Movie)this.MemberwiseClone();
            copy.title = (string)this.title.Clone();
            return copy;

        }
        public int CompareTo(Movie? other)
        {
            if (other == null) return 1;
            return this.rating.CompareTo(other.rating) * -1;
        }
    }

    public class Director : ICloneable
    {
        string FirstName;
        string LastName;

        public Director(string FirstName,string LastName)
        { this.FirstName = FirstName; this.LastName = LastName; }
        public override string ToString()
        { 
            return LastName + " " + FirstName;
        }
        public object Clone()
        {
            var copy = (Director)this.MemberwiseClone();

           
            copy.FirstName = (string)this.FirstName.Clone();
            copy.LastName = (string)this.LastName.Clone();
            return copy;

        }
    }

    public static void Main(string[] args)
    {
    }
}