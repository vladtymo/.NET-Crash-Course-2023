using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_system_interfaces
{
    internal class Cinema : IEnumerable
    {
        List<Movie> movies = new List<Movie>();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return movies.GetEnumerator();
        }

        public Cinema(List<Movie> movies)
        {
            this.movies = movies;
        }

        public void SortRate()
        {
            movies.Sort();
            Console.WriteLine("Movies sorted by rating:");

            foreach (var movie in movies)
            {
                Console.WriteLine($" {movie.Name} -- {movie.Rating}");
            }
        }

        public void ToString()
        {
            foreach (var movie in movies)
            {
                Console.WriteLine($"Movies in cinema {movie.Name}({movie.Year})\n");
            }
        }
    }
}
