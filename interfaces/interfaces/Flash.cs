using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_oop_intarfaces
{
    internal class Flash : Disk, IRemovableDisk
    {
        private bool hashDisk;

        public bool HashDisk { get; } = true;

        public new string GatName()
        {
            Console.WriteLine("Getting name");
            return "Flash Kingstone"; 
        }

        public void Insert()
        {
            Console.WriteLine("Flash was insered");
        }

        public void Reject()
        {
            Console.WriteLine("Flash was removed");
        }


    }
}
