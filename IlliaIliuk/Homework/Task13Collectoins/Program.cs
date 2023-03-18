using System.Linq;
using System.Threading.Tasks;

namespace Task13Collectoins
{
    internal class Program
    {
        class PhoneBook
        {
            static Dictionary<string, string> phoneBook = new()
            {
                ["Illia"] = "0971620104",
                ["Ihor"] = "0971620100",
                ["Liliana"] = "0963865945",
                ["Oksana"] = "0651535565",
            };

            static public void SearchAbonent(string key)
            {
                if (phoneBook.TryGetValue(key, out string value))
                {
                    Console.WriteLine($"Get phone by name {key} ---> {value}");
                }
                else
                {
                    Console.WriteLine($"Get phone by name {key} impossible(not found)");
                }
            }
            static public void AddAbonent(string key, string value)
            {
                if (phoneBook.TryAdd(key, value))
                {
                    Console.WriteLine("New abonent added successfully\n");
                }
                else
                {
                    Console.WriteLine("New anonent not added\n");
                }

            }
            static public void RemoveAbonent(string key)
            {
                phoneBook.Remove(key);
                Console.WriteLine("Abonent removed\n");
            }
            static public void PrintDirecrory()
            {
                foreach (var p in phoneBook)
                {
                    Console.WriteLine(p);
                }
            }
        }
        public static void Task1()
        {
            List<string> list = new List<string>();
            list.Add("qaz");
            list.Add("qazw");
            list.Add("qazws");
            list.Add("qazwa");
            list.Add("qazxx");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            int MaxLength = list.Max(x => x.Length);

            String result = list.Where(x => x.Length == MaxLength).First();

            Console.WriteLine("First task result: " + result);
        }
        public static void Task2Test() 
        {
            string name;
            string number;
            bool go = true;
            while (go == true)
            {
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Search Abonent");
                Console.WriteLine("2 - Add Abonent");
                Console.WriteLine("3 - Remove Abonent");
                Console.WriteLine("4 - Print Direcrory\n");
                int p = Convert.ToInt32(Console.ReadLine());
                switch (p)
                {
                    case 1:
                        Console.Write("Searched Abonent - ");
                        name = Console.ReadLine();
                        PhoneBook.SearchAbonent(name);
                        break;
                    case 2:
                        Console.Write("Name - ");
                        name = Console.ReadLine();
                        Console.Write("Number - ");
                        number = Console.ReadLine();
                        PhoneBook.AddAbonent(name, number);
                        break;
                    case 3:
                        Console.Write("Remove Abonent - ");
                        name = Console.ReadLine();
                        PhoneBook.RemoveAbonent(name);
                        break;
                    case 4:
                        PhoneBook.PrintDirecrory();
                        break;
                    case 0:
                        go = false;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("_________________________");
            }
        }
        public static void Task3Test()
        {
            CardDeck cardDeck = new CardDeck();
            cardDeck.Shuffle();
            var player1 = cardDeck.Deal(6);
            var player2 = cardDeck.Deal(6);
            var player3 = cardDeck.Deal(6);

            foreach (var item in player1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in player3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in player2)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine();
            //Task2Test();
            Console.WriteLine();
            Task3Test();
        }
    }
}