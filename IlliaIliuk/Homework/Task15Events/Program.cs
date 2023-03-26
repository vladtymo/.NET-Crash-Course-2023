using System.Collections;
using System.Text.Json;

namespace Task15Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonToSave;
            Random random = new Random();

            Exchange exchange = new();
            Human human1 = new("Illia");
            Human human2 = new("Julia");
            Human human3 = new("Vasa");

            List<Human> list = new List<Human>() { human1,human2, human3 };


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            exchange.UpdateDay += human1.Trading;
            exchange.UpdateDay += human2.Trading;
            exchange.UpdateDay += human3.Trading;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-------------------");

                exchange.Update();
                Console.WriteLine(exchange.ExchangeRate);

                jsonToSave = JsonSerializer.Serialize(list);
                File.WriteAllText("history_operation.json", jsonToSave);

                Console.WriteLine("-------------------");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                exchange.ExchangeRate = random.Next(1, 100);
            }
        }
    }
}