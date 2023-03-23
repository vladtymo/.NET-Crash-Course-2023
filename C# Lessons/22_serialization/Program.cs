using System.Text.Json;

namespace _22_serialization
{
    [Serializable]
    struct Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public Date(int y, int m, int d)
        {
            Year = y;
            Month = m;
            Day = d;
        }
    }

    [Serializable]
    class Human
    {
        private string identifier = "035884";
        public string Name { get; set; }
        public string Country { get; set; }
        public Date Birthdate { get; set; }
        public int[] Marks { get; set; }

        public Human(string name, string country)
        {
            Name = name;
            Country = country;

            var rand = new Random();

            Birthdate = new Date(rand.Next(1950, 2010), rand.Next(1, 13), rand.Next(1, 29));

            Marks = new int[rand.Next(20)];
            for (int i = 0; i < Marks.Length; i++)
            {
                Marks[i] = rand.Next(1, 13); // [1...12]
            }
        }

        public override string ToString()
        {
            return $"I am {Name} from {Country}. I borned at {Birthdate.Year}!";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Human> list = new List<Human>()
            {
                new Human("John", "USA"),
                new Human("Bob", "Mexico"),
                new Human("Olga", "France"),
                new Human("Vlad", "Ukraine")
            };

            // --------------serialize data
            string jsonToSave = JsonSerializer.Serialize(list);

            File.WriteAllText("data.json", jsonToSave);

            // -------------- deserialize data
            string loadedJson = File.ReadAllText("data.json");
            
            List<Human>? loaded = JsonSerializer.Deserialize<List<Human>>(loadedJson);

            foreach (var item in loaded)
            {
                Console.WriteLine(item);
            }
        }
    }
}