using System.Collections.Generic;

namespace Task10
{
    public class CompareByRating : IComparer<Movie>
    {
        int IComparer<Movie>.Compare(Movie? x, Movie? y)
        {
            return x.Rating.CompareTo(y.Rating);
        }
    }
    public class CompareByYear : IComparer<Movie>
    {
        int IComparer<Movie>.Compare(Movie? x, Movie? y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }


    internal class Program
    {
        static void Main()
        {
            Movie[] movies = {
                new("The hangover", new("Todd", "Phillips"), "USA", Genre.Comedy, 2009, 77),
                new("Saw", new("James", "Wan"), "USA", Genre.Horror, 2004, 76),
                new("Harry Potter and the Philosopher's Stone", new("Chris", "Columbus"), "USA and UK", Genre.Fantasy, 2001, 90),
                new("Changeling", new("Clint", "Eastwood"), "USA", Genre.Drama, 2008, 78),
                new("1917", new("Sam", "Mandes"), "UK and USA", Genre.Historical, 2019, 82),
                new("Pirates of the Caribbean: The Curse of the Black Pearl", new("John", "Huston"), "USA and UK", Genre.Adventure, 2004, 81) };
            
            Cinema cinema = new(movies,"Rivne");
            cinema.ShowMovies();
            cinema.Sort();
            Console.WriteLine("------------------");
            cinema.ShowMovies();
           
            cinema.Sort(new CompareByYear());
            Console.WriteLine("------------------");
            cinema.ShowMovies();
            cinema.Sort(new CompareByRating());
            Console.WriteLine("------------------");
            cinema.ShowMovies();
        }
    }
}
