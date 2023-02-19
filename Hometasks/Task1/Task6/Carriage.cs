namespace Task6
{
    public class Carriage
    {
        private static long _idCounter;

        private long _id;

        public Carriage(int number, bool isHead = true, int seatsNumber = 2)
        {
            _id = _idCounter++;
            Numer = number;
            IsHead = isHead;

            if (IsHead)
            {
                SeatsNumber = 2;
            }
            else
            {
                SeatsNumber = seatsNumber;
            }
        }

        static Carriage()
        {
            _idCounter++;
        }

        public long Id => _id;
        public int Numer { get; set; }
        public bool IsHead { get; private set; }
        public int SeatsNumber { get; private set; }
    }
}