using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9_HW_Task1
{
    internal class Printer : IPrintInformation
    {
        public string GetName()
        {
            return "Printer";
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
