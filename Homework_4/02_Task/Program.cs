Console.WriteLine("Write your words");
string words = Console.ReadLine()!;

char[] arr = words.ToCharArray();
int counter = 0;
for (int i = 0;i < arr.Length; ++i)
{
    if (arr[i] == ' ') ++counter;
}
Console.WriteLine($"Amount of white-spaces: {counter}");