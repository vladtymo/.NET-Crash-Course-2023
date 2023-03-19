
using System.Collections;

namespace lesson_10_HW
{
    public class Cinema : IEnumerable
    {
        public Movie[] movies;
        public Cinema(int count)
        {
            movies = new Movie[count];
            GetEnumerator();
        }
        public IEnumerator GetEnumerator()
        {
            return  movies.GetEnumerator();
        }
        public override string ToString()
        {
            return "Кількість фільмів: " + movies.Count();
        }
        public void Sort()
        {
            Array.Sort(movies);
        }
        public void Sort(IComparer<Movie> comparer)
        {
            Array.Sort(movies, comparer);
        }
        public Director CheckDirector(string firstName, string lastName)
        {
            foreach(Movie movie in movies)
            {
                if (movie == null)
                    return null;
                else if(movie.director.FirstName == firstName && movie.director.LastName == lastName) 
                    return (Director)movie.director.Clone();
            }
            return null;
        }
    }
}
