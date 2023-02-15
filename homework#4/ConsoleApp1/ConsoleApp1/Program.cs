///////////task1//////////////
Console.WriteLine("Enter string: ");
string str = Console.ReadLine();
string[] slova = str.Split(' ', ',', '.', '?', '!');
for (int i = slova.Length-1; i >= 0; i= i-1)
{
    Console.Write(slova[i] + " ");
}

///////////task2//////////////

int count;
Console.Write("Enter string: ");
string str1 = Console.ReadLine();
count = str1.Split(' ').Length;
Console.WriteLine(count-1);

///////////task3//////////////
///
