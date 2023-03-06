using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_oop_intarfaces
{
    internal class Printer : IPrintInformation
    {
        public string GetName()
        {
            return new string("Printer Canon 600");
        }

        public void Print(string str)
        {
            Console.WriteLine($"Im printing: {str}");
        }
    }
}
