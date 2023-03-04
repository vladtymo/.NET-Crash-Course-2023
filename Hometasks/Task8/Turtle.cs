using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Turtle:Reptile
    {
        public string Name { get; set; }

        public Turtle(string vud, double svudkist, double vaga, string sermesh, double dovgina, string pidvud,string name)
            : base(vud, svudkist, vaga, sermesh, dovgina, pidvud)
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
