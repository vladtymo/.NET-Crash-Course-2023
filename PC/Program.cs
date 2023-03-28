using System;

namespace ConsoleApp1
{

    class Comp
    {

        private int countDisk;
        private int countPrintDevice;

        public Disk[] disks;
        public IPrintInformation[] printDevice;



        public void AddDevice()
        {
            Console.WriteLine("Comp.AddDevice");
        }

        public void AddDisk()
        {
            Console.WriteLine("Comp.AddDisk");
        }

        public void CheckDisk()
        {
            Console.WriteLine("Comp.CheckDisk");
        }

        public Comp()
        {

        }

        public void InsertReject()
        {
            Console.WriteLine("Comp.InsertReject");
        }

        public void PrintInfo()
        {
            Console.WriteLine("Comp.PrintInfo");
        }

        public void ReadInfo()
        {
            Console.WriteLine("Comp.ReadInfo");
        }

        public void ShowDisk()
        {
            Console.WriteLine("Comp.ShowDisk");
        }

        public void ShowPrintDevice()
        {
            Console.WriteLine("Comp.ShowPrintDevice");
        }

        public void WriteInfo()
        {
            Console.WriteLine("Comp.WriteInfo");
        }

    }


    internal interface IPrintInformation
    {
        void GetName();
        void Print();
    }


    class Printer : IPrintInformation
    {

        public void GetName()
        {
            Console.WriteLine("Printer.GetName");
        }

        public void Print()
        {
            Console.WriteLine("Printer.Print");
        }
    }

    class Monitor : IPrintInformation
    {

        public void GetName()
        {
            Console.WriteLine("Monitor.GetName");
        }

        public void Print()
        {
            Console.WriteLine("Monitor.Print");
        }
    }











    internal interface IRemoveadleDisk
    {
        bool HasDisk { get; }
        void Insert();
        void Reject();
    }

    internal interface IDisk
    {
        void Read();
        void Write();
    }






    class Disk : IDisk
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

        public void GetName()
        {
            Console.WriteLine("Disk.GetName");
        }

        public void Read()
        {
            Console.WriteLine("Disk.Read");
        }

        public void Write()
        {
            Console.WriteLine("Disk.Write");
        }
    }

    class CD : Disk, IRemoveadleDisk
    {

        private bool hasDisk;
        public bool HasDisk { get; }

        public void GetName()
        {
            Console.WriteLine("CD.GetName");
        }

        public void Insert()
        {
            Console.WriteLine("CD.Insert");
        }

        public void Reject()
        {
            Console.WriteLine("CD.Reject");
        }
    }



    class Flash : Disk, IRemoveadleDisk
    {

        private bool hasDisk;
        public bool HasDisk { get; }

        public void GetName()
        {
            Console.WriteLine("Flash.GetName");
        }

        public void Insert()
        {
            Console.WriteLine("Flash.Insert");
        }

        public void Reject()
        {
            Console.WriteLine("Flash.Reject");
        }
    }




    class HDD : Disk
    {

        public void GetName()
        {
            Console.WriteLine("HDD.GetName");
        }

    }



    class DVD : Disk, IRemoveadleDisk
    {

        private bool hasDisk;
        public bool HasDisk { get; }

        public void GetName()
        {
            Console.WriteLine("DVD.GetName");
        }

        public void Insert()
        {
            Console.WriteLine("DVD.Insert");
        }

        public void Reject()
        {
            Console.WriteLine("DVD.Reject");
        }
    }

    class Program
    {

        static void Test(IRemoveadleDisk item)
        {
            item.Insert();
        }
        static void Main(string[] args)
        {
            Comp comp = new Comp();
            Disk disk = new Disk();
            CD cD = new CD();
            Flash flash = new Flash();
            DVD dvd = new DVD();


            Test(cD);
            Test(flash);
            Test(dvd);
        }
    }
}