using System.Collections;
using System.Reflection;

namespace dz_10
{
    public enum Genre {Comedy, Horror, Adventure, Drama};

    public class Director : ICloneable
    {
        string FirstName;
        string LastName;

        public Director(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Director: {FirstName} {LastName}";
        }

        public object Clone()
        {
            var clone = (Director)this.MemberwiseClone();

            clone.FirstName = (string)this.FirstName.Clone();

            return clone;
        }
    }

    public class Movie : ICloneable, IComparable<Movie>
    {
        public string Title { get; set; }
        public Director Director { get; set; }
        public string Country { get; set; }
        public Genre GenreOfFilm { get; set; }
        public int Year { get; set; }
        public short Rating { get; set; }


        public Movie(string title, Director director, string country, Genre genre, int year, short rating)
        {
            this.Title = title;
            this.Director = director;
            this.Country = country;
            this.GenreOfFilm = genre;
            this.Year = year;
            this.Rating = rating;
        }

        public object Clone()
        {
            var clone = (Movie)this.MemberwiseClone ();

            clone.Title = (string)this.Title.Clone();

            return clone;
        }

        public int CompareTo(Movie? other)
        {
            if (other == null) return 1;
            return this.Title.CompareTo(other.Title);
        }

        public override string ToString()
        {
            return $"{Title}, {Director}, {Country}, {GenreOfFilm}, {Year}, {Rating}";
        }
    }

    public class Cinema : IEnumerable
    {
        Movie[] movies;
        string adress;

        public Cinema(Movie[] movies, string adress)
        {
            this.movies = movies;
            this.adress = adress;
        }

        public void GetMovies()
        {
            foreach (Movie i in movies)
            {
                Console.WriteLine(i);
            }
        }

        public void Sort()
        {
            Array.Sort(movies);
        }

        //public void Sort(IComparer comparer)
        //{
        //    Array.Sort(movies, comparer);
        //}

        public IEnumerator GetEnumerator()
        {
            return movies.GetEnumerator();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Director d1 = new Director("James", "Cameron");
            Director d2 = new Director("Martin","Scorsese");

            Movie m1 = new Movie("Avatar 2", d1, "USA", Genre.Adventure, 2022, 5);
            Movie m2 = (Movie)m1.Clone();
            m2.GenreOfFilm = Genre.Drama;
            m2.Year = 1912;

            Movie m3 = new Movie("Goodfellas", d2, "USA", Genre.Drama, 1990, 4);
            Movie m4 = new Movie("Movie4", d2, "USA", Genre.Comedy, 2003, 3);
            Movie m5 = (Movie)m3.Clone();

            Console.WriteLine(m3);
            Console.WriteLine(m5);
            Console.WriteLine(m5.CompareTo(m3));

            Cinema c1 = new Cinema(new Movie[] {m1,m2,m3,m4,m5}, "Frank Street 23/1");
            c1.GetMovies();
            c1.Sort();
            Console.WriteLine();
            c1.GetMovies();

            Console.WriteLine("-----------------");
            Console.WriteLine(m1);
            Console.WriteLine(m2);

        }
    }
}