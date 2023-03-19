
namespace lesson_10_HW
{
    public class CompareByRating : IComparer<Movie>
    {
        public int Compare(Movie? thisMovie, Movie? otherMovie)
        {
            return thisMovie.Rating.CompareTo(otherMovie.Rating);
        }
    }
}
