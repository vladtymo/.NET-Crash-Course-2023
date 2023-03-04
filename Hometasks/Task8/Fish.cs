using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Fish: Animal
    {
        public string MorskaAboPris { get; set; }
        public string HigaAboNi { get; set; }

        public  Fish(string vud, double svudkist, double vaga, string sermesh,string morsk,string higa)
            : base(vud, svudkist, vaga, sermesh)
        {
            MorskaAboPris = morsk;
            HigaAboNi = higa;
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine($"Морська або прісноводна: {MorskaAboPris}\n" +
                $"Хижа або ні: {HigaAboNi}");

        }
    }
}
