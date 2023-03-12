using System;
using System.Collections;
using System.Collections.Generic;

public enum Genre
{
    Camedy,
    Horror,
    Adventure,
    Drama,
    Action,
    Romance,
}

public class Movie : ICloneable, IComparable<Movie>
{
    public string Title { get; set; }
    public Director Director { get; set; }
    public string Country { get; set; }
    public Genre Genre { get; set; }
    public int Year { get; set; }
    public short Rating { get; set; }

    public Movie(string Title, Director Director, string Country, Genre Genre, int Year, short Rating)
    {
        this.Title = Title;
        this.Director = Director;
        this.Country = Country;
        this.Genre = Genre;
        this.Year = Year;
        this.Rating = Rating;
    }

    public override string ToString()
    {
        return $"{Title} {Director} {Country} {Year} {Rating}";
    }

    public object Clone()
    {
        return new Movie(Title, (Director)Director.Clone(), Country, Genre, Year, Rating);
    }

    public int CompareTo(Movie other_movie)
    {
        if (other_movie == null) { return 1; }
        return Year.CompareTo(other_movie.Year);
    }
}

public class MovieRatingComparer : IComparer<Movie>
{
    public int Compare(Movie x, Movie y)
    {
        if (x == null || y == null) { return 0; }
        else return x.Rating.CompareTo(y.Rating);
    }
}

public class Director : ICloneable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Director(string FirstName, string LastName)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
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

public class Cinema : IEnumerable<Movie>
{
    private List<Movie> movies = new List<Movie>();
    public string Address { get; set; }

    public void AddMovie(Movie movie) { movies.Add(movie); }
    public void Sort() { movies.Sort(); }
    public void Sort(IComparer<Movie> comparer) { movies.Sort(comparer); }
    public IEnumerator<Movie> GetEnumerator() { return movies.GetEnumerator(); }
    IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
}

class Program
{
    static void Main(string[] args)
    {
        Director director0 = new Director("Omar", "Jackson");
        Director director1 = new Director("Nick", "Price");
        Director director2 = new Director("Phillip", "Washington");

        Movie movie0 = new Movie("Titanic", director0, "USA", Genre.Romance, 2023, 9);

        Movie copyMovie0 = (Movie)movie0.Clone();
        Director copyDirector0 = (Director)director0.Clone();

        Console.WriteLine("Original movie: ");
        Console.WriteLine(movie0);

        Console.WriteLine("\nCopy movie: ");
        Console.WriteLine(copyMovie0);

        Console.WriteLine("\nOriginal director: ");
        Console.WriteLine(director0);

        Console.WriteLine("\nCopy of director: ");
        Console.WriteLine(copyDirector0);

        Cinema cinema = new Cinema();
        cinema.AddMovie(new Movie("Midnight Sun", new Director("Sim", "Glover"), "USA", Genre.Drama, 2018, 9));
        cinema.AddMovie(new Movie("Paper Towns", new Director("Sim", "Glover"), "USA", Genre.Drama, 2015, 9));
        cinema.AddMovie(new Movie("Looking For Alaska", new Director("Sim", "Glover"), "USA", Genre.Drama, 2019, 9));
        

        foreach (Movie movie in cinema)
        {
            Console.WriteLine(movie.ToString());
        }
    }
}