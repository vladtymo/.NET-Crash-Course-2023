using System;
using System.Collections.Generic;

internal class Program
{
    class PhoneBook{
        private Dictionary<string, string> phoneNumbers;

        public PhoneBook()
        {
            phoneNumbers = new Dictionary<string, string>();
        }

        public void Add(string name, string phoneNumber)
        {
            if (!phoneNumbers.ContainsKey(name))
            {
                phoneNumbers.Add(name, phoneNumber);
            }
            else
            {
                phoneNumbers[name] = phoneNumber;
            }
        }

        public bool Remove(string name)
        {
            return phoneNumbers.Remove(name);
        }

        public bool Find(string name)
        {
            return phoneNumbers.ContainsKey(name);
        }

        public string GetPhoneNumber(string name)
        {
            if (phoneNumbers.TryGetValue(name, out string phoneNumber))
            {
                return phoneNumber;
            }
            else
            {
                return null;
            }
        }

        public void PrintAll()
        {
            foreach (KeyValuePair<string, string> kvp in phoneNumbers)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
    class Cards{
        private Queue<string> cards;
        public Cards(){
            cards = new Queue<string>();
            string[] suits = {"♥","♦","♣","♠"};
            string[] imgCards = {"J","Q","K","A"};
            for(int i = 2; i <=10;i++){
                for(int j = 0;j<suits.Count();j++){
                    cards.Enqueue( i.ToString() + suits[j]);
                }
            }
            for(int i = 0; i < imgCards.Count();i++){
                for(int j = 0;j< suits.Count();j++){
                    cards.Enqueue( imgCards[i]+ suits[j]);
                }
            }
        }
        public void ShowDeck(){
            foreach (string card in cards)
            {
                if(card[card.Length - 1] == '♥' || card[card.Length - 1] == '♦'){
                    Console.ForegroundColor = ConsoleColor.Red;
                }else{
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(card);
            }
        }
        public void GetCard(){
            if(cards.Peek()[cards.Peek().Length - 1] == '♥' || cards.Peek()[cards.Peek().Length - 1] == '♦'){
                Console.ForegroundColor = ConsoleColor.Red;
            }else{
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.Write(cards.Dequeue() + "\t");
        }
        public void ShuffleDeck(){
            List<string> myList = cards.ToList();
            Random rand = new Random();
            int n = myList.Count;
            while (n > 1) {
                n--;
                int k = rand.Next(n + 1);
                string temp = myList[k];
                myList[k] = myList[n];
                myList[n] = temp;
            }
            cards = new Queue<string>(myList);
        }
        public void DealCards(){
            System.Console.WriteLine(cards.Count());
            System.Console.WriteLine((cards.Count() - cards.Count()%6)/6);
            int k = (cards.Count() - cards.Count()%6)/6;
            for(int i = 1;i<=k;i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    this.GetCard();
                }
                Console.WriteLine();    
            }
            
        }
    }
    
    private static void Main(string[] args)
    {
        //Problem1();
        //Problem2();
        //Problem3();
        Problem4();
    }
    private static void Problem1(){
        List<string> strList = new List<string>(){"12","abcde","123","bbcde"};

        List<string> sortedList = strList.OrderByDescending(e => e.Length).ThenBy(e => e).ToList();

        System.Console.WriteLine(sortedList[0]);
    }
    private static void Problem2(){
        PhoneBook phoneBook = new PhoneBook();
        phoneBook.Add("Maks","0938502857");
        phoneBook.Add("John","0738350468");
        phoneBook.Add("Yarmolenko","777777777");
        phoneBook.PrintAll();
        phoneBook.Remove("John");
        phoneBook.PrintAll();
        System.Console.WriteLine(phoneBook.GetPhoneNumber("Yarmolenko"));
    }
    private static void Problem3(){
        Cards deck = new Cards();
        deck.ShuffleDeck();
        deck.DealCards();
        //deck.ShowDeck();
    }


    public static void Checkdisk1todisk2(Stack<int> A,Stack<int> B){
        if(A.Count() == 0 && B.Count() == 0){return;}

        if(B.Count() == 0 || (A.Count() !=0  && A.Peek() < B.Peek()) ){
            B.Push(A.Pop());
        }else{
            A.Push(B.Pop());
        }
    }
    public static bool CheckSortedDisk(Stack<int> A,int n){
        if(A.Count() == n){return true;}
        return false;
    }

    public static void Problem4(){
        Stack<int> A = new Stack<int>(new []{4,3,2,1});
        Stack<int> B = new Stack<int>();
        Stack<int> C = new Stack<int>();
        // A <-> B  || A <-> C || B<->C
        int i = 1;
        do{
            Checkdisk1todisk2(A,B);
            Checkdisk1todisk2(A,C);
            Checkdisk1todisk2(B,C);
            System.Console.WriteLine("-----------"+i+"-----------");
            System.Console.Write("A: ");
            foreach (var a in A)
            {
                System.Console.Write(a);    
            }
            System.Console.WriteLine();
            System.Console.Write("B: ");
            foreach (var b in B)
            {
                System.Console.Write(b);    
            }
            System.Console.WriteLine();
            System.Console.Write("C: ");
            foreach (var c in C)
            {
                System.Console.Write(c);    
            }
            System.Console.WriteLine();
            ++i;
        }while(!CheckSortedDisk(C,4) && !CheckSortedDisk(B,4) && !CheckSortedDisk(A,4));
            


        
        
        
    }
}