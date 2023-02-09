
//2.Написати гру «Вгадай число».
//Програма «загадує» випадковим чином число,
//після чого користувач повинен вгадати його.
//Вкінці потрібнго відобразити кількість спроб, яку було використано.

Random RandomNumberArray = new Random();
int RandomNumber = RandomNumberArray.Next(1000);
Console.WriteLine($"Загадане число {RandomNumber}");
int attempt = 1;
do
{
    ++attempt;
    Console.WriteLine("Введiть число");
    int NumberRead = int.Parse(Console.ReadLine());
    if (NumberRead == RandomNumber)
    {
        Console.WriteLine($"Ви вгадали число {NumberRead} з {attempt}ї спроби");
        break;
    }
    else
        Console.WriteLine($"Ви ввели не правильне число, спроба номер {attempt}");

} while (1 == 1);
