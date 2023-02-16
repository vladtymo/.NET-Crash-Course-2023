//Логічні оператори
// < > >= <= != ==
// && (and) || (or)
// opposite: !

Console.WriteLine($"{10 > 5}");
Console.WriteLine($"{10 != 5}");
Console.WriteLine($"{10 > 5 || 10 < 5}");
Console.WriteLine($"{10 > 5 && 10 < 20}");

// if
int month = int.Parse(Console.ReadLine());

if (month >= 1 && month <= 12)
{
    Console.WriteLine("yes!");
}
else if (month == 0)
{
    Console.WriteLine("programmer!");
}
else
{
    Console.WriteLine("no!");
}
