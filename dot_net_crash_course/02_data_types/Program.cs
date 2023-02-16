/*
 * simple types:
 * integers: short - 2, int - 4, long - 8
 * floating-point: float - 4, double - 8, decimal - 16
 * symbols: char, string
 * logic: bool
 */
// create var: type name = value;

//Літерали
float width1 = 125.5f;
double width2 = 125.5d;
decimal width3 = 125.5m;

//Інтерполяція
Console.WriteLine($"width1 is {width1}");
Console.WriteLine("width1 is " + width1);

//Перетворення типів
float a = 5 / 2f;
float b = 5 / (float)2;
float c = 5f / 2;
float d = (float)5 / 2;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);

//GetType
Console.WriteLine((2+4).GetType());
Console.WriteLine(a.GetType());

// Арифметичні оператори
// + - * / %
// модифікація значень += -= *= /= %=
// інкремент/декркмент ++ --


