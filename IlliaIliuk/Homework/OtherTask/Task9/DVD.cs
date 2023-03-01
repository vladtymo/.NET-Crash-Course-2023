using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherTask.Task9
{
    internal class DVD : Disk , IRemoveableDisk
    {
        private bool hasDisk;

        public DVD()
        {
        }

        public DVD(string memory, int memSize) : base(memory, memSize)
        {
        }

        public bool HasDisk => hasDisk;

        public override string GetName() { return "DVD::GetName()"; }
        public void Insert()
        {
            Console.WriteLine("DVD::Insert()");
        }

        public void Reject()
        {
            Console.WriteLine("DVD::Reject()");
        }
    }
}
