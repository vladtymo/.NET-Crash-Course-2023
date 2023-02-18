string? strNull = null;

//--------------------- constructors

string str1 = "Hello, world!";
String str2 = new string("Hello, world!");

string strCustom = new string('#', 10);
Console.WriteLine(strCustom);

char[] charArray = { 'H', 'e', 'l', 'l', 'o' };
string strArray1 = new string(charArray);
Console.WriteLine(strArray1);
string strArray2 = new string(charArray,0,4);
Console.WriteLine(strArray2);

//--------------------- methods

if (str1.Contains("world"))
{
    Console.WriteLine("Yes");
}

if (str1.StartsWith("Hel"))
{
    Console.WriteLine("Yes");
}

if (str1.EndsWith('!'))
{
    Console.WriteLine("Yes");
}

Console.WriteLine("Index of comma is " + str1.IndexOf(','));

Console.WriteLine("Replace " + str1.Replace('o','0'));

Console.WriteLine("Substring " + str1.Substring(0,5));

Console.WriteLine("ToUpper " + str1.ToUpper());
Console.WriteLine("ToLower " + str1.ToLower());

Console.WriteLine("String still being original " + str1);

// white-space symbols: '\t' '\n' ' '
// Trim TrimStart TrimEnd

Console.WriteLine("Enter the text: ");
string text = Console.ReadLine()!;

Console.WriteLine($"No Trim text |{text}| \n Trim text is |{text.Trim()}|");

// Split on words
string str3 = "Hello, it's me! I'm do smth";
string[] strArray3 = str3.Split(' ');
foreach(string i in strArray3)
{
    Console.WriteLine(i);
}
string[] strArray4 = str3.Split(new[] {' ', ',', '.', '!'}, StringSplitOptions.RemoveEmptyEntries);
foreach (string i in strArray4)
{
    Console.WriteLine(i);
}

// Join on words
string strJoined = string.Join(" / ", strArray4);
Console.WriteLine(strJoined);







