using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OtherTask.Task9
{
    internal interface IRemoveableDisk
    {

        public bool HasDisk { get; }
        public void Insert();
        public void Reject();
    }
}
