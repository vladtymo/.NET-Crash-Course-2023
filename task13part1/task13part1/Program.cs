namespace task13part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "bplle", "aplle", "aaple", "asd", "asdf" };

            List<string> longestWords = FindLongestWords(words);

            Console.WriteLine("Longest words:");
            foreach (string word in longestWords)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }

        static List<string> FindLongestWords(List<string> words)
        {
            int maxLength = words.Max(w => w.Length);
            List<string> longestWords = words.Where(w => w.Length == maxLength).OrderBy(w => w).ToList();

            return longestWords;
        }
    }
}