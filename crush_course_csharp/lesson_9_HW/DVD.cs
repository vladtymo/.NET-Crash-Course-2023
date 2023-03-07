using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9_HW_Task1
{
    internal class DVD : Disk, IRemovableDisk
    {
        public bool HasDisk { get; set; }

        public void Insert()
        {
            HasDisk = true;
        }

        public void Reject()
        {
            HasDisk = false;
        }
        public new string GetName()
        {
            return "DVD";
        }
    }
}
