using Exam;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class Haircut : Service
    {
        public Haircut(string type, int price) : base("Стрижка", price, type) { }

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
