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