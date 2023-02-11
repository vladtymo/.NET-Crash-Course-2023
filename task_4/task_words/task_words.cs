using System.Text;

string str=" ";
StringBuilder result = new StringBuilder();
Console.WriteLine("Enter word:");
str = Console.ReadLine();
result.Append($"{str}");
while (str[str.Length-1]!='.')
{
Console.WriteLine("Enter word:");
str=Console.ReadLine();
 result.Append($", {str}");
}
Console.WriteLine(result);
