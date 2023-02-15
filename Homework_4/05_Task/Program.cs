using System.Text;

string text = "";

StringBuilder result = new StringBuilder();

while (!text.Contains("."))
{
    Console.WriteLine("Write your text: ");
    text = Console.ReadLine()!;

    if (!string.IsNullOrWhiteSpace(text)) result.Append(text + ", ");
    else Console.WriteLine("This string can't be empty");
}

Console.WriteLine($"Result: {result.ToString().TrimEnd(',', ' ')}");
