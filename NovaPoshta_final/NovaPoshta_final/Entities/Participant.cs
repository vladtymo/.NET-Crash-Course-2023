using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NovaPoshta_final.Databasae;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta_final.Entities
{
    enum Role { Сlient = 1, Employee }

    internal abstract class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Role ParticipantRole { get; set; }

        public abstract void ShowInfo(string surname);

        public void ChangePhoneNumber()
        {
            Console.WriteLine("Changing phone number!");
        }

    }
}
