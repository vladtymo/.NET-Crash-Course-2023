using System;


public class Task
{
    interface IDisk
    {
        string Read(); 
        void Write(string text);
    }
    interface IRemoveableDisk
    { 
        bool HasDisk { get; }
        void Insert();
        void Reject();
    }
    interface IPrintInformation
    {
        string GetName();
        void Print(string str);
    }

    class Comp
    {
        int countDisk=0;
        int countPrintDevice=0;
        Disk[] disks;
        IPrintInformation[] printDevice ;

        public void AddDevice(int index,IPrintInformation si) { printDevice[index] = si; }
        public void AddDisk(int index,Disk disk) { disks[index] = disk; }
        public bool CheckDisk(string device) { return false; }
        public Comp(int d,int pd) { }
        public void InsertReject(string device,bool b) { }
        public bool PrintInfo (string text,string device) { return false; }
        public string ReadInfo(string device) { return null; }
        public void ShowDisk() { }
        public void ShowPrintDevice() { }
        public bool WriteInfo(string text,string showDevice) { return false; }
    }
    class Disk : IDisk
    {
        string memory;
        int memSize;
        public string Memory { get; set; }
        public int MemSize { get; set; }

        public Disk() { }
        public Disk(string memory,int memSize) { }

        public string GetName() { return null; }
        public string Read() { return null; }
        public void Write(string text) { }

    }
    class CD : Disk , IRemoveableDisk
    {
        bool hasDisk;
        public bool HasDisk { get; }
        public string GetName() { return null; }
        public void Insert() { }
        public void Reject() { }
    }
    class Flash : Disk, IRemoveableDisk
    {
        bool hasDisk;
        public bool HasDisk { get; }
        public string GetName() { return null; }
        public void Insert() { }
        public void Reject() { }
    }
    class HDD : Disk
    {
        public string GetName() { return null; }
    }
    class DVD : Disk, IRemoveableDisk
    {
        bool hasDisk;
        public bool HasDisk { get; }
        public string GetName() { return null; }
        public void Insert() { }
        public void Reject() { }
    }

    class Printer :IPrintInformation
    {
        public string GetName() { return null; }
        public void Print(string str) { }
    }
    class Monitor : IPrintInformation
    {
        public string GetName() { return null; }
        public void Print(string str) { }
    }


    public static void Main(string[] args)
    {
    }
}