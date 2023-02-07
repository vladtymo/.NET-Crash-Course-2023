// --------------- data types
Console.WriteLine("Data types...");

/* simple types: 
 * - integers: short: 2, int: 4, long: 8
 * - floating-point: float: 4, dobule: 8, decimal: 16
 * - symbols: char, string
 * - logic: bool
 */

Console.WriteLine("\tLiterals:");
// interpolation: $"...{expression}..."
Console.WriteLine($"Value: 123, type: {123.GetType()}");
Console.WriteLine($"Value: 123L, type: {123L.GetType()}");
Console.WriteLine($"Value: 55.6, type: {55.6.GetType()}");
Console.WriteLine($"Value: 55.6F, type: {55.6F.GetType()}");
Console.WriteLine($"Value: 55.6M, type: {55.6M.GetType()}");
Console.WriteLine($"Value: 100000999999999999, type: {100000999999999999.GetType()}");
Console.WriteLine($"Value: '#', type: {'#'.GetType()}");
Console.WriteLine($"Value: \"Hello\", type: {"Hello".GetType()}");
Console.WriteLine($"Value: true, type: {true.GetType()}");

// create variable: type name = value;
// variable naming: camelCaseConvension
float width = 125.5F;
float height = 220.5F;
float area = width * height;
string color = "Brown";
string material = "Wood";
bool isOpen = true;

double a = 5 / (double)2;
Console.WriteLine($"Result: {a}");

Console.WriteLine($"Door info: {area / 10000}m^2 {color} made of {material} with status {isOpen}");

// ----------- ariphmetic operations: + - * / %
// ----------- modify value: += -= *= /= %=
// ----------- increment/decrement: ++ --
int c = 10;
int result = c++;
Console.WriteLine(c);      // 11
Console.WriteLine(result); // 10

// ----------- type converting
// string parse using type.Parse() method
double doubleValue = double.Parse("55.2");
int intValue = int.Parse("876");

Console.WriteLine($"Double value: {doubleValue}");
Console.WriteLine($"Int value: {intValue}");

// type converting using Convert class
decimal decimalValue = Convert.ToDecimal(doubleValue);
Console.WriteLine($"Int value: {intValue}");

// ----------- practical tasks -----------
// task 4:
Console.WriteLine("\n----------------- TASK 4 -----------------");
Console.Write("Enter seconds: ");
int seconds = int.Parse(Console.ReadLine()); // 8405 -> 2h 20m 5s

const int secondsPerHour = 3600;
const int secondsPerMinute = 60;

//secondsPerHour += 1; // cannot modify constants value

int hours = seconds / secondsPerHour;

seconds -= hours * secondsPerHour;              // 1205
int minutes = seconds / secondsPerMinute;

seconds -= minutes * secondsPerMinute;          // 5

Console.WriteLine($"Time: {hours}:{minutes}:{seconds}");
