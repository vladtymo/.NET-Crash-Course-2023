using Exam;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class Coloring : Service
    {
        public Coloring(string type, int price) : base("Фарбування", price, type) { }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} ({Type}): {Price} грн");
        }

        public override void Edit()
        {
            base.Edit();
            Console.Write("\nВведіть новий тип:");
            this.Type = Console.ReadLine();
        }
    }
}
