using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09_task1
{
    internal class Disk : IDisk
    {
        private string memory;
        private int memSize;
        public string Memory { get; set; }
        public int MemSize { get; set; }
        public Disk() { }
        public Disk(string memory, int memSize)
        {
            this.memory= memory;
            this.memSize = memSize;
        }
        public string GetName(string name)
        {
            return name;
        }
        public void Read()
        {
            Console.WriteLine("Reading disk");
        }
        public void Write(string text)
        {
            Console.WriteLine($"Writen text:\"{text}\"");
        }

    }
}
