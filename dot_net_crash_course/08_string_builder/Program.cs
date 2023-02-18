using System.Text;

// bad
string str = "Hello!";
str += "\n";
str += "It's me";

Console.WriteLine(str);

// good
StringBuilder builder = new StringBuilder();

Console.WriteLine("Length: " + builder.Length);
Console.WriteLine("Capacity: " + builder.Capacity);

builder.Append("Hello!");
builder.AppendLine();
builder.AppendLine("It's me");

Console.WriteLine(builder.ToString());

















