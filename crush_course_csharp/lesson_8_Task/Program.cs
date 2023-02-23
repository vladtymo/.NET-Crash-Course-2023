namespace lesson_8_Task
{
    class Passport
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Nationality { get; set; }
        public DateOnly DateIssues { get; set; }
        public string Number { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nBirthDate: {BirthDate.ToLongDateString()}" +
                $"\nNationality: {Nationality}\nDate Issues: {DateIssues.ToLongDateString()}\nNumber: {Number}");
        }
    }
    class ForeignPassport : Passport
    {
        public List<Visa> visas = new List<Visa>();
        public string NumberForeignPassport { get; set; }
        public void AddVisa(Visa visa)
        {
            visas.Add(visa);
        }
        public void checkVisa()
        {
            Console.WriteLine("Бажаєте переглянути всі візи чи для певної країни?\n" +
                "   1 - Всі\n" +
                "   2 - Для певної країни");
            string check = Console.ReadLine();
            if(check == "1")
            {
                foreach(Visa item in visas)
                {
                    Console.WriteLine(new String('-', 20));
                    Console.WriteLine($"Country: {item.Country}\n" +
                        $"Date start visa: {item.DateStart.ToLongDateString()}" +
                        $"Date end visa: {item.DateEnd.ToLongDateString()}" +
                        $"Type of visa: {item.Type}");
                }
            }
            else if(check == "2")
            {
                Console.Write("Введіть країну: ");
                string checkCountry = Console.ReadLine();
                foreach (Visa item in visas)
                {
                    if(item.Country == checkCountry)
                    {
                        Console.WriteLine(new String('-', 20));
                        Console.WriteLine($"Country: {item.Country}\n" +
                            $"Date start visa: {item.DateStart.ToLongDateString()}" +
                            $"Date end visa: {item.DateEnd.ToLongDateString()}" +
                            $"Type of visa: {item.Type}");
                    }
                }
            }

        }
        
    }
    class Visa
    {
        public string Country { get; set; }
        public DateOnly DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Type { get; set; }
        public Visa(string country, DateOnly dateStart, DateTime dateEnd, string type)
        {
            Country = country;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Type = type;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}