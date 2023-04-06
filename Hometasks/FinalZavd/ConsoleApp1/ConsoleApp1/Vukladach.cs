using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vukladach:Osoba
    {
        public static int counter = 0;
        public readonly int nomer;
        public string Kafedra { get; set; }
        public Predmet Predmet { get; set; }

        public Vukladach(string firstName, string lastName, string nomerTelefona, DateTime dataNarodgenya, string kafedra, Predmet predmet)
            : base(firstName, lastName, nomerTelefona, dataNarodgenya)
        {
            ++counter;
            nomer = counter;
            Kafedra = kafedra;
            Predmet = predmet;
        }


        public override void Info()
        {
            Console.WriteLine($"Vukladach №{nomer}\n" +
                $"PIP: {FirstName} {LastName}\n" +
                $"Nomer telefona: {NomerTelefona}\n" +
                $"Data narodgennya: {DataNarodgenya}\n" +
                $"Kafedra: {Kafedra}\n" +
                $"Predmet: {Predmet.Name}\n");
        }

        public void ReSetVukladach(string firstName, string lastName, string nomerTelefona, DateTime dataNarodgenya, string kafedra, Predmet predmet)
        {
            FirstName = firstName;
            LastName = lastName;
            NomerTelefona = nomerTelefona;
            DataNarodgenya = dataNarodgenya;
            Kafedra = kafedra;
            Predmet = predmet;
        }

    }
}
