using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherTask.Task9
{
    internal class Comp
    {
        private Disk[] disks;
        private IPrintInformation[] printDevice;
        private int countDisk = 0;
        private int countPrintDevice = 0;

        public Comp(int d,int pd)
        {
            this.disks = new Disk[d];
            this.countDisk = d;
            this.printDevice = new IPrintInformation[pd];
            this.countPrintDevice = pd;
        }

        public Disk[] Disks => disks;
        public IPrintInformation[] PrintDevice => printDevice; 

        public void AddDevice(int index, IPrintInformation device)
        {
            printDevice[index] = device;
        }
        public void AddDisk(int index, Disk disk) 
        {
            disks[index] = disk;
        }

        public bool CheckDisk(string device) { return true; }

        public void InsertReject(string device, bool b) { }
        public bool PrintInfo(string text, string device) { return true; }
        public string ReadInfo(string device) { return "Comp::ReadInfo()"; }
        public void ShowDisk() { }
        public void ShowPrintDevice() { }
        public bool WriteInfo(string text, string device) { return true; }
    }
}
