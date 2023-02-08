
Random random = new Random();
int number = (random.Next()%10)+1;
int value = -1;
int index = 0;
Console.WriteLine("Guess the number: ");
for (int i=0;number!=value;i++)
{
    value= int.Parse(Console.ReadLine());
    index = i;
}
Console.WriteLine($"You win, you have used {index+1} attempts");