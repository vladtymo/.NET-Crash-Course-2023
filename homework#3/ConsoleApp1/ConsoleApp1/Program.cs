// See https://aka.ms/new-console-template for more information


////////////////////task1///////////////////////

Console.WriteLine("Enter the symbol with line!");
string symbol = (Console.ReadLine());
Console.WriteLine("Enter the lenght of the line");
int lenght = int.Parse(Console.ReadLine());
for (int i = 0; i < lenght; i++)
    Console.WriteLine(symbol);


///////////////////task2//////////////////////

Random rand = new Random();
int rand1 = rand.Next(0, 100);
while (true)
{
    string t = Console.ReadLine();
    int number = Convert.ToInt32(t);
    if (rand1 > number)
    {
        Console.WriteLine("The requested number is more");
    }
    if (rand1 < number)
    {
        Console.WriteLine("The requested number is less");
    }
    if (rand1 == number)
    {
        Console.WriteLine("you guessed it");
        break;
    }
}


///////////////////task3//////////////////////

int[] myArray = new int[20];
Random rand11 = new Random();

for (int x = 0; x < myArray.Length; x++)
{
    myArray[x] = rand11.Next(20);
    Console.WriteLine(myArray[x]);
}

///////////////////task4//////////////////////

int S = 0;
for (int x = 0; x < myArray.Length; x++) 
{
    S = S + x;
}   
Console.WriteLine(S);
Console.ReadKey();