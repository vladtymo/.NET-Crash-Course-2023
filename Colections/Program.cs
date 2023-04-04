using System;
using System.Collections.Generic;
using System.Linq;

class HanoiTower
{
    public Stack<int> Disks { get; }
    public HanoiTower()
    {
        Disks = new Stack<int>();
    }
}
    enum Suit
{
    Hearts, Diamonds, Clubs, Spades
}
enum Rank
{
    Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
}
class Card
{
    public Suit Suit { get; }
    public Rank Rank { get; }
    public Card(Suit suit, Rank rank)
    {
        Suit = suit;
        Rank = rank;
    }
    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }
}
class Deck
{
    private Queue<Card> _cards;
    public Deck()
    {
        _cards = new Queue<Card>();
        InitializeDeck();
        Shuffle();
    }
    private void InitializeDeck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                _cards.Enqueue(new Card(suit, rank));
            }
        }
    }
    public void Shuffle()
    {
        List<Card> tempList = new List<Card>(_cards);
        Random random = new Random();
        int n = tempList.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            Card temp = tempList[k];
            tempList[k] = tempList[n];
            tempList[n] = temp;
        }
        _cards = new Queue<Card>(tempList);
    }
    public Card Draw()
    {
        if (_cards.Count == 0)
        {
            throw new InvalidOperationException("Is empty");
        }
        return _cards.Dequeue();
    }
    public List<Card> Deal(int count)
    {
        List<Card> dealtCards = new List<Card>();
        for (int i = 0; i < count; i++)
        {
            if (_cards.Count == 0)
            {
                break;
            }
            dealtCards.Add(_cards.Dequeue());
        }
        return dealtCards;
    }
}
class PhoneBook
{
    private Dictionary<string, string> _entries;
    public PhoneBook()
    {
        _entries = new Dictionary<string, string>();
    }
    public void Add(string name, string phoneNumber)
    {
        if (!_entries.TryAdd(name, phoneNumber))
        {
            Console.WriteLine($"'{name}' already exists");
        }
    }
    public void Change(string name, string newPhoneNumber)
    {
        if (_entries.ContainsKey(name))
        {
            _entries[name] = newPhoneNumber;
        }
        else
        {
            Console.WriteLine($"No found '{name}'");
        }
    }
    public string Search(string name)
    {
        if (_entries.TryGetValue(name, out string phoneNumber))
        {
            return phoneNumber;
        }
        else
        {
            Console.WriteLine($"No found '{name}'");
            return null;
        }
    }
    public void Delete(string name)
    {
        if (!_entries.Remove(name))
        {
            Console.WriteLine($"No found '{name}'");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        //task1
        Console.WriteLine("____________________task1____________________");
        {
            List<string> words = new List<string>{
            "world", "sandwich", "time", "next", "finish", "fishing", "computer"
        };
            string maxLengthWord = words
                .OrderBy(word => word)
                .OrderByDescending(word => word.Length)
                .FirstOrDefault();
            if (maxLengthWord != null)
            {
                Console.WriteLine($"The maximum length word: {maxLengthWord}");
            }
            else
            {
                Console.WriteLine("Is empty.");
            }
        }
        //task2
        Console.WriteLine("____________________task2____________________");
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.Add("Evgen", "380987654321");

            phoneBook.Add("Artem", "12345678901");
            Console.WriteLine($"Evgen's phone number: {phoneBook.Search("Evgen")}");
            phoneBook.Change("Artem", "380988877722");
            Console.WriteLine($"Artem new phone number: {phoneBook.Search("Artem")}");
            phoneBook.Add("artem", phoneBook.Search("Artem"));
            phoneBook.Delete("Artem");
            phoneBook.Search("artem");
        }
        //task3
        Console.WriteLine("____________________task3____________________");
        {
            Deck deck = new Deck();
            Console.WriteLine("Draw one:");
            Console.WriteLine(deck.Draw());
            Console.WriteLine("\nDeal six:");
            List<Card> dealtCards = deck.Deal(6);
            foreach (Card card in dealtCards)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine("\nShuffle and deal six:");
            deck.Shuffle();
            dealtCards = deck.Deal(6);
            foreach (Card card in dealtCards)
            {
                Console.WriteLine(card);
            }
        }
        //task4
        Console.WriteLine("____________________task4____________________");
        {
            {
                int numDisks = 3;
                HanoiTower[] towers = new HanoiTower[3];
                for (int i = 0; i < 3; i++) towers[i] = new HanoiTower();
                for (int i = numDisks; i >= 1; i--) towers[0].Disks.Push(i);
                SolveHanoi(numDisks, towers, 0, 1, 2);
            }
            static void SolveHanoi(int numDisks, HanoiTower[] towers, int from, int to, int aux)
            {
                if (numDisks == 1)
                {
                    int disk = towers[from].Disks.Pop();
                    towers[to].Disks.Push(disk);
                    Console.WriteLine($"Move disk {disk} from tower {from + 1} to tower {to + 1}");
                    return;
                }
                SolveHanoi(numDisks - 1, towers, from, aux, to);
                SolveHanoi(1, towers, from, to, aux);
                SolveHanoi(numDisks - 1, towers, aux, to, from);
            }
        }
    }
}
