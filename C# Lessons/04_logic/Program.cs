// ----------- logic operations: > < >= <= != ==
// combine logic conditions with: && (and) || (or) 
// opposite: !

Console.WriteLine($"Operator [<]: {10 > 5}");
Console.WriteLine($"Operator [!=]: {9! + 9}");
Console.WriteLine($"Operator [&&]: {45 > 20 && 45 < 100}");

Console.WriteLine($"Operator [&&]: {10 > 5 && 10 < 5}");
Console.WriteLine($"Operator [||]: {10 > 5 || 10 < 5}");

// ---------- if statement
int month = int.Parse(Console.ReadLine());

if (month >= 1 && month <= 12)
{
    Console.WriteLine("Congratulations!");
    Console.WriteLine("Your month is correct!");
}
else if (month == 0)
    Console.WriteLine("Month number starts from 1!");
else
    Console.WriteLine("Your month is incorrect!");
