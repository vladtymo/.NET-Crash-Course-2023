Console.WriteLine("Enter ur number:");
var s = Console.ReadLine();

for (int i = 0; i < s.Length / 2; ++i)
    if (s[i] != s[s.Length - 1 - i])  Console.WriteLine("NO, this number isn't a pakindrome!");
    else Console.WriteLine("YES, this number is a palindrome!");