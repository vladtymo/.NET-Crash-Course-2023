namespace task13part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardDeck deck = new CardDeck();

            bool continueRunning = true;

            while (continueRunning)
            {
                Console.WriteLine("Enter a command (shuffle, deal, deal6, print, exit):");
                string command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "shuffle":
                        deck.ShuffleDeck();
                        Console.WriteLine("Deck shuffled");
                        break;

                    case "deal":
                        string card = deck.DealCard();
                        if (card != null)
                        {
                            Console.WriteLine($"Card dealt: {card}");
                        }
                        break;

                    case "deal6":
                        deck.DealCards(6);
                        break;

                    case "print":
                        deck.PrintDeck();
                        break;

                    case "exit":
                        continueRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }
        class CardDeck
        {
            private Queue<string> _cards = new Queue<string>();

            public CardDeck()
            {
                InitializeDeck();
            }

            private void InitializeDeck()
            {
                string[] suits = { "Spades", "Hearts", "Clubs", "Diamonds" };
                string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

                foreach (string suit in suits)
                {
                    foreach (string value in values)
                    {
                        _cards.Enqueue($"{value} of {suit}");
                    }
                }
            }

            public void ShuffleDeck()
            {
                List<string> cardsList = new List<string>(_cards);
                Random random = new Random();

                for (int i = 0; i < cardsList.Count; i++)
                {
                    int randomIndex = random.Next(i, cardsList.Count);
                    string temp = cardsList[i];
                    cardsList[i] = cardsList[randomIndex];
                    cardsList[randomIndex] = temp;
                }

                _cards = new Queue<string>(cardsList);
            }

            public string DealCard()
            {
                if (_cards.Count == 0)
                {
                    Console.WriteLine("The deck is empty");
                    return null;
                }

                return _cards.Dequeue();
            }

            public void DealCards(int numberOfCards)
            {
                if (_cards.Count == 0)
                {
                    Console.WriteLine("The deck is empty");
                    return;
                }

                if (numberOfCards > _cards.Count)
                {
                    numberOfCards = _cards.Count;
                }

                for (int i = 0; i < numberOfCards; i++)
                {
                    Console.WriteLine(DealCard());
                }
            }

            public void PrintDeck()
            {
                Console.WriteLine(string.Join(", ", _cards));
            }
        }
    }
}