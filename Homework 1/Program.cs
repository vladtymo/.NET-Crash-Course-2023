Console.WriteLine("Task 1!!!");
int day, month, year;
Console.WriteLine("Enter day: ");
day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter month: ");
month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter year: ");
year = Convert.ToInt32(Console.ReadLine());
DateTime date1 = new DateTime(year, month, day);
Console.WriteLine($"\nDate:{date1.ToString("dd/MM/yyyy")}");

Console.WriteLine("Task 2!!!");
int a, b;
Console.WriteLine("Enter a (length): ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b (wigth): ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Area: " + (a * b));
Console.WriteLine("Perimetr: " + ((a + b) * 2));

Console.WriteLine("Task 3!!!");
int r;
Console.WriteLine("Enter radius: ");
r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Area: {Math.PI * r * r}");

Console.WriteLine("Task 4!!!");
int s, seconds, minutes, hours;
Console.WriteLine("Enter time on seconds: ");
s = Convert.ToInt32(Console.ReadLine());
hours = s / 3600;
minutes = (s - 3600 * hours) / 60;
seconds = s - minutes * 60 - hours * 3600;
DateTime time1 = new DateTime(1, 1, 1, hours, minutes, seconds);
Console.WriteLine($"Time = {time1.ToString("HH:mm:ss")}");

Console.WriteLine("Task 5!!!");
int year;
Console.WriteLine("Enter year: ");
year = Convert.ToInt32(Console.ReadLine());
if (year % 4 == 0 && year % 100 != 0 || year % 4 == 0 && year % 100 == 0 && year % 400 == 0) Console.WriteLine($"This year({year}) has 366 days");
else Console.WriteLine($"This year({year}) has 365 days");