using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10_system_interfaces
{
    internal class Cinema : IEnumerable<Movie>
    {
        private List<Movie> movies = new List<Movie>();
        public string Address { get; set; }

        public override string ToString()
        {
            return $"The Address of the cinema:{Address} Number of movies: {movies.Count} ";
        }
        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }
        public void Sort()
        {
            movies.Sort();
        }
        public void Sort(IComparer<Movie> comparer)
        {
            movies.Sort(comparer);
        }
        public IEnumerator<Movie> GetEnumerator()
        {
            return movies.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
