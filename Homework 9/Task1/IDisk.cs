using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09_task1
{
    internal interface IDisk
    {
        public void Read();
        public void Write(string text);
    }
}
