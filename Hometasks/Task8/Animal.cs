using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Animal
    {
        public string Vud { get; set; }
        public double Svudkist { get; set; }
        public double  Vaga { get; set; }
        public string SeredovMeshk { get; set; }




        public Animal(string vud, double svudkist, double vaga, string sermesh)
        {
            Vud = vud;
            Svudkist = svudkist;
            Vaga = vaga;
            SeredovMeshk = sermesh;
        }


        public void Move()
        {
            Console.WriteLine("Рух....");
        }

        public void MakeSound()
        {
            Console.WriteLine("Рух....");
        }


        public void Show()
        {
            Console.WriteLine($"Вид: {Vud}\n" +
                $"Швидкість: {Svudkist}\n" +
                $"Вага: {Vaga}\n" +
                $"Середовище мешкання: {SeredovMeshk}");
        }
    }
}
