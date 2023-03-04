using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Golub: Bird
    {
        public string Name { get; set; }

        public Golub(string vud, double svudkist, double vaga, string sermesh, string food, double rozkril,string name)
            : base(vud, svudkist, vaga, sermesh, food, rozkril)
        {
            Name = name;
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine($"Ім'я: {Name}");
        }
    }
}
