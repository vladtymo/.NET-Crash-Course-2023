using System;
using System.Collections.Generic;
using System.Linq;
public class Task
{
    class PhoneBook
    {
        private Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        public void Add(string key, string value)
        {
            phoneBook.Add(key, value);
        }
        public void Update(string key, string value)
        {
            if (phoneBook.ContainsKey(key))
            {
                phoneBook[key] = value;
            }
        }
        public string Find(string key)
        {
            string value;
            phoneBook.TryGetValue(key, out value);
            return value;
        }
        public void Remove(string key)
        {
            phoneBook.Remove(key);
        }

    }

    public class CardDeck
    {
        private Queue<Card> deck;

        public CardDeck()
        {
           
            deck = new Queue<Card>(GenerateCards());
        }

       
        private IEnumerable<Card> GenerateCards() // генерація колоди з 52 карт
        {
            for (int i = 1; i <= 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    string suit = "";
                    switch (j)
                    {
                        case 0: suit = "Hearts"; break;
                        case 1: suit = "Diamonds"; break;
                        case 2: suit = "Clubs"; break;
                        case 3: suit = "Spades"; break;
                    }
                    yield return new Card(suit, i);
                }
            }
        }

        
        public Card GetCard()// отримання карти з колоди
        {
            if (deck.Count == 0)
            {
                throw new InvalidOperationException("The deck is empty!");
            }
            return deck.Dequeue();
        }

        
        public List<Card> DealCards()// роздача по 6 карт за раз
        {
            if (deck.Count < 6)
            {
                throw new InvalidOperationException("Not enough cards to deal!");
            }
            List<Card> hand = new List<Card>();
            for (int i = 0; i < 6; i++)
            {
                hand.Add(deck.Dequeue());
            }
            return hand;
        }

        
        public void Shuffle()// перемішування колоди
        {
            Random random = new Random();
            List<Card> cards = deck.ToList();
            for (int i = 0; i < cards.Count; i++)
            {
                int j = random.Next(i, cards.Count);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
            deck = new Queue<Card>(cards);
        }

       
        public Card DrawCard() // отримання та видалення карти з колоди
        {
            return GetCard();
        }

       
        public List<Card> Deal(int count) // роздача по n карт
        {
            if (deck.Count < count)
            {
                throw new InvalidOperationException("Not enough cards to deal!");
            }
            List<Card> hand = new List<Card>();
            for (int i = 0; i < count; i++)
            {
                hand.Add(deck.Dequeue());
            }
            return hand;
        }
    }

    public class Card
    {
        public string Suit { get; }
        public int Rank { get; }

        public Card(string suit, int rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            string rankStr = "";
            switch (Rank)
            {
                case 1: rankStr = "Ace"; break;
                case 11: rankStr = "Jack"; break;
                case 12: rankStr = "Queen"; break;
                case 13: rankStr = "King"; break;
                default: rankStr = Rank.ToString(); break;
            }
            return rankStr + " of " + Suit;
        }
    }


    public static void Main(string[] args)
    {

        List<string> words = new List<string> { "apple", "banana", "cherry", "date", "eggplant", "fig", "grape" };

        string longestWord = words.MaxBy(s => s.Length);
        Console.WriteLine("Longest word: " + longestWord);

        string firstLongestWord = words.OrderByDescending(s => s.Length).ThenBy(s => s).First();
        Console.WriteLine("First longest word: " + firstLongestWord);

        PhoneBook phoneBook = new PhoneBook();
        phoneBook.Add("555-1234", "John Smith");
        phoneBook.Add("555-5678", "Jane Doe");
        phoneBook.Update("555-1234", "John Doe");
        string phoneNumber = phoneBook.Find("555-5678");
        phoneBook.Remove("555-1234");


        CardDeck deck = new CardDeck(); 
        deck.Shuffle(); 

   
        Card drawnCard = deck.DrawCard();
        Console.WriteLine("Drawn card: {0} of {1}", drawnCard.Rank, drawnCard.Suit);

       
        List<Card> hand = deck.Deal(6);
        Console.WriteLine("Hand:");
        foreach (Card card in hand)
        {
            Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
        }
    }
}
