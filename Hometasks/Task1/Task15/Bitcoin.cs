namespace Task15
{
    public class Bitcoin
    {
        private static long _id;

        static Bitcoin()
        {
            _id = 0;
        }

        public Bitcoin()
        {
            Id = _id++;
        }

        public long Id { get; }
        public double Price { get; set; }
    }
}