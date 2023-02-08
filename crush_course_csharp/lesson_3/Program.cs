
enum CheckPlay { Так = 1, Ні = 2 };
enum ArrayAction {Summ = 1, Sort = 2, Count = 3, Max = 4 };
internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        RandomArray2();
    }
    static void Line()
    {
        Console.Write("Введіть символ для формування лінії: ");
        string ch = Console.ReadLine();
        Console.Write("Введіть кількість повторень: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++){
            Console.Write(ch);
        }
    }
    static void Randomize()
    {
        //Привітання
        Console.WriteLine("Вітаємо вас у грі \"Відгадай число\"");
        Console.WriteLine("Вам потрібно відгадати число, яке загадає програма");
        bool playOrNo = true;
        do
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 11);

            Console.Write("Введіть число: ");
            bool check = false;
            int schet = 1;
            do
            {
                int a = int.Parse(Console.ReadLine());
                if (a == n)
                {
                    Console.WriteLine("Вітаємо ви перемогли!!!");
                    Console.WriteLine($"Кількість спроб: {schet}");
                    check = true;
                }
                else
                {
                    schet++;
                    Console.WriteLine("Не вірно!");
                    Console.Write("Спробуйте ще раз: ");
                }
            } while (!check);

            Console.WriteLine("Бажаєте зіграти ще раз:\n" +
                $"{(int)CheckPlay.Так} - {CheckPlay.Так}\n" +
                $"{(int)CheckPlay.Ні} - {CheckPlay.Ні}\n");

            CheckPlay checkPlay = Enum.Parse<CheckPlay>(Console.ReadLine());

            switch (checkPlay)
            {
                case CheckPlay.Так: playOrNo = true; break;
                case CheckPlay.Ні: playOrNo = false; break;
                default: Console.WriteLine("Такої дії немає!\nАвтоматичний вихід з гри..."); break;
            }

        } while (playOrNo);
    }
    static void RandomArray()
    {
        int[] randArray = new int[20];
        Random rnd = new Random();
        for (int i = 0; i < 20; i++)
        {
            randArray[i] = rnd.Next(1,100);
            Console.Write(randArray[i] + " ");
        }


    }
    static void RandomArray2()
    {
        int[] randArray = new int[20];
        Random rnd = new Random();
        for (int i = 0; i < 20; i++)
        {
            randArray[i] = rnd.Next(1, 100);
            Console.Write(randArray[i] + " ");
        }
        Console.WriteLine("\nВиберіть дію для масиву:\n" +
            $"{(int)ArrayAction.Summ} - {ArrayAction.Summ}\n" +
            $"{(int)ArrayAction.Sort} - {ArrayAction.Sort}\n" +
            $"{(int)ArrayAction.Count} - {ArrayAction.Count}\n" +
            $"{(int)ArrayAction.Max} - {ArrayAction.Max}\n");

        ArrayAction dayNumber = Enum.Parse<ArrayAction>(Console.ReadLine());

        switch (dayNumber)
        {
            case ArrayAction.Summ:
                int summ = 0;
                foreach(int i in randArray)
                {
                    summ += i;
                }
                Console.WriteLine("Сума елементів масиву: ");
                break;
            case ArrayAction.Sort: 
                Console.WriteLine("Відсортований масив");
                Array.Sort(randArray);
                foreach (int i in randArray)
                {
                    Console.Write(i + " ");
                }
                break;
            case ArrayAction.Count:
                int count = 0;
                foreach (int i in randArray)
                {
                    if (i % 2 == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine("Кількість парних елементів: " + count); 
                break;
            case ArrayAction.Max: 
                Console.WriteLine($"Max value: " + randArray.Max()); 
                break;
            default: Console.WriteLine("Такої дії немає!"); break;
        }
    }
}