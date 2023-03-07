using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW9._1
{
    internal class Disk : IDisk
    {
        internal readonly string name;
        private string? memory;
        private int memSize;
        string Memory { get; set; }
        int MemSize { get; set; }

        public Disk() { name = "NoName"; memory = ""; memSize = 0; }
        public Disk(string name, string memory, int memSize)
        {
            this.name = name;
            this.memory = memory;
            this.memSize = memSize;
        }
        public string GetName()
        {
            return name;
        }
        public string Read()
        {
            return memory;
        }
        public void Write(string text)
        {
            memory = text;
        }
    }

    internal class CD : Disk, IRemovableDisk
    {
        bool hasDisk;
        public bool HasDisk { get; }
        public string GetName()
        {
            return name;
        }
        public void Insert()
        {
            hasDisk = true;
        }
        public void Reject()
        {
            hasDisk = false;
        }
    }

    internal class Flash : Disk, IRemovableDisk
    {
        bool hasDisk;
        public bool HasDisk { get; }
        public string GetName()
        {
            return name;
        }
        public void Insert()
        {
            hasDisk = true;
        }
        public void Reject()
        {
            hasDisk = false;
        }
    }

    internal class DVD : Disk, IRemovableDisk
    {
        bool hasDisk;
        public bool HasDisk { get; }
        public string GetName()
        {
            return name;
        }
        public void Insert()
        {
            hasDisk = true;
        }
        public void Reject()
        {
            hasDisk = false;
        }
    }

    internal class HDD : Disk
    {
        public string GetName()
        {
            return name;
        }
    }
}
