using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09_task1
{
    internal class DVD : Disk, IRemoveableDisk
    {
        private bool hasDisk;
        public bool HasDisk { get; set; }
        public void GetName()
        {
            Console.WriteLine("DVD Name");
        }

        public void Insert()
        {
            Console.WriteLine("DVD method Insert");
        }

        public void Reject()
        {
            Console.WriteLine("DVD method Reject");
        }

    }
}
