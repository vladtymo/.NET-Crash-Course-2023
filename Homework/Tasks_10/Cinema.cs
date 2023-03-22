using System.Collections;
using System.Collections.Generic;

namespace Tasks_10
{
	public class Cinema : IEnumerable<Movie>
	{
		public Cinema() 
		{
		   movies = new List<Movie>();
		}
		public List<Movie> movies;
		public string Address { get; set; }

		public void Sort()
		{
			movies.Sort();
		}

		public void SortByRating()
		{
			movies.Sort(new RatingComparer());
		}

		public void SortByYear()
		{
			movies.Sort(new YearComparer());
		}
		public IEnumerator<Movie> GetEnumerator()
		{
			return movies.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		private class RatingComparer : IComparer<Movie>
		{
			public int Compare(Movie x, Movie y)
			{
				return x.Rating.CompareTo(y.Rating);
			}
		}

		private class YearComparer : IComparer<Movie>
		{
			public int Compare(Movie x, Movie y)
			{
				return x.Year.CompareTo(y.Year);
			}
		}
	}
}
