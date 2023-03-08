using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09_task1
{
    internal interface IRemoveableDisk
    {
        public bool HasDisk { get; }
        public void Insert();
        public void Reject() ;
    }
}
