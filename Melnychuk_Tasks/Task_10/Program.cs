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

        Director director1 = new Director("FirstName1", "LastName1");
        Movie movie1 = new Movie("title1", director1, "country1", 0, 2334, 5);
        Director director2 = new Director("FirstName2", "LastName2");
        Movie movie2 = new Movie("title2", director2, "country2", 1, 2133, 9);
        Director director3 = new Director("FirstName3", "LastName3");
        Movie movie3 = new Movie("title3", director3, "country3", 2, 1932, 7);
        Director director4 = new Director("FirstName4", "LastName4");
        Movie movie4 = new Movie("title4", director4, "country4", 3, 1456, 5);

        Movie[] movies = { movie1, movie2, movie3, movie4 };
        Cinema cinema = new Cinema(movies, "Address");

       cinema.Sort();
        foreach (Movie item in cinema)
        {
            Console.WriteLine(item.ToString());
        }
    }
}