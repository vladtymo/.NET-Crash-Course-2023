namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema();

            List<Movie> movieList = new List<Movie>();
            for (int i = 0; i < 20; i++)
            {
                var movie = new Movie
                {
                    Title = $"Movie {i + 1}",
                    Description = $"Description for movie {i + 1}",
                    Director = new Director { Name = $"Director {i + 1}" },
                    Country = "USA",
                    Genre = Genre.Action,
                    Year = 2000 + i,
                    Rate = 5.0f,
                    Views = 1000 + i * 100
                };

                movieList.Add(movie);
            }

            cinema.Movies = movieList;

            foreach(Movie movie in cinema.Movies)
            {
                Console.WriteLine($"Title: {movie.Title}");
                Console.WriteLine($"Description: {movie.Description}");
                Console.WriteLine($"Director: {movie.Director.Name}");
                Console.WriteLine($"Country: {movie.Country}");
                Console.WriteLine($"Genre: {movie.Genre}");
                Console.WriteLine($"Year: {movie.Year}");
                Console.WriteLine($"Rate: {movie.Rate}");
                Console.WriteLine($"Views: {movie.Views}");
                Console.WriteLine();
            }
        }
    }
}