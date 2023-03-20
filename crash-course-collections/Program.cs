using System.Net.Http.Headers;

namespace crash_course_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        static Queue<Card> MixDeck(Card[] cards)
        {
            Random random = new Random();
            Queue<Card> queue = new Queue<Card>();

            int index;
            while(queue.Count != cards.Length )
            { 
                index = random.Next(0, cards.Length);
                if (!queue.Contains(cards[index]))
                {
                    queue.Enqueue(cards[index]);
                }
                
            }

            return queue;
        }
        static void PlaingCards()
        {
            Card[] CardDeck = new Card[36];
            Random random = new Random();
            Queue<Card> Queue = new Queue<Card>();
            Card card;

            string[] suits = { "♥", "♠", "♣", "♦" };
            string[] priorities = { "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int K = 0;

            for (int i = 0; i < priorities.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    CardDeck[K] = new Card(suits[j], priorities[i]);
                    K++;
                }
            }

            Queue = MixDeck(CardDeck);

            foreach (var item in Queue)
            {
                Console.WriteLine($"{item.Suit} {item.Priority}");
            }

            Console.WriteLine("--------------------------------------------------");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{Queue.Peek().Suit} {Queue.Dequeue().Priority}");
            }

        }
        static void PhoneBook()
        {
            Dictionary<string, string> phBook = new Dictionary<string, string>();
            PhoneBook phoneBook = new PhoneBook(phBook);

            for (int i = 0; i < 5; i++)
            {
                phoneBook.CreateNumber();
            }

            phoneBook.UpdateNumber();
            phoneBook.RemoveNumber();
            phoneBook.FindNumber();
        }
        static void MaxLength()
        {
            List<string> words = new List<string>();
            words.Add("Dimon");
            words.Add("Liza");
            words.Add("Igorok");
            words.Add("Max");
            words.Add("Den");


            int max_len = words[0].Length;
            string word = words[0];

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length > max_len)
                {
                    max_len = words[i].Length;
                    word = words[i];
                }
            }
            Console.WriteLine($"Max letters in word: {max_len} - {word}");
        }
    }
}