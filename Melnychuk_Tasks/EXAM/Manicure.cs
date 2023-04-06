using Exam;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class Manicure : Service
    {
        public string AdditionalServices { get; set; }

        public Manicure(string type, int price, string additionalServices) : base("Манікюр", price, type)
        {
            AdditionalServices = additionalServices;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} ({Type}): {Price} грн, Додаткові послуги: {AdditionalServices}");
        }

        public override void Edit()
        {
            base.Edit();
            Console.Write("\n\t\tВведіть новий тип: ");
            this.Type = Console.ReadLine();
            Console.Write("\n\t\tВведіть додаткові параметри: ");
            this.AdditionalServices = Console.ReadLine();
        }

    }
}
