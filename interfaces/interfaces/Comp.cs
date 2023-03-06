using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_oop_intarfaces
{
    internal class Comp
    {
        private int countDisk;
        private int countPrintDevive;
        private IPrintInformation[] printDevice;
        private Disk[] disks;

        public void AddDevice(int index, IPrintInformation si)
        {
            Console.WriteLine($"You have added a new device {index}| {si.GetName()}");
        }

        public bool CheckDisk(string device)
        {
            for (int i = 0; i < disks.Length; i++)
            {
                if (disks[i].GetName() == device)
                {
                    return true;
                }
            }   

            return false;
        }

        public Comp(int countDisks, int countPrintDevice, Disk[] disks, IPrintInformation[] printDevices)
        { 
            this.countDisk = countDisks;
            this.countPrintDevive = countPrintDevice;
            this.disks = disks;
            this.printDevice= printDevices;
        }
 
        public void InsertReject(string device, bool b)
        {
            Console.WriteLine($"Inserting {device} is {(b ? "possibly" : "impossible")}");
        }

        public void PrintInfo(string text, string device)
        {
            Console.WriteLine($"Device: {device} - {text}");
        }

        public string ReadInfo(string device)
        {
            Console.WriteLine("Info has been read");
            return device;
        }

        public void ShowDisk()
        {
            Console.WriteLine("Showing disk...");
        }

        public void ShowPrintDevice()
        {
            Console.WriteLine("Devices info: ");
            for (int i = 0; i < printDevice.Length; i++)
            {
                Console.WriteLine(printDevice[i].GetName());
            }
        }

        public bool WriteInfo(string text, string showDevice)
        {
            Console.WriteLine($"{text} showing this device: {showDevice}");
            return true;
        }
    }
}
