// Task 1
Console.Write("Enter year: ");
int year = int.Parse(Console.ReadLine());
Console.Write("Enter month: ");
int month = int.Parse(Console.ReadLine());
Console.Write("Enter day: ");
int day = int.Parse(Console.ReadLine());
DateTime dt = new DateTime(year, month, day);
Console.WriteLine($"{dt.ToString("dd/MM/yyyy")}");

// Task 2
Console.Write("Enter first side: ");
int fSide = int.Parse(Console.ReadLine());
Console.Write("Enter second side: ");
int sSide = int.Parse(Console.ReadLine());
int P = (fSide * 2) + (sSide * 2);
int S = fSide * sSide;
Console.WriteLine($"P: {P}\nS: {S}");

// Task 3
Console.Write("Enter radius: ");
int r = int.Parse(Console.ReadLine());
Console.WriteLine($"S: {r*r}pi");

// Task 4
Console.Write("Enter time (seconds): ");
int seconds = int.Parse(Console.ReadLine());
TimeSpan time = TimeSpan.FromSeconds(seconds);
Console.WriteLine($"{time.ToString(@"hh\:mm\:ss")}");
