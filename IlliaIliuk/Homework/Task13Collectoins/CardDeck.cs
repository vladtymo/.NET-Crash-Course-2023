using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13Collectoins
{
    public class CardDeck
    {
        private Queue<string> cards;

        public CardDeck()
        {
            cards = new Queue<string>();
            foreach (var suit in new[] { "Hearts", "Diamonds", "Clubs", "Spades" })
            {
                for (int rank = 2; rank <= 10; rank++)
                {
                    cards.Enqueue($"{rank} of {suit}");
                }
                cards.Enqueue($"Jack of {suit}");
                cards.Enqueue($"Queen of {suit}");
                cards.Enqueue($"King of {suit}");
                cards.Enqueue($"Ace of {suit}");
            }
        }

        public void Shuffle()
        {
            var cardsList = cards.ToList();
            var rnd = new Random();
            for (int i = 0; i < cardsList.Count; i++)
            {
                int j = rnd.Next(i, cardsList.Count);
                var temp = cardsList[i];
                cardsList[i] = cardsList[j];
                cardsList[j] = temp;
            }
            cards = new Queue<string>(cardsList);
        }

        public void Reset()
        {
            cards.Clear();
            foreach (var suit in new[] { "Hearts", "Diamonds", "Clubs", "Spades" })
            {
                for (int rank = 2; rank <= 10; rank++)
                {
                    cards.Enqueue($"{rank} of {suit}");
                }
                cards.Enqueue($"Jack of {suit}");
                cards.Enqueue($"Queen of {suit}");
                cards.Enqueue($"King of {suit}");
                cards.Enqueue($"Ace of {suit}");
            }
        }

        public List<string> Deal(int count)
        {
            var dealtCards = new List<string>();
            for (int i = 0; i < count; i++)
            {
                if (cards.Count == 0)
                {
                    throw new InvalidOperationException("Deck is empty!");
                }
                dealtCards.Add(cards.Dequeue());
            }
            return dealtCards;
        }

        public string Draw()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("Deck is empty!");
            }
            return cards.Dequeue();
        }

        public void AddCards(IEnumerable<string> newCards)
        {
            foreach (var card in newCards)
            {
                cards.Enqueue(card);
            }
        }
    }
}
