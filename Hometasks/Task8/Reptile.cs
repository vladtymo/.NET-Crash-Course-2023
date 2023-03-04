using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Reptile: Animal
    {
        public double Dovgina { get; set; }
        public string Pidvud { get; set; }


        public Reptile(string vud, double svudkist, double vaga, string sermesh,double dovgina,string pidvud)
            : base(vud, svudkist, vaga, sermesh)
        {
            Dovgina = dovgina;
            Pidvud = pidvud;
        }


        public void Show()
        {
            base.Show();
            Console.WriteLine($"Довжина: {Dovgina}\n" +
                $"Підвид: {Pidvud}");
        }
    }
}
