using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Okun:Fish
    {
        public string Name { get; set; }

        public Okun(string vud, double svudkist, double vaga, string sermesh, string morsk, string higa,string name)
            : base(vud, svudkist, vaga, sermesh, morsk, higa)
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
