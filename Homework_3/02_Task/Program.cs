Random rnd= new Random();
int value = rnd.Next(0, 10);

int counter = 1;

while(1 > 0)
{
    Console.WriteLine("Enter your value: ");
    int res = int.Parse(Console.ReadLine());

    if (res != value) Console.WriteLine("Nope!\n");
    else
    {
        Console.WriteLine("Yes!\n"); 
        break;
    }
    ++counter;
    
}

Console.WriteLine($"Amount of tries: {counter}");