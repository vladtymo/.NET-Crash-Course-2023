using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09_task1
{
    internal class Flash: Disk, IRemoveableDisk
    {
        private bool hasDisk;
        public bool HasDisk { get; set; }

        public void GetName()
        {
            Console.WriteLine(" Method Name");
        }
        public void Insert()
        {
            Console.WriteLine("Method Insert");
        }

        public void Reject()
        {
            Console.WriteLine("Method Reject");
        }
    }
}
