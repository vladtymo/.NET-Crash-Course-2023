using EXAM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public abstract class Service : IEditor
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public Service(string name, int price, string type)
        {
            Name = name;
            Price = price;
            Type = type;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Name}: {Price} грн");
        }
        public virtual void Edit()
        {
            Console.Write("\n\t\tРедагування {0}", Name);
            Console.Write("\n\t\tВведіть нову назву: ");
            this.Name = Console.ReadLine();
            Console.Write("\n\t\tВведіть нову ціну:");
            this.Price = int.Parse(Console.ReadLine());
        }

    }
}
