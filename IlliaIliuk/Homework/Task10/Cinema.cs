using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace Task10
{
    internal class Cinema: IEnumerable
    {
        private Movie[] movies;
        private string address;

        public Cinema(Movie[] movies, string address)
        {
            this.movies = movies;
            this.address = address;
        }
        public void ShowMovies()
        {
            foreach (var movie in movies) { Console.WriteLine(movie); }
        }
        public IEnumerator GetEnumerator()
        {
            return movies.GetEnumerator();
        }
        public override string ToString()
        {
            return $"In the cinema at the address {address} ready for viewing {movies.Length} movies";
        }
        public void Sort()
        {
            Array.Sort(this.movies);
        }
        public void Sort(IComparer<Movie> comparer)
        {
            Array.Sort(this.movies, comparer);
        }
    }
}
