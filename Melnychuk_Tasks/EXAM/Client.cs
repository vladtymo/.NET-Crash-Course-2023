using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class Client : Person
    {
        public Client(int money)
        {
            Type = "Client";
            Money = money;
        }
        public int Money { get; set; }

        public override void Edit()
        {
            base.Edit();
            Console.WriteLine("Введіть кількість грошей:");
            Money = int.Parse(Console.ReadLine());
        }
    }
}
