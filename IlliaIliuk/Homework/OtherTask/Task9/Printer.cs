using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherTask.Task9
{
    internal class Printer : IPrintInformation
    {
        public string GetName()
        {
            return "Printer::GetName()";
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
