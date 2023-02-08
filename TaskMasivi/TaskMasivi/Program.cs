using System.Diagnostics.SymbolStore;

enum Aba {sum = 1, sort, pare, max}
internal class Program
{
    
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Yellow;
        //-----------------1---------------------//
        /*Console.WriteLine("введіть символ: ");
        string symbol = Console.ReadLine();
        Console.WriteLine("введіть довжину лінії");
        int i = int.Parse(Console.ReadLine());
        for (int j = 0; j < i; j++)
        {
            Console.Write(symbol);
        }*/


        //--------------------2---------------------//
        /*bool checkkk = false;
        do
        {
            Random random = new Random();
            Console.WriteLine("Вибране випадково число від 1 до 10. Вгадайте його!");
            int b = random.Next(1, 10);
            int a = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Ви вгадали! Молодець!");
                checkkk = true;
            }
            else
                Console.WriteLine("Ви не вгадали! Спробуйте ще раз!");
        } while (!checkkk);*/

        //-----------------------3-------------------------//
        /*Random random = new Random();
        int[] arr = new int[20];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(0, 100);
            Console.WriteLine(arr[i]);
        }*/

        //-----------------------4--------------------//

        Random random = new Random();
        int[] arr = new int[20];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(0, 100);
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine("Що зробимо?");
        Console.WriteLine("Знайдемо суму елементів = 1\n" +
        "Відсортуємо масив = 2\n" +
        "Кількість парних елементів = 3\n" +
        "Максимальний елемент = 4\n");

        Aba aba = Enum.Parse<Aba>(Console.ReadLine());
        
        switch (aba)
        {
            case Aba.sum:
                int summ = 0;
                foreach (int i in arr)
                {
                    summ += i;
                }
                Console.WriteLine("Сума елементів масиву: ");
                break;
            case Aba.sort:
                Console.WriteLine("Відсортований масив");
                Array.Sort(arr);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                break;
            case Aba.pare:
                int count = 0;
                foreach (int i in arr)
                {
                    if (i % 2 == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine("Кількість парних елементів: " + count);
                break;
            case Aba.max:
                Console.WriteLine($"Max value: " + arr.Max());
                break;
            default: Console.WriteLine("Такої дії немає!"); break;
        }
    }
}