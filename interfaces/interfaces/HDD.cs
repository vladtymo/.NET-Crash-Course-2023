using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_oop_intarfaces
{
    internal class HDD : Disk
    {
        public new string GetName()
        {
            Console.WriteLine("HDD name");
            return "HDD";
        }
    }
}
