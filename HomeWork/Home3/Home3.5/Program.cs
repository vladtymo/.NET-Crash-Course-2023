using System.Diagnostics.Tracing;
using System.Text;

StringBuilder builder = new StringBuilder();
Console.WriteLine("Введіть слова");
do
{
    string word = Console.ReadLine();
    builder.Append(word+", ");

    Console.WriteLine("Replaced: " + str.Replace(' ', '-'));
    if (word.EndsWith("."))
    {

        break;
    };

} while (1==1);

Console.WriteLine("Reuslt:\n" + builder.ToString());