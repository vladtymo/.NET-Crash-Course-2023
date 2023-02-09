using System.Text;

// bad
string str = "My name is Vlad!";
str += "\n";
str += "The last line!";

// good
StringBuilder builder = new StringBuilder();

Console.WriteLine("Length: " + builder.Length);
Console.WriteLine("Capacity: " + builder.Capacity);

builder.Append("My name is Vlad!");
builder.AppendLine();
builder.AppendLine("The last line!");

Console.WriteLine("Length: " + builder.Length);
Console.WriteLine("Capacity: " + builder.Capacity);

Console.WriteLine("Reuslt:\n" + builder.ToString());
