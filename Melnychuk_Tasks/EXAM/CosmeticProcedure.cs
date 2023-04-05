using Exam;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class CosmeticProcedure : Service
    {
        public int Duration { get; set; }

        public CosmeticProcedure(string type, int duration, int price) : base("Косметична процедура", price, type)
        {
            Duration = duration;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} ({Type}, {Duration} хв): {Price} грн");
        }

        public override void Edit()
        {
            base.Edit();
            Console.Write("\nВведіть новий тип:");
            this.Type = Console.ReadLine();
            Console.Write("\nВведіть нову тривалість процедури:");
            this.Duration = int.Parse(Console.ReadLine());
        }
    }
}
