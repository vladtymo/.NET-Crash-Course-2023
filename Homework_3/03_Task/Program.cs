int[] array = new int[20];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(0, 100);

for (int i = 0; i < array.Length; ++i)
{
    Console.WriteLine($"Element [{i}]: {array[i]}");
}