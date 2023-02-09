string slova = Console.ReadLine();
string[] words = slova.Split(new[] { ' ', '.', '?', ',' }, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"Words {words.Length}");
Array.Reverse(words);

foreach (var w in words)
{
    Console.WriteLine(w);
}


