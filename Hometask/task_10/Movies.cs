

namespace task_10
{
    internal class Movies : IComparable<Movies>, ICloneable
    {
        public enum Genre {Comedy, Horror, Adventure, Drama}
        private string title;
        private Director director;
        private Genre genre;
        private int year;
        private short rating;

        public Movies(string title, Director director, Genre genre, int year, short rating)
        {
            this.title = title;
            this.director = director;
            this.genre = genre;
            this.year = year;
            this.rating = rating;
        }

        public object Clone()
        {
            var copy = (Movies)this.MemberwiseClone();
            copy.director =(Director)this.director.Clone();
            copy.title = title;
            copy.rating = rating;
            copy.year = year;
            copy.genre = genre;

            
            return copy;
        }

        public int CompareTo(Movies? other)
        {
            if (other == null) return 1;
            return this.rating.CompareTo(other.rating) * -1;
        }

        public override string ToString()
        {
            return $"Title: {title} \n " +
                $"  Director:\n {director}" +
                $"Genre: {genre}\n" +
                $"Year: {year}\n" +
                $"Rating: {rating}";

        }
    }
}
