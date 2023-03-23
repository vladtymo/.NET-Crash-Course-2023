namespace Tasks_13
{
	public class Program
	{
		public static char[] GetRandomWord()
		{
			int randomWordLength = new Random().Next(4, 20);
			char[] chars = Enumerable.Range(0, randomWordLength)
				.Select(x => (char)('a' + new Random().Next(26)))
				.ToArray();
			return chars;
		}
		public static void Task1()
		{
			List<string> words = new List<string>();
			for (int i = 0; i < 10; i++)
				words.Add(new string(GetRandomWord()));

			Console.WriteLine("Words: ");
			foreach (string word in words)
			{
				Console.WriteLine(word + $" {word.Length} , ");
			}
			string longestWord = "";
			for (int i = 0; i < words.Count; i++)
			{
				if (words[i].Length > longestWord.Length)
				{
					longestWord = words[i];
				}
			}
			Console.WriteLine("The longest word: " + longestWord);
		}
		public class PhoneBook <Tkey,Tvalue>//передбачити додавання, зміну, пошук та видалення записів.
		{
			public PhoneBook() 
			{
				PhoneNumbers = new Dictionary<Tkey, Tvalue>();
			}
			public Dictionary<Tkey,Tvalue> PhoneNumbers { get; set; }
		}
		public static void Task2()
		{
			PhoneBook<string, string> phoneBook = new PhoneBook<string, string>();

			phoneBook.PhoneNumbers.Add("John Smith", "(555) 123-4567");
			phoneBook.PhoneNumbers.Add("Jane Doe", "(555) 987-6543");

			foreach (KeyValuePair<string, string> entry in phoneBook.PhoneNumbers)
			{
				Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
			}

		}
		static void Main(string[] args)
		{
			Task1();
			Task2();

			Console.ReadLine();
		}
	}
}