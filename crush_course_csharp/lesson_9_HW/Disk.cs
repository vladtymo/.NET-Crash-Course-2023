using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9_HW_Task1
{
    internal class Disk : IDisk
    {
        private string memory;
        private int memSize;

        public string Memory { get; set; }
        public int MemSize { get; set; }

        public Disk()
        {
        }
        public Disk(string memory, int memSize)
        {
            this.memory = memory;
            this.memSize = memSize;
        }

        public string GetName()
        {
            return memory;
        }

        public string Read()
        {
            return memory + memSize.ToString();
        }

        public void Write(string text)
        {

        }
    }
}
