Console.WriteLine("Enter string :");
string str = Console.ReadLine()!;
str = str.Replace(" ", "");
float strLength = str.Length;
float lowerNum = 0;
float upperNum = 0;
for (int i = 0; i < str.Length; i++)
{
	if (str[i] == str.ToLower()[i])lowerNum++;
}
for (int i = 0; i < str.Length; i++)
{
    if (str[i] == str.ToUpper()[i]) upperNum++;
}
Console.WriteLine(lowerNum+"\n"+upperNum);
Console.WriteLine($"LowerNum = {(lowerNum/strLength)*100}% \nUpperNum = {(upperNum / strLength)*100}% \n");