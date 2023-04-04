using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HomeWork15.Data;

using HomeWork15.Entities;
using static System.Formats.Asn1.AsnWriter;

namespace HomeWork15
{
    class Program
    {
        static async Task Main(string[] args)
        {
            StoreManager manager = new StoreManager(new StoreDbContext());

            while (1==1)
            { 
            var shops = await manager.GetShops();
            
            //show all shops
            Console.WriteLine("All shops:");
            foreach (var shop in shops)
            {
                Console.WriteLine($"Shop: {shop.Id} : {shop.Name}");
            }
                Console.WriteLine("0 - Exit");

                Console.WriteLine("Choose shop by Id:");
            int shopId = int.Parse(Console.ReadLine());
            if (shopId==0) Environment.Exit(0);


                Console.WriteLine("Choose what to show:");
            Console.WriteLine("1 - Workers");
            Console.WriteLine("0 - Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var workersInShop = await manager.GetWorkers();
                    if (workersInShop != null)
                    {
                        Console.WriteLine("Workers in the shop:");
                        foreach (var worker in workersInShop)
                        {
                            if (worker.ShopId==shopId)
                            Console.WriteLine($"- {worker.Name} {worker.Surname} ({worker.Email})");
                        }
                    }
                    break;
                case 0:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
      }
    }
}
