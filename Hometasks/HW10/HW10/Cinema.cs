using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    enum Genre { Comedy, Horror, Adventure, Drama }

    internal class Cinema : IEnumerable
    {
        Movie[] movies;
        string adress;

        public IEnumerator GetEnumerator()
        {
            return movies.GetEnumerator();
        }
        public void Sort()
        {
            for (int i = 0; i < movies.Length; i++)
            {
                for(int j = 0; j < movies.Length - 1; j++)
                {
                    if (movies[j].CompareTo(movies[j + 1]) > 0)
                    {
                        var tmp = movies[j + 1];
                        movies[j + 1] = movies[j];
                        movies[j] = tmp;
                    }
                }
            }
        }
        public void SortByRating(IComparer comparer)
        {
            for (int i = 0; i < movies.Length; i++)
            {
                for (int j = 0; j < movies.Length - 1; j++)
                {
                    if (comparer.Compare(movies[i].rating, movies[i + 1].rating) > 0)
                    {
                        var tmp = movies[j + 1];
                        movies[j + 1] = movies[j];
                        movies[j] = tmp;
                    }
                }
            }
        }
        public void SortByYear(IComparer comparer)
        {
            for (int i = 0; i < movies.Length; i++)
            {
                for (int j = 0; j < movies.Length - 1; j++)
                {
                    if (comparer.Compare(movies[i].year, movies[i + 1].year) > 0)
                    {
                        var tmp = movies[j + 1];
                        movies[j + 1] = movies[j];
                        movies[j] = tmp;
                    }
                }
            }
        }
    }

    internal class Movie : IComparable<Movie>, ICloneable
    {
        public string title;
        public Director director;
        public string country;
        public Genre genre;
        public int year;
        public short rating;

        public Movie(string title, Director director, string country, Genre genre, int year, short rating) 
        {
            this.title = title;
            this.director = director;
            this.country = country;
            this.genre = genre;
            this.year = year;
            this.rating = rating;
        }
        public int CompareTo(Movie other)
        {
            if (other == null) return 1;
            return this.rating.CompareTo(other.rating) * -1;
        }
        public object Clone()
        {
            var copy = (Movie)this.MemberwiseClone();
            copy.title = (string)this.title.Clone();
            return copy;
        }
        public string ToString()
        {
            return $"{title}\nDirector: {director}\nCountry: {country}\nGenre: {genre}\nYear: {year}\nRating: {rating}\n\n";
        }
    }

    internal class Director : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Director(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public object Clone()
        {
            var copy = (Director)this.MemberwiseClone();
            copy.FirstName = (string)this.FirstName.Clone();
            copy.LastName = (string)this.LastName.Clone();
            return copy;
        }
        public string ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\n\n";
        }
    }
}
