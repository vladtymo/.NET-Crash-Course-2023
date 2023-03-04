using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Bird: Animal
    {
        public string Food { get; set; }
        public double RozmahKril { get; set; }


        public Bird(string vud, double svudkist, double vaga, string sermesh, string food, double rozkril)
            : base(vud, svudkist, vaga, sermesh)
        {
            Food = food;
            RozmahKril = rozkril;
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine($"Назва: {Food}\n" +
                $"Розмах крил: {RozmahKril}");
        }
    }
}
