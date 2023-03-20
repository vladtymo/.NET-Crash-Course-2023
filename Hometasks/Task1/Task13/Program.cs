namespace Task13
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Phonebook book = new Phonebook();

            book.Book.Add("+38 093 12 34 567", new Subscriber()
            {
                Name = "Vasia",
                Surname = "Vasichkin",
            });
            book.Book.Add("+38 093 23 45 688", new Subscriber()
            {
                Name = "Patya",
                Surname = "Petechkin",
            });
            book.Book.Add("+38 093 45 67 890", new Subscriber()
            {
                Name = "Maxim",
                Surname = "Maximov",
            });
            book.Book.Add("+38 093 56 34 123", new Subscriber()
            {
                Name = "Petr",
                Surname = "Petrovich",
            });

            Console.WriteLine(book.Book["+38 093 23 45 688"].ToString());*/

            CardDeck deck = new CardDeck();
            deck.Shuffle();
            deck.PrintDeck();
            
            List<string> firstHand = deck.DealCards(6);
            List<string> secondHand = deck.DealCards(6);

            deck.PrintDeck();
        }

        static List<string> FindWordsWithMaxLength(List<string> words)
        {
            words = words.OrderByDescending(word => word.Length)
                .ToList();

            int maxLength = words[0].Length;

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length < maxLength)
                {
                    words.Remove(words[i]);
                }
            }

            return words;
        }
    }

    public class Phonebook
    {
        public Dictionary<string, Subscriber> Book { get; }

        public Phonebook()
        {
            Book = new Dictionary<string, Subscriber>();
        }
    }

    public class Subscriber
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}; Surname: {Surname};";
        }
    }
}