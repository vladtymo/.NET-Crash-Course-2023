using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09_task1
{
    internal class Monitor: IPrintInformation
    {
        public void GetName()
        {
            Console.WriteLine("Monitor Name");
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
