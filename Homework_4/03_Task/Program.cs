Console.WriteLine("Write your text: ");
string text = Console.ReadLine()!;

char[] arr = text.ToCharArray();
int lenght = arr.Length;

int counterUp = 0;
int counterLow = 0;

foreach (char i in text.Where(char.IsUpper))
{
    counterUp++;
}

foreach (char i in text.Where(char.IsLower))
{
    counterLow++;
}

Console.WriteLine($"Amount of Upper letters in percent: {(counterUp*100)/lenght}%");
Console.WriteLine($"Amount of Lower letters in percent: {(counterLow * 100) / lenght}%");