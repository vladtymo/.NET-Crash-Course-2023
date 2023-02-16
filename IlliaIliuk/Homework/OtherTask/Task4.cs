////1
/*
Console.Write("Enter text: ");
string str = Console.ReadLine()!;

string[] splitStr = str.Split(' ');

string reverseStr = String.Join(' ', splitStr.Reverse());

Console.WriteLine(reverseStr);
*/


////2
/*
Console.Write("Enter text: ");
string str = Console.ReadLine()!;
int count = 0;

for (int i = 0; i < str.Length; i++)
{
	if (str[i] == ' ')
	{
		count++;
	}
}

Console.WriteLine($"User entered {count} \' \'.");
*/

////3
/*
Console.Write("Enter text: ");
string str = Console.ReadLine()!;
int countLower = 0;
int countUpper = 0;

for (int i = 0; i < str.Length; i++)
{
	if (Char.IsLetter(str[i]))
	{
		if (Char.IsLower(str[i]))
		{
            countLower++;
		}
		else
		{
			countUpper++;
        }
	}
}

Console.WriteLine($"User entered {countLower * 100 / str.Length} lower letters and {countUpper * 100 / str.Length} upper letters .");
*/

////4
/*
Console.Write("Enter text: ");
string str = Console.ReadLine()!;

string[] splitStr = str.Split(' ');

string abbreviation = "";

for (int i = 0; i < splitStr.Length; i++)
{
    abbreviation += splitStr[i][0];
}
 
Console.WriteLine(abbreviation.ToUpper());
*/

////5
/*
Console.Write("Enter words: ");
string str = "";

do
{
	if (str.Length == 0)
	{
        str += String.Join(", ", Console.ReadLine());
    }
	str +=  ", " + String.Join(", ", Console.ReadLine());
	
} while (str.Last() != '.');

Console.WriteLine(str);
*/

////6

//Console.Write("Enter text: ");
//string str = Console.ReadLine()!;


//for (int i = 1; i < str.Length-1; i++)
//{
//	if (str[i] == ' ' & str[i-1] == '.' & str[i+1] == '.')
//	{
//		str = str.Remove(i,1);
//	}
//}

//Console.WriteLine(str);