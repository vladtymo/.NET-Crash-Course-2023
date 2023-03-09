using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_system_interfaces
{
    enum Genres { Horror, Comedy, Documental, Action }

    internal class Movie : IComparable<Movie>, ICloneable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Director Director { get; set; }
        public string Country { get; set; }
        public Genres Genre { get; set; }
        public DateOnly Year { get; set; }
        public float Rating { get; set; }

        public Movie(string name, string description, Director director, string country, Genres genre, DateOnly year, float rating)
        {
            Name= name;
            Description = description;
            Director = director;
            Country = country;
            Genre = genre;
            Year = year;
            Rating = rating;
        }

        public void ToString()
        {
            Console.WriteLine($"Movie name: {Name}\n" +
                $"Description: {Description}\n" +
                $"Director: {Director.FullName}\n" +
                $"Date: {Year} \n" +
                $"Rating: {Rating}");
        }

        public int CompareTo(Movie obj)
        {
            if (obj == null) return 1;

            return this.Rating.CompareTo(obj.Rating);
        }

        public object Clone()
        {
            var copy = (Movie)this.MemberwiseClone();

            return copy;
        }
    }
}
