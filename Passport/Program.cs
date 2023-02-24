namespace Passpord
{
    class Passpord
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly Birthdate { get; }
        public int IdentifiNum { get; }
        public bool IdPassport { get; set; }
        public Passpord(string name, string surname, DateOnly birthdate, int identifiNum, bool idPassport)
        {
            Name = name;
            Surname = surname;
            Birthdate = birthdate;
            IdentifiNum = identifiNum;
            IdPassport = idPassport;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\n" +
                $"Surname: {Surname}\n" +
                $"Birthdate: {Birthdate}\n" +
                $"IdentifiNum: {IdentifiNum}\n" +
                $"IdPassport: {IdPassport}");

        }
    }
    class ForeignPassport : Passpord
    {
        public ForeignPassport(string name, string surname, DateOnly birthdate, int identifiNum, bool idPassport, List<string> visas, long numForeignPassport)
            : base(name, surname, birthdate, identifiNum, idPassport)
        {
            Visas = visas;
            NumForeignPassport = numForeignPassport;
        }
        List<string> Visas = new List<string>();
        public void ShowVisa()
        {
            foreach (string visa in Visas)
            {
                Console.WriteLine("Visa: " + visa);
            }
        }
        public long NumForeignPassport { get; }
        public new void ShowInfo()
        {
            base.ShowInfo();
            ShowVisa();
            Console.WriteLine($"NumForeignPassport: {NumForeignPassport}");

        }
        public void AddVisa(string vis)
        {
            Visas.Add(vis);

        }
        public void DeletVisa()
        {
            Visas.Clear();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Passpord passpord = new Passpord("Osmolovich", "Stepan", new DateOnly(2004, 03, 23), 424280180, true);
            passpord.ShowInfo();
            Console.WriteLine("################");
            ForeignPassport foreignPassport = new ForeignPassport("Sergiy", "Gusko", new DateOnly(1979, 06, 10), 457438332, true, new List<string>() { "Itali", "Germany", "Poland" }, 1234567890123);
            foreignPassport.ShowInfo();
            Console.WriteLine("################");
            foreignPassport.ShowVisa();
        }
    }
}