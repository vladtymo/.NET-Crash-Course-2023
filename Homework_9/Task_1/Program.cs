namespace _01_Task
{
    internal interface IDisk
    {
        void Read();

        void Write();
    }
    internal interface IRemoveableDisk
    {
        bool HasDisk { get; }
        void Insert();
        void Reject();
    }
    internal interface IPrintInformation
    {
        void GetName();
        void Print(string str);
    }
    class Disk : IDisk
    {
        private string memory;
        private int memSize;
        public string Memory { get; set; }
        public int MemSize { get; set; }

        public Disk() { }

        public Disk(string memory, int memSize)
        {
            this.memory = memory;
            this.memSize = memSize;
        }

        public string GetName(string name)
        {
            return name;
        }

        public void Read()
        {
            Console.WriteLine("WOW");
        }

        public void Write()
        {
            Console.WriteLine("LOL");
        }
    }

    class CD : Disk, IRemoveableDisk
    {
        private bool hasDisk;
        public bool HasDisk { get; set; }

        public void GetName()
        {
            Console.WriteLine("Name");
        }
        public void Insert()
        {
            Console.WriteLine("Insert");
        }

        public void Reject()
        {
            Console.WriteLine("Reject");
        }

    }

    class Flash : Disk, IRemoveableDisk
    {
        private bool hasDisk;
        public bool HasDisk { get; set; }
        public void GetName()
        {
            Console.WriteLine("Name");
        }

        public void Insert()
        {
            Console.WriteLine("Insert");
        }

        public void Reject()
        {
            Console.WriteLine("Reject");
        }

    }

    class HDD : Disk
    {
        public void GetName() 
        {
            Console.WriteLine("Name");
        }   
    }

    class DVD : Disk, IRemoveableDisk
    {
        private bool hasDisk;
        public bool HasDisk { get; set; }
        public void GetName()
        {
            Console.WriteLine("Name");
        }

        public void Insert()
        {
            Console.WriteLine("Insert");
        }

        public void Reject()
        {
            Console.WriteLine("Reject");
        }

    }

    class Printer : IPrintInformation
    {
        public void GetName()
        {
            Console.WriteLine("Name");
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }

    class Monitor : IPrintInformation
    {
        public void GetName()
        {
            Console.WriteLine("Name");
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }

    class Comp
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
            Console.WriteLine("InsertReject");
        }
        public bool PrintInfo(string text, string device) 
        {
            Console.WriteLine("Printed TEXT");
            return true;
        }
        public static string ReadInfo(string device) 
        {
            Console.WriteLine("Rad Info");
            return device;
        }
        public void ShowDisk()
        {
            Console.WriteLine("Show Disk");
        }
        public void ShowPrintDevice() 
        {
            Console.WriteLine("Show Print Device");
        }
        public bool WriteInfo(string text, string showDevice) 
        {
            Console.WriteLine(text);
            return true;
        }
    }
    internal class Program
    {
        static void Read(IDisk item)
        {
            item.Read();
        }
        static void Write(IDisk item)
        {
            item.Write();
        }
        static void Insert(IRemoveableDisk item)
        {
            item.Insert();
        }
        static void Reject(IRemoveableDisk item)
        {
            item.Reject();
        }
        static void GetName(IPrintInformation item)
        {
            item.GetName();
        }
        static void Print(string str)
        { Console.WriteLine(str); }

        static void Main(string[] args)
        {
            Disk disk = new Disk("DDR4", 4);
            //IDisk idisk = new IDisk(disk);

            Write(disk);

            DVD diskDVD = new DVD();
            Insert(diskDVD);

            Printer printer= new Printer();
            Print("alks");

            Comp comp = new Comp(1,2);
            comp.WriteInfo("wdqwdq", "Printer");

        }
    }
}
