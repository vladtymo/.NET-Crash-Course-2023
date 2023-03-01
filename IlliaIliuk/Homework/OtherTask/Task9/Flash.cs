using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherTask.Task9
{
    internal class Flash : Disk, IRemoveableDisk
    {
        private bool hasDisk;

        public Flash()
        {
        }

        public Flash(string memory, int memSize) : base(memory, memSize)
        {
        }

        public bool HasDisk => hasDisk;

        public override string GetName() { return "Flash::GetName()"; }
        public void Insert()
        {
            Console.WriteLine("Flash::Insert()");
        }

        public void Reject()
        {
            Console.WriteLine("Flash::Reject()");
        }
    }
}
