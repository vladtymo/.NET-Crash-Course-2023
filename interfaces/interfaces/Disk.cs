using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_oop_intarfaces
{
    internal class Disk
    {
        private string memory;
        private int memSize;

        public string Memory { get; set; }
        public int MemSize { get; set; }

        public Disk()
        {
            memory = "memory";
            MemSize = 512;
        }

        public Disk(string memory, int memSize)
        {
            Memory = memory;
            MemSize = memSize;
        }

        public string GetName()
        { 
            return new string("Disk");

        }

        public string Read()
        {
            return new string("Reading...");
        }

        public void Write(string str)
        {
            Console.WriteLine(str);
        }
    }
}
