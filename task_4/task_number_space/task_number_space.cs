Console.WriteLine("Enter string:");
string str = Console.ReadLine()!;
Console.WriteLine($"Number space:{(str.Length)- str.Replace(" ","").Length}");