Console.WriteLine("Enter a symbol: ");
string symbol = Console.ReadLine();

Console.WriteLine("Enter amount of symbols: ");
int amount = int.Parse(Console.ReadLine());

for(int i = 0; i < amount;++i)
{
    Console.Write(symbol);
}