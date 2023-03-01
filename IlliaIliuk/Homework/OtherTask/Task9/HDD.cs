using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherTask.Task9
{
    internal class HDD: Disk
    {
        public HDD()
        {
        }

        public HDD(string memory, int memSize) : base(memory, memSize)
        {
        }

        public override string GetName() { return "Flash::GetName()"; }
    }
}
