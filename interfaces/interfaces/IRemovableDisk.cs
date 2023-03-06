using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_oop_intarfaces
{
    internal interface IRemovableDisk
    {
        bool HashDisk { get; }

        void Insert();

        void Reject();
    }
}
