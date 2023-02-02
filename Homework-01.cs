// Завдання:
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// 1 - Користувач вводить поточну дату (рік, місяць, день), відобразити її у форматі "DD/MM/YYYY".

Console.Write("Enter year: ");
string year = Console.ReadLine();

Console.Write("Enter mounth: ");
string mounth = Console.ReadLine();

Console.Write("Enter day: ");
string day = Console.ReadLine();

Console.WriteLine($"Date is {day}/{mounth}/{year}");

// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// 2 - Користувач вводить 2 сторони прямокутника. Вивести на екран його периметр та площу.

Console.Write("Enter first side of rectangle: ");
string answer1 = Console.ReadLine();
int side1 = Int32.Parse(answer1);

Console.Write("Enter second side of rectangle: ");
string answer2 = Console.ReadLine();
int side2 = Int32.Parse(answer2);

Console.WriteLine($"Squere of rectangle is {side1 * side2}");

// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// 3 - Користувач вводить радіус кола, програма повинна знайти його площу.

Console.Write("Enter circle radius: ");
string radiusAnswer = Console.ReadLine();
int radius = Int32.Parse(radiusAnswer);
double Pi = Math.PI;

Console.WriteLine($"Circle squere is {Pi * Math.Pow(radius, 2)}");

// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// 4 - Користувач вводить час в секундах, відобразити його у вигляді: HH: MM: SS.

Console.Write("Enter time in seconds: ");
string secondsAnswer = Console.ReadLine();
int secondsTotal = Int32.Parse(secondsAnswer);

int hours = secondsTotal / 3600;
int minutes = ((secondsTotal - (hours * 3600)) / 60);
int seconds = ((secondsTotal - (hours * 3600) - (minutes * 60)));
Console.WriteLine($"{hours}:{minutes}:{seconds}");

// * 5 - Користувач вводить рік, відобразити скільки днів в цьому році.

// * - додаткове завдання

