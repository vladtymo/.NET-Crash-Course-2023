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
            Console.WriteLine("Викликано метод Comp.AddDevice");
        }

        public void AddDisk()
        {
            Console.WriteLine("Викликано метод Comp.AddDisk");
        }

        public void CheckDisk()
        {
            Console.WriteLine("Викликано метод Comp.CheckDisk");
        }

        public  Comp()
        {
            
        }

        public void InsertReject()
        {
            Console.WriteLine("Викликано метод Comp.InsertReject");
        }

        public void PrintInfo()
        {
            Console.WriteLine("Викликано метод Comp.PrintInfo");
        }

        public void ReadInfo()
        {
            Console.WriteLine("Викликано метод Comp.ReadInfo");
        }

        public void ShowDisk()
        {
            Console.WriteLine("Викликано метод Comp.ShowDisk");
        }

        public void ShowPrintDevice()
        {
            Console.WriteLine("Викликано метод Comp.ShowPrintDevice");
        }

        public void WriteInfo()
        {
            Console.WriteLine("Викликано метод Comp.WriteInfo");
        }

    }


    internal interface IPrintInformation
    {
        void GetName();
        void Print();
    }


    class Printer:IPrintInformation
    {

        public void GetName()
        {
            Console.WriteLine("Викликано метод Printer.GetName");
        }

        public void Print()
        {
            Console.WriteLine("Викликано метод Printer.Print");
        }
    }

    class Monitor:IPrintInformation
    {

        public void GetName()
        {
            Console.WriteLine("Викликано метод Monitor.GetName");
        }

        public void Print()
        {
            Console.WriteLine("Викликано метод Monitor.Print");
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
            Console.WriteLine("Викликано метод Disk.GetName");
        }

        public void Read()
        {
            Console.WriteLine("Викликано метод Disk.Read");
        }

        public void Write()
        {
            Console.WriteLine("Викликано метод Disk.Write");
        }
    }

    class CD : Disk,IRemoveadleDisk
    {

        private bool hasDisk;
        public bool HasDisk { get; }

        public void GetName()
        {
            Console.WriteLine("Викликано метод CD.GetName");
        }

        public void Insert()
        {
            Console.WriteLine("Викликано метод CD.Insert");
        }

        public void Reject()
        {
            Console.WriteLine("Викликано метод CD.Reject");
        }
    }



    class Flash : Disk, IRemoveadleDisk
    {

        private bool hasDisk;
        public bool HasDisk { get; }

        public void GetName()
        {
            Console.WriteLine("Викликано метод Flash.GetName");
        }

        public void Insert()
        {
            Console.WriteLine("Викликано метод Flash.Insert");
        }

        public void Reject()
        {
            Console.WriteLine("Викликано метод Flash.Reject");
        }
    }




    class HDD : Disk
    {

        public void GetName()
        {
            Console.WriteLine("Викликано метод HDD.GetName");
        }

    }



    class DVD : Disk, IRemoveadleDisk
    {

        private bool hasDisk;
        public bool HasDisk { get; }

        public void GetName()
        {
            Console.WriteLine("Викликано метод DVD.GetName");
        }

        public void Insert()
        {
            Console.WriteLine("Викликано метод DVD.Insert");
        }

        public void Reject()
        {
            Console.WriteLine("Викликано метод DVD.Reject");
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
