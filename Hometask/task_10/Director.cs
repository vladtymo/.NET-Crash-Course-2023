

namespace task_10
{
    internal class Director : ICloneable
    {
        public string FirstName { get; set; }
        public string LansName { get; set; }
        public int CountFilms { get; set; }

        public Director(string firstName, string lansName, int countFilms)
        {
            FirstName = firstName;
            LansName = lansName;
            CountFilms = countFilms;
        }


        public object Clone()
        {
            var copy = (Director)MemberwiseClone();
            copy.LansName = (string)this.LansName.Clone();
            copy.FirstName = (string)this.FirstName.Clone();
            return copy;
        }

        public override string ToString()
        {
            return
                    $"First name: {FirstName}\n" +
                    $"Last name: {LansName}\n" +
                    $"Count films: {CountFilms}\n";
        }
    }
}
