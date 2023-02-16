// while

int counter = 0;

while (counter < 10)
{
    Console.WriteLine("Hi!");
    ++counter;
}

for (int i = 0; i < 10; ++i)
{
    Console.WriteLine("Hello!");
}

Random random = new Random();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Rand is {random.Next(20, 50)}");
}