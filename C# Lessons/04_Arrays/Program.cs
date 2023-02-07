// -=-=-=-=-=-=-=-=-=- Arrays -=-=-=-=-=-=-=-=-=-

// ----------- one-dimension arrays
// create array: type[] name = new type[size] { value1, value2... }

int[] numbers = { 5, 6, 7, 4, 7, 4, 72, 6, 7, 2 };

// get element by index

numbers[0] = 777;
Console.WriteLine($"First element: {numbers[0]}");

Console.WriteLine($"Array type: {numbers.GetType()}");
Console.WriteLine($"Element type: {numbers[0].GetType()}");

numbers.SetValue(99, 2);
numbers.GetValue(2);

Console.WriteLine($"Lenght: {numbers.Length}");
Console.WriteLine($"1 dimension length: {numbers.GetLength(0)}");

// ----------- two-dimension arrays
int[,] matrix = new int[3, 4] {
                                { 4, 1, 5, 6 },
                                { 2, 0, 53, 64 },
                                { 1, 2, 3, 4 }
                              };

Console.WriteLine($"Matrix lenght: {matrix.Length}");

Console.WriteLine($"Item: {matrix[1, 2]}");
Console.WriteLine("1 dim len: " + matrix.GetLength(0)); // 3
Console.WriteLine("2 dim len: " + matrix.GetLength(1)); // 4

Console.WriteLine("Dimensions: " + matrix.Rank);

// ------------------- inerate array

// indexes: [0...9]
//Console.WriteLine($"Element [0]: {numbers[0]}");
//Console.WriteLine($"Element [1]: {numbers[1]}");
//Console.WriteLine($"Element [2]: {numbers[2]}");
//...

for (int i = 0; i < numbers.Length; ++i)
{
    Console.WriteLine($"Element [{i}]: {numbers[i]}");
}

Console.Write("Array with foreach(): ");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}
Console.WriteLine();

Array.Reverse(numbers);

Console.Write("Reversed array: ");
foreach (int num in numbers) Console.Write(num + " ");
Console.WriteLine();

Array.Sort(numbers);
//numbers = numbers.OrderByDescending(x => x).ToArray();

Console.Write("Sorted array: ");
foreach (int num in numbers) Console.Write(num + " ");
Console.WriteLine();

//Array.Fill(numbers, 5);
//Array.Resize(ref numbers, 15);

int index = Array.IndexOf(numbers, 50);
if (index != -1)
    Console.WriteLine("Index of 50: " + index);
else
    Console.WriteLine("Element not found!");
