using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_interfaces_2
{
    internal interface IHealable
    {
        int Health { get; set; }
        void GetHeal()
        {
            Health += 500;
        }
    }
}
