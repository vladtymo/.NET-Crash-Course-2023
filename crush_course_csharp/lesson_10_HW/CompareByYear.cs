
namespace lesson_10_HW
{
    public class CompareByYear : IComparer<Movie>
    {
        public int Compare(Movie? thisMovie, Movie? otherMovie)
        {
            return thisMovie.Year.CompareTo(otherMovie.Year);
        }
    }
}
