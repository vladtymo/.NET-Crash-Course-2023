namespace lab_10_system_interfaces
{
    internal class Program
    {
        public class MovieCompareToYear : IComparer<Movie>
        {
            public int Compare(Movie x, Movie y)
            {
                return x.Year.CompareTo(y.Year);
            }
        }

        public class MovieCompareToRating : IComparer<Movie>
        {
            public int Compare(Movie? x, Movie? y)
            {
                return x.Rating.CompareTo(y.Rating);
            }
        }
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Harry Potter and the Prisoner of Azkaban", new Director("Alfonso", "Cuarón"), "Ukraine", Ganre.Fantasy, 2004, 8);
            Movie copyMovie1 = (Movie)movie1.Clone();
            Console.WriteLine($"Original: {movie1}");
            Console.WriteLine($"Clone: {copyMovie1}");
            copyMovie1.Title = "Harry Potter 2";
            copyMovie1.Year = 2000;
            Cinema cinema = new Cinema();
            cinema.AddMovie(movie1);
            cinema.AddMovie(copyMovie1);
            
            //cinema.Sort(new MovieCompareToYear());



        }
    }
}
