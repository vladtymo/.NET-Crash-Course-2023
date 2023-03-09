namespace crash_course_system_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Director director = new Director("James Cameron", new DateOnly(1954, 8, 16));
            Movie avatar = new Movie("Avatar", "Avatar adventures", director, "USA",Genres.Action, new DateOnly(2009, 12, 17), 7.9F);
            Movie creed = new Movie("Creed", "Boxing", director, "USA", Genres.Action, new DateOnly(2015, 4, 27), 7.6F);
            Movie whale = new Movie("The Whale", "...", director, "USA", Genres.Comedy, new DateOnly(2022, 7, 6), 7.8F);
            List<Movie> movies = new List<Movie>();
            movies.Add(avatar);
            movies.Add(creed);
            movies.Add(whale);
            var clone = avatar.Clone();
            movies.Add((Movie)clone);

            Cinema multiplex = new Cinema(movies);

            movies[0].CompareTo(movies[1]);
            multiplex.SortRate();
            avatar.ToString();

            
        }
    }
}