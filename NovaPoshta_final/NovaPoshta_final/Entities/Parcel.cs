using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace NovaPoshta_final.Entities
{
    internal class Parcel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public bool IsArrived { get; set; }
        public int PostOfficeId { get; set; }
        public PostOffice PostOffice { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int AddresseeId { get; set; }
        public Client Addressee { get; set; }

        //public int AddresseeId { get; set; }
        //public Client Addressee { get; set; }
        //public int ArrivedOfficeId { get; set; }
        //public PostOffice ArrivedOffice { get; set; }


        //public Parcel(string name, int weight, bool isArrived)
        //{
        //    Name = name;
        //    Weight = weight;
        //    IsArrived = isArrived;
        //}

        //public void ArrivedParcel(string addres)
        //{
        //    if(IsArrived == true)
        //    {
        //        Console.WriteLine($"{Name}");
        //    }
        //}

    }
}
