namespace HW13
{
    internal class Program
    {
        static void Ex1()
        {
            List<string> words = new() { "trip", "deer", "similar", "collapse", "stunning", "recruit", "spit", "fraud", "tail", "jungle" };
            List<string> results = new List<string>();
            string result = "";
            foreach (string word in words)
            {
                Console.Write(word + " ");
                if (word.Length > result.Length)
                    result = word;
            }
            foreach (string word in words)
            {
                if (word.Length >= result.Length)
                    results.Add(word);
            }
            results.Sort();
            Console.WriteLine();
            Console.WriteLine(results[0]);
        }
        static void Main(string[] args)
        {
            Ex1();

        }
    }
}