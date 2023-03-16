List<string> list = new List<string>();

for (int i = 0; i < 4; ++i)
{
    Console.WriteLine("Enter a word: ");
    string word = Console.ReadLine();
    list.Add(word);
    
}
Console.WriteLine();
foreach (var y in list)
{
    if (y.Length == list.Max(x => x.ToString().Length))
    {
        Console.WriteLine(y);
        break;
    }
    
}
