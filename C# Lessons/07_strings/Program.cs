// String class - reference type
// nullable string type
string? nullStr = null;

// ------------------------- constructors
string str = "Hello, world!";
//String str = new String("Hello, world!");

string line = new string('#', 10);
Console.WriteLine(line);

char[] characters = { 'H', 'e', 'l', 'l', 'o' };

string str2 = new string(characters, 2, 2);
Console.WriteLine(str2);

string result = "Hi! " + str + "..."; // string.Concat()
Console.WriteLine("Result: " + result);

Console.WriteLine("Element at 4 index: " + str[4]); // 0

// ------------------------- methods
if (str.Contains("world"))
    Console.WriteLine("String contains 'world' substring");

if (str.StartsWith('H')) Console.WriteLine("String starts with 'H'");
if (str.EndsWith('P')) Console.WriteLine("String ends with 'P'");

Console.WriteLine($"Index of comma: {str.IndexOf(',')}");

Console.WriteLine("Replaced: " + str.Replace(' ', '-'));
Console.WriteLine("Substrign: " + str.Substring(0, 5));

Console.WriteLine("Upper: " + str.ToUpper());
Console.WriteLine("Lower: " + str.ToLower());

Console.WriteLine("Original: " + str);

// white-space symbols: '\t' '\n' ' '

Console.Write("Enter your email: ");
string email = Console.ReadLine()!;

Console.WriteLine($"Original email: |{email}|");
Console.WriteLine($"Trimmed email: |{email.Trim()}|"); // TrimStart(), TrimEnd

// ------- split() and join() example
str = "Hi, there! How are you? Super-puper.";

string[] words = str.Split(new[] { ' ', ',', '.', '?', '!', ';' }, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"Words: {words.Length}");
foreach (var w in words) Console.WriteLine(w);

string joined = string.Join(" / ", words);
Console.WriteLine("Joined string: " + joined);