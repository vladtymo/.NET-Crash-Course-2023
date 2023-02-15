using System;

Console.WriteLine("Write your words");
string words = Console.ReadLine()!;

//char[] arr = words.ToCharArray();
//Array.Reverse(arr);
//string res = new string(arr);

//Console.WriteLine($"Reversed result: {res}");

string[] words2 = words.Split(' ');
for(int i = words2.Length - 1; i >= 0; i--)
{
    Console.Write(words2[i]+"\t");
}