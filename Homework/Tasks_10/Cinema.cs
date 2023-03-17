using System.Collections;
using System.Collections.Generic;

namespace Tasks_10
{
	public class Cinema //: IEnumerable<Movie>
	{
		public Cinema() 
		{
		   movies = new List<Movie>();
		}
		public List<Movie> movies;
		public string Address { get; set; }

		//IEnumerator IEnumerable.GetEnumerator()
		//{
		//	return (IEnumerator)GetEnumerator();
		//}

		//public Cinema GetEnumerator()
		//{
		//	return new (movies);
		//}
	}
}
