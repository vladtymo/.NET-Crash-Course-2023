using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9_HW_Task2
{
    public class Drums : IInstruments
    {
        public string Producer { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public bool ChangePrice(double newPrice)
        {
            if(newPrice > 0)
            {
                Price = newPrice;
                return true;
            }
            return false;
        }

        public void WriteInfo()
        {
            Console.WriteLine($"Виробник: {Producer}\n" +
                $"Модель барабанів: {Model}\n" +
                $"Ціна: {Price}");
        }
    }
}
