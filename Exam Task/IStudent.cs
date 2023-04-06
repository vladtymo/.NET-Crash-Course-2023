using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task
{
    internal interface IStudent
    {
        public bool IsFullDayEducation { get; }   
        public int Course { get; }
    }
}
