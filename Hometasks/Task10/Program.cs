using System;
using System.Collections;
using System.Collections.Generic;

public enum Genre
{
    Action,
    Comedy,
    Drama,
    Horror,
    Romance,
    Thriller
}




public class Director : ICloneable
{
    public string Name { get; set; }
    public DateTime Birthdate { get; set; }



    public Director(string new_name, DateTime new_birthdate)
    {
        Name = new_name;
        Birthdate = new_birthdate;
    }



    public object Clone()
    {
        return new Director(Name, Birthdate);
    }


    public override string ToString()
    {
        return $"{Name} ({Birthdate.ToString("yyyy-MM-dd")})";
    }
}

public class Movie : IComparable<Movie>, ICloneable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Director Director { get; set; }
    public string Country { get; set; }
    public Genre Genre { get; set; }
    public int Year { get; set; }
    public float Rating { get; set; }



    public Movie(string new_title, string new_description, Director new_director, string new_country, Genre new_genre, int new_year, float new_rating)
    {
        Title = new_title;
        Description = new_description;
        Director = new_director;
        Country = new_country;
        Genre = new_genre;
        Year = new_year;
        Rating = new_rating;
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
        return $"{Title} ({Year}), від режисера {Director.Name}, {Genre}, рейтинг {Rating}";
    }
}

public class MovieComparerByYear : IComparer<Movie>
{
    public int Compare(Movie x, Movie y)
    {
        return x.Year.CompareTo(y.Year);
    }
}

public class Cinema : IEnumerable<Movie>
{
    private List<Movie> _movies = new List<Movie>();

    public void AddMovie(Movie movie)
    {
        _movies.Add(movie);
    }

    public void Sort()
    {
        _movies.Sort();
    }

    public void SortByYear()
    {
        _movies.Sort(new MovieComparerByYear());
    }

    public void Sort(IComparer<Movie> comparer)
    {
        _movies.Sort(comparer);
    }

    public IEnumerator<Movie> GetEnumerator()
    {
        return _movies.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Director director1 = new Director("Стівен Спілберг", new DateTime(1946, 12, 18));
        Director director2 = new Director("Крістофер Нолан", new DateTime(1970, 7, 30));

        Movie movie1 = new Movie("Парк Юрського періоду", "Втеча генно - модифікованих динозаврів з острова.", director1, "США", Genre.Action, 1993, 8.1f);
        Movie movie2 = new Movie("Початок", "Злодій, який викрадає корпоративні секрети за допомогою технології обміну мріями, отримує зворотне завдання — впровадити ідею в голову генерального директора.", director2, "США", Genre.Thriller, 2010, 8.8f);
        Movie movie3 = new Movie("Темний лицар", "Коли загроза, відома як Джокер, сіє хаос і хаос серед жителів Готема, Бетмен повинен прийняти одне з найбільших психологічних і фізичних випробувань своєї здатності боротися з несправедливістю.", director2, "США", Genre.Action, 2008, 9.0f);
        Cinema cinema = new Cinema();
        cinema.AddMovie(movie1);
        cinema.AddMovie(movie2);
        cinema.AddMovie(movie3);

        Console.WriteLine("Фільми:");
        foreach (Movie movie in cinema)
        {
            Console.WriteLine(movie.ToString());
        }

        cinema.Sort();

        Console.WriteLine("\nСортування по назві:");
        foreach (Movie movie in cinema)
        {
            Console.WriteLine(movie.ToString());
        }

        cinema.SortByYear();

        Console.WriteLine("\nСортування по роках:");
        foreach (Movie movie in cinema)
        {
            Console.WriteLine(movie.ToString());
        }

        Comparer<Movie> ratingComparer = Comparer<Movie>.Create((x, y) => x.Rating.CompareTo(y.Rating));
        cinema.Sort(ratingComparer);

        Console.WriteLine("\nСортування по рейтенгу:");
        foreach (Movie movie in cinema)
        {
            Console.WriteLine(movie.ToString());
        }


    }
}
