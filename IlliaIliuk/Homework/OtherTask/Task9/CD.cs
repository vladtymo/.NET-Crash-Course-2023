using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherTask.Task9
{
    internal class CD : Disk , IRemoveableDisk
    {
        private bool hasDisk;

        public CD()
        {
        }

        public CD(string memory, int memSize) : base(memory, memSize)
        {
        }

        public bool HasDisk => hasDisk;

        public override string GetName() { return "CD::GetName()"; }

        public void Insert()
        {
            Console.WriteLine("CD::Insert()");
        }

        public void Reject()
        {
            Console.WriteLine("CD::Reject()");
        }
    }
}
