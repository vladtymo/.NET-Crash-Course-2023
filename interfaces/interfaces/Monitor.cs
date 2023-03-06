using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_oop_intarfaces
{
    internal class Monitor : IPrintInformation
    {
        public string GetName()
        {
            return new string("Monitor LG");
        }

        public void Print(string str)
        {
            Console.WriteLine($"Im showing: {str}");
        }
    }
}
