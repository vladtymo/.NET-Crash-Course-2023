using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherTask.Task9
{
    internal class Disk :IDisk
    {
        private string memory;
        private int memSize;

        public string Memory { get => memory; set => memory = value; }
        public int MemSize { get => memSize; set => memSize = value; }

        public Disk() { }
        public Disk(string memory, int memSize) 
        {
            this.memory = memory;
            this.memSize = memSize;
        }

        public virtual string GetName() { return "Disk::GetName()"; }
        public string Read() { return "Disk::Read()"; }
        public void Write(string text) 
        { 
            Console.WriteLine(text);
        }
    }
}
