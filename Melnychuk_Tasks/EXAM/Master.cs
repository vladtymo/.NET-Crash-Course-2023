using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class Master : Person
    {
       
        public Master(int rank)
        {

            Type = "Master";
            Rank = rank;
        }
        public int Rank { get; set; }
        public void Work()
        {
            Console.WriteLine($"Майстер {Name} працює.");
        }
        public override void Edit()
        {
            base.Edit();
            Console.WriteLine("Введіть ранг:");
            Rank = int.Parse(Console.ReadLine());
        }
    }
}
