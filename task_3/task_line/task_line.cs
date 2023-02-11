Console.Write("Enter a character: ");
char character = char.Parse(Console.ReadLine());
Console.Write("Enter a number : ");
int number = int.Parse(Console.ReadLine());
for (int i = 0; i < number; i++)
{
    Console.Write(character);
}
