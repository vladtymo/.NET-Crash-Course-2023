namespace _13_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "C#", "polymorphism", "Collections", "Microsoft.NET" };
            List<string> dictionary = new List<String>();
            string maxLenght = words[0];
            for (int i = 1; i < words.Count(); ++i)
            {
                if (words[i].Length > maxLenght.Length) maxLenght = words[i];
            }
            dictionary.Add(maxLenght);
            for (int i = 0; i < words.Count(); ++i)
            {
                if (words[i].Length == maxLenght.Length && maxLenght != words[i]) dictionary.Add(words[i]);
            }
            dictionary.Sort();
            Console.WriteLine("List:");
            foreach (string str in words)
                Console.WriteLine(str);
            Console.WriteLine($"\nMaximum word length: {dictionary[0]}");
           

        }
    }
}