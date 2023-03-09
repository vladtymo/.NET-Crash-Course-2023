using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10_system_interfaces
{
    public enum Ganre{Comedy,Horror,Adventure,Drama,Historical,Fantasy}

    internal class Movie : ICloneable, IComparable<Movie>
    {
       public string Title {get; set;}
       public Director Director {get; set;}
       public string Country{get; set;}
       public Genre Genre{get; set;}
       public int Year{get; set;}
       public short Rating{get; set;}
       
       public Movie(string Title, Director Director, string Country, Ganre Ganre,int Year,short Rating)
       { 
           this.Title=Title;
           this.Director=Director;
           this.Country=Country;
           this.Ganre=Ganre;
           this.Year = Year;
           this.Rating = Rating;
       }
       public override string ToString()
       {
           return $"Title: {Title}, Genre: {Genre}, Year: {Year}, Rating: {Rating}.";
       }
       public object Clone()
       {
           return new Movie(Title, (Director)Director.Clone(), Country, Genre, Year, Rating);
       }
       public int CompareTo(Movie otherMovie)
        {
            return Title.CompareTo(otherMovie.Title);
        }
       public int CompareToYear(Movie otherMovie)
       {
           if(other_movie == null){ return 1;}
           return Year.CompareTo(otherMovie.Year);
       }
       public int CompareToRating(Movie otherMovie)
       {
           if(otherMovie == null){ return 1;}
           return Rating.CompareTo(otherMovie.Rating);
       }
    }
}
