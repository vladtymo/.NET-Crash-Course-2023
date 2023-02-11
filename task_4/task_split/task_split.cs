Console.WriteLine("Enter string :");
string line = Console.ReadLine()!;
string[] words = line.Split(new[] { ' ', ',', '.', '!', '?' },StringSplitOptions.RemoveEmptyEntries);
for (int i = words.Length-1; i >= 0; i--)
{
    Console.Write(words[i]+" ");
}
