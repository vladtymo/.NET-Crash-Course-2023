using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{

    public interface IRemoveableDisk
    {
        public bool HasDisk { get; }

        void Insert();
        void Reject();
    }

    public interface IDisk
    {
        string Read();
        void Write(string text);
    }

    public interface IPrintInformation
    {
        string GetName();
        void Print(string str);
    }

    public class Disk : IDisk
    {
        string memory;
        int memSize;

        public string Memory { get; set; }
        public int MemSize { get; set; }

        public Disk() { }
        public Disk(string memory, int memSize)
        {
            this.memory = memory;
            this.memSize = memSize;
        }
        public string GetName() { return GetName(); }
        public string Read() { return Read(); }
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }

    public class Printer : IPrintInformation
    {
        public string GetName() { return GetName(); }
        public void Print(string str) { Console.WriteLine(str); }
    }

    public class Monitor : IPrintInformation
    {
        public string GetName() { return GetName(); }
        public void Print(string str) { Console.WriteLine(str); }
    }

    public class CD : Disk, IRemoveableDisk
    {
        bool hasDisk;
        public bool HasDisk { get { return hasDisk;} }

        public string GetName() { return GetName(); }
        public void Insert() { }
        public void Reject() { }
    }

    public class Flash : Disk, IRemoveableDisk
    {
        bool hasDisk;
        public bool HasDisk { get { return hasDisk; } }

        public string GetName() { return GetName(); }
        public void Insert() { }
        public void Reject() { }
    }

    public class HDD : Disk
    {
        public string GetName() { return GetName(); }
    }

    public class DVD : Disk, IRemoveableDisk
    {
        bool hasDisk;
        public bool HasDisk { get { return hasDisk; } }
        public string GetName() { return GetName(); }
        public void Insert() { }
        public void Reject() { }
    }

    public class Comp
    {
        public int countDisk;
        public int countPrintDevice;
        public Disk[] disks;
        public IPrintInformation[] printDevice;
        public void AddDevice(int index, IPrintInformation si)
        {
            printDevice[index] = si;
        }
        public bool CheckDisk(string device)
        {
            return true;
        }
        public Comp(int d, int pd)
        {
            this.disks = new Disk[d];
            this.countDisk = d;
            this.countPrintDevice = pd;
            this.printDevice = new IPrintInformation[pd];
        }

        public void InsertReject(string device, bool b)
        {
            
        }

        public bool PrintInfo(string text, string device)
        {
            return true;
        }
        public string ReadInfo(string device)
        {
            return ReadInfo(device);
        }
        public void ShowDisk()
        {

        }

        public void ShowPrintDevice() { }
        public bool WriteInfo(string text, string ShowDevice)
        {
            return true;
        }


    }


    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
