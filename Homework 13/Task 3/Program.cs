namespace _13_CollectionQueue
{
    internal class Program
    {
        class Card
        {
            Queue<string> queue=new();
            public void Push(string card)
            {
                queue.Enqueue(card);
                Console.WriteLine($"Pushed card: {card}");
            }
            public void RecieveLast()
            {
                Console.WriteLine($"Last item: {queue.Peek()}");
            }
            public void DealSixCards()
            {
                if (queue.Count > 0)
                for(int i=0;i<6;++i)
                {
                   Console.WriteLine($"Take card {i} with name: {queue.Dequeue()}");
                }
            }
            public void ShufflingCards()
            {
                string[] arr= queue.ToArray();
                Random rnd=new Random();
                for(int i=0;i<arr.Length;++i)
                {
                    int j = rnd.Next(i, arr.Length);
                    string x = arr[i];
                    arr[i] = arr[j];
                    arr[j] = x;
                }
                queue.Clear();
                for(int i=0;i<arr.Length; ++i)
                {
                    queue.Enqueue(arr[i]);
                }
                Console.WriteLine("\nShuffle the cards:");
                int cardOrder = 1;
                foreach(string card in queue) 
                {
                    Console.WriteLine($"Card {cardOrder} = {card}");
                    ++cardOrder;
                }
            }
        }
        static void Main(string[] args)
        {
            Card card=new Card();
            card.Push("6");
            card.Push("7");
            card.Push("8");
            card.Push("9");
            card.Push("10");
            card.Push("Jack");
            card.Push("Queen");
            card.Push("King");
            card.Push("Ace");

            card.ShufflingCards();
            card.RecieveLast();
            card.DealSixCards();

            

        }
    }
}