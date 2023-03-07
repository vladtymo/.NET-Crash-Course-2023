using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HW9._1
{
    internal class Computer
    {
        private int countDisk;
        private int countPrintDevice;
        private List<Disk> disks;
        private List<IPrintInformation> printDevices;
        public Computer(int d, int pd) { countDisk = d; countPrintDevice = pd; }
        public void AddDevice(int index, IPrintInformation si)
        {
            printDevices.Insert(index, si);
            countPrintDevice++;
        }
        public void AddDisk(int index, Disk d) 
        {
            disks.Insert(index, d);
            countDisk++;
        }
        public bool CheckDisk(string device)
        {
            foreach (Disk disk in disks)
            {
                if (disk.GetName() == device)
                    return true;
            }
            return false;
        }
        public void InsertReject(string device, bool b) 
        {
            foreach (IRemovableDisk disk in disks)
            {
                if(disk.GetName() == device)
                {
                   if(b) { disk.Insert(); }
                   else { disk.Reject(); }
                }
            }
        }
        public bool PrintInfo(string text, string device) 
        {
            foreach (IPrintInformation printDevice in printDevices)
            {
                if(printDevice.GetName() == device)
                    printDevice.Print(text); return true;
            }
            return false;
        }
        public string ReadInfo(string device) 
        {
            foreach (Disk disk in disks)
            {
                if (disk.GetName() == device)
                    return disk.Read();
            }
            return "Device not found...";
        }
        public void ShowDisk()
        {
            foreach (Disk disk in disks)
                disk.GetName();
        }

        public void ShowPrintDevice()
        {
            foreach(IPrintInformation printDevice in printDevices)
                printDevice.GetName();
        }
        public string WriteInfo(string text, string device)
        {
            foreach (Disk disk in disks)
            {
                if (disk.GetName() == device)
                    disk.Write(text); return text;
            }
            return "Device not found...";
        }
    }

    internal class Printer : IPrintInformation
    {
        public string GetName()
        {
            return "Name";
        }
        public void Print(string str) 
        {
            Console.WriteLine(str);
        }
    }

    internal class Monitor : IPrintInformation
    {
        public string GetName()
        {
            return "Name";
        }
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
