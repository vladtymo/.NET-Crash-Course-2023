namespace Task6
{
    public class Train
    {
        private static long _idCounter;

        private long _id;

        public Train()
        {
            _id = _idCounter++;
            _carriages = new List<Carriage>();
            Head = new Carriage(0);
        }

        static Train()
        {
            _idCounter = 0;
        }

        private Carriage Head { get; }
        private List<Carriage> _carriages { get; }

        public string PathToFile => "DB.txt";

        private void Renumerate()
        {
            if(_carriages.Count > 0)
                for (int i = 0; i < _carriages.Count; i++)
                    _carriages[i].Numer = i + 1;
        }

        public void AddCarriageToEnd(int seatNumber)
        {
            _carriages.Add(new Carriage(0, false, seatNumber));
            Renumerate();
        }

        public void AddCarriageToStart(int seatNumber)
        {
            _carriages.Reverse();
            _carriages.Add(new Carriage(0, false, seatNumber));
            _carriages.Reverse();

            Renumerate();
        }

        public void Print()
        {
            Console.WriteLine($"{Head.Id}: {Head.Numer}\t{Head.IsHead}\t{Head.SeatsNumber}");
            foreach (Carriage car in _carriages)
                Console.WriteLine($"{car.Id}: {car.Numer}\t{car.IsHead}\t{car.SeatsNumber}");
        }
    }
}