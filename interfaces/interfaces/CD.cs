using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_oop_intarfaces
{
    internal class CD : Disk, IRemovableDisk
    {
        private bool hashDisk = true;
        public bool HashDisk => hashDisk;

        public void Insert()
        {
            Console.WriteLine("CD disk was inserted");
        }

        public void Reject()
        {
            Console.WriteLine("CD disk was removed");
        }

        public new string GetName()
        {
            string name = "CD disk name";
            return name;
        }
    }
}
