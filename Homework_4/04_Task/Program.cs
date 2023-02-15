internal class Program
{
    private static void Main(string[] args)
    {
        void Abbreviation(string s)
        {
            string[] parts = s.Split(new char[] { ' ', '.', ',' },
                                StringSplitOptions.RemoveEmptyEntries |
                                StringSplitOptions.TrimEntries);
            string result = String.Concat(parts.Select(part => char.ToUpper(part[0])));
            Console.WriteLine(result);

        }
        Abbreviation("kj sd xc");
    }
}