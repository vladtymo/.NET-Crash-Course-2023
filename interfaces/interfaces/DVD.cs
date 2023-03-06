using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_oop_intarfaces
{
    internal class DVD : Disk, IRemovableDisk
    {
        private bool hashDisk;
        public bool HashDisk { get; } = true;

        public new string GetName()
        {
            string name = "DVD disk name";
            return name;
        }

        public void Insert()
        {
            Console.WriteLine("DVD was inserted");
        }

        public void Reject()
        {
            Console.WriteLine("DVD was removed");
        }
    }
}
