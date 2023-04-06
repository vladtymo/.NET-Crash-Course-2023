using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NovaPoshta_final.Entities
{
    internal class PostOffice
    {
        public int Id { get; set; }
        public int PostNumber { get; set; }
        public string Adress { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }

}
