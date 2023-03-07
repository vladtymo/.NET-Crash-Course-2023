using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9_HW_Task1
{
    internal interface IDisk
    {
        public string Read();
        public void Write(string text);
    }
}
