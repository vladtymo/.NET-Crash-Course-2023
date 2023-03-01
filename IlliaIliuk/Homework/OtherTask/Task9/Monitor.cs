using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OtherTask.Task9
{
    internal class Monitor : IPrintInformation
    {
        public string GetName()
        {
            return "Monitor::GetName()";
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
