using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09_task1
{
    internal class Comp
    {
        private int countDisk;
        private int countPrintDevice;
        private Disk[] disks;
        private IPrintInformation[] printDevice;

        public void AddDevice(int index, IPrintInformation si)
        {
            Console.WriteLine("Added device!!!");
        }
        public void AddDisk(int index, Disk d)
        {
            Console.WriteLine("Added disk!!!");
        }
        public bool CheckDisk(string device)
        {
            return true;
        }
        public Comp(int d, int pd)
        {
            this.countDisk = d;
            this.countPrintDevice = pd;
        }
        public void InsetReject(string device, bool b)
        {
            Console.WriteLine("Method InsertReject in class Comp");
        }
        public bool PrintInfo(string text, string device) 
        {
            Console.WriteLine($"Printed TEXT:\"{text}\"");
            return true;
        }
        public static string ReadInfo(string device) 
        {
            Console.WriteLine("Method Redd Info in class Comp");
            return device;
        }
        public void ShowDisk()
        {
            Console.WriteLine("I Show the Disk");
        }
        public void ShowPrintDevice() 
        {
            Console.WriteLine("I Show the Print Device");
        }
        public bool WriteInfo(string text, string showDevice) 
        {
            Console.WriteLine($"Writed text:\"{text}\"");
            return true;
        }
    }
}
