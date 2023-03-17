using System;
using System.Collections.Generic;
enum Suit{
    Hearts,
    Diamonds,
    Clubs,
    Spades
}
enum Rank{
    Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
}
class Card{
    public Suit Suit { get; }
    public Rank Rank { get; }
    public Card(Suit suit, Rank rank){
        Suit = suit;
        Rank = rank;
    }
    public override string ToString(){
        return $"{Rank} of {Suit}";
    }
}
class Deck{
    private Queue<Card> _cards;
    public Deck(){
        _cards = new Queue<Card>();
        InitializeDeck();
        Shuffle();
    }
    private void InitializeDeck(){
        foreach (Suit suit in Enum.GetValues(typeof(Suit))){
            foreach (Rank rank in Enum.GetValues(typeof(Rank))){
                _cards.Enqueue(new Card(suit, rank));
            }
        }
    }
    public void Shuffle(){
        List<Card> tempList = new List<Card>(_cards);
        Random random = new Random();
        int n = tempList.Count;
        while (n > 1){
            n--;
            int k = random.Next(n + 1);
            Card temp = tempList[k];
            tempList[k] = tempList[n];
            tempList[n] = temp;
        }
        _cards = new Queue<Card>(tempList);
    }
    public Card Draw(){
        if (_cards.Count == 0){
            throw new InvalidOperationException("The deck is empty.");
        }
        return _cards.Dequeue();
    }
    public List<Card> Deal(int count){
        List<Card> dealtCards = new List<Card>();
        for (int i = 0; i < count; i++){
            if (_cards.Count == 0){
                break;
            }
            dealtCards.Add(_cards.Dequeue());
        }
        return dealtCards;
    }
}
class Program{
    static void Main(string[] args){
        Deck deck = new Deck();
        Console.WriteLine("Draw one card:");
        Console.WriteLine(deck.Draw());
        Console.WriteLine("\nDeal six cards:");
        List<Card> dealtCards = deck.Deal(6);
        foreach (Card card in dealtCards){
            Console.WriteLine(card);
        }
        Console.WriteLine("\nShuffle and deal six cards:");
        deck.Shuffle();
        dealtCards = deck.Deal(6);
        foreach (Card card in dealtCards){
            Console.WriteLine(card);
        }
    }
}
