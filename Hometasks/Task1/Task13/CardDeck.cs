namespace Task13
{
    public class CardDeck
    {
        private Queue<string> cards;

        public CardDeck()
        {
            cards = new Queue<string>();
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            // Fill the deck with cards
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    cards.Enqueue(rank + " of " + suit);
                }
            }
        }

        public void Shuffle()
        {
            // Convert the queue to a list
            List<string> cardList = new List<string>(cards);

            // Shuffle the list using Fisher-Yates shuffle algorithm
            Random random = new Random();
            int n = cardList.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string temp = cardList[k];
                cardList[k] = cardList[n];
                cardList[n] = temp;
            }

            // Convert the shuffled list back to a queue
            cards = new Queue<string>(cardList);
        }

        public string DealOneCard()
        {
            if (cards.Count > 0)
            {
                return cards.Dequeue();
            }
            else
            {
                return null;
            }
        }

        public List<string> DealCards(int count)
        {
            List<string> hand = new List<string>();
            for (int i = 0; i < count; i++)
            {
                string card = DealOneCard();
                if (card != null)
                {
                    hand.Add(card);
                }
                else
                {
                    break;
                }
            }
            return hand;
        }

        public List<List<string>> DealHands(int handCount, int cardsPerHand)
        {
            List<List<string>> hands = new List<List<string>>();
            for (int i = 0; i < handCount; i++)
            {
                List<string> hand = DealCards(cardsPerHand);
                hands.Add(hand);
            }
            return hands;
        }

        public void PrintDeck()
        {
            foreach(string card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}