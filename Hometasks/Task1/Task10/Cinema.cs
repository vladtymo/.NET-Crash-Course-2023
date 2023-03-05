using System.Collections;

namespace Task10
{
    public class Cinema : IEnumerable, IEnumerable<Movie>
    {
        public Cinema()
        {
            Movies = new List<Movie>();
        }

        public List<Movie> Movies { get; set; }

        public IEnumerator GetEnumerator()
        {
            return new CinemaEnumerator(Movies);
        }

        IEnumerator<Movie> IEnumerable<Movie>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class CinemaEnumerator : IEnumerator
    {
        private readonly List<Movie> _movies;

        private int _index;

        public CinemaEnumerator(List<Movie> movies)
        {
            _movies = movies;
            _index = 0;
        }

        public object Current => _movies[_index];

        public bool MoveNext()
        {
            if(_index < _movies.Count)
            {
                _index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _index = 0;
        }
    }

    public class CinemaEnumerator<Movie> : IEnumerator<Movie>
    {
        private readonly List<Movie> _movies;
        private int _index;

        public CinemaEnumerator(List<Movie> movies)
        {
            _movies = movies;
            _index = 0;
        }

        public Movie Current => _movies[_index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if(_index < _movies.Count)
            {
                _index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}