

using System.Collections;

namespace task_10
{
    internal class Cinema : IEnumerable
    {
        private Movies[] movies;
        private string address;

        public Cinema(Movies[] movies, string address)
        {
            this.movies = movies;
            this.address = address;
        }

        public void Sort()
        {
            Array.Sort(movies);
        }
        public void Sort(IComparer comparer)
        {
            Array.Sort(movies, comparer);
        }
        public IEnumerator GetEnumerator()
        {
            return movies.GetEnumerator();
        }
    }
}
