using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;
using NovaPoshta_final.Databasae;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta_final.Entities
{
    public delegate int MakeOpeeration(int operationNumber);

    internal class Client : Participant
    {
        public string PhoneNumber { get; set; }
        public ICollection<Parcel> Parcels { get; set; }

        public override void ShowInfo(string surname)
        {
            DatabaseManager db = new DatabaseManager();
            Client client = db.GetClientBySurname(surname)!;

            Console.WriteLine($"Fullname: {client.Name} {client.Surname}\n" +
            $"Age: {client.Age}\n" +
            $"Phone number: {client.PhoneNumber}\n");

            Menu menu = new Menu();
            menu.GoOverMainMenu();
        }

       
    }
}
