using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Osoba
    {
        public static int counter = 0;
        public readonly int nomer;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NomerTelefona { get; set; }
        public DateTime DataNarodgenya { get; set; }


        public Osoba(string firstName, string lastName, string nomerTelefona, DateTime dataNarodgenya)
        {
            ++counter;
            nomer = counter;
            FirstName = firstName;
            LastName = lastName;
            NomerTelefona = nomerTelefona;
            DataNarodgenya = dataNarodgenya;
            
        }

        public virtual void Info()
        {
            Console.WriteLine($"Osoba №{nomer}\n" +
                $"PIP: {FirstName} {LastName}\n" +
                $"Nomer telefona: {NomerTelefona}\n" +
                $"Data narodgennya: {DataNarodgenya}\n");
        }
    }
}
