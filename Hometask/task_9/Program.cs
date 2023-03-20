namespace task_9
{

    internal interface IDisk
    {
         string Read();
         void Write(string text);
    }

    internal interface IRemoveableDisk
    {
         bool HasDisk { get;}
         void Insert();
         void Reject();
    }

    internal interface IPrintInformation
    {
         string GetName();
         void Print(string str);
    }

    class Printer : IPrintInformation
    {
        public string GetName()
        {
            throw new NotImplementedException();
        }

        public void Print(string str)
        {
            throw new NotImplementedException();
        }
    }

    class Monitor : IPrintInformation
    {
        public string GetName()
        {
            throw new NotImplementedException();
        }

        public void Print(string str)
        {
            throw new NotImplementedException();
        }
    }

    class Disk : IDisk
    {
        private string memory;
        private int memSize;
        public int MemSize { get; set; }
        public string Memoty { get; set; }

        public Disk(string memory, int memSize)
        {
            this.memory = memory;
            this.memSize = memSize > 0 ? memSize : 0;
        }

        public Disk()
        {
            memory = "Disk1";
            memSize = 100;
        }

        public string GetName()
        {
            return memory;
        }

        public string Read()
        {
            return "Readed";
        }

        public void Write(string text)
        {
            Console.WriteLine("Text\n");
        }
    }
    class DVD : Disk, IRemoveableDisk
    {
        private bool hasDisk;
        
        public bool HasDisk { get; set; }

        public void Insert()
        {
            Console.WriteLine("Insert DVD\n");
        }

        public void Reject()
        {
            Console.WriteLine("Reject DVD disk");
        }
    }
    class HDD : Disk
    {
        public new string GetName()
        {
            return "HDD disk";
        }
    }
    class Flash : Disk, IRemoveableDisk
    {
        private bool hasDisk;
        public bool HasDisk { get; set; }
        
        public new string GetName()
        {
            return "Flash disk";
        }

        public void Insert()
        {
            Console.WriteLine("Insert flash disk");
        }

        public void Reject()
        {
            Console.WriteLine("Reject flash disk");
        }
    }
    class CD : Disk, IRemoveableDisk
    {
        private bool hasDisk;
        public bool HasDisk { get; set; }
        public new string GetName()
        {
            return "CD disk";
        }

        public void Insert()
        {
            Console.WriteLine("Insert CD disk");
        }

        public void Reject()
        {
            Console.WriteLine("Reject CD disk");
        }
    }

    class Comp
    {
        private int countDisk;
        private int countPrintDevice;
        private Disk[] disk;
        private IPrintInformation[] printDevice;

        public void AddDevice(int index, IPrintInformation sl)
        {
            Console.WriteLine("Add device");


        }
        public void AddDisk(int index, Disk d)
        {
            Console.WriteLine("Add disk");

        }

        public bool CheckDisk(string device)
        {
            return false;
        }
        public Comp(int d, int pd)
        {
            this.countDisk = d;
            this.countPrintDevice = pd;
        }
        public void InsertReject(string device, bool b)
        {
            if (b)
                Console.WriteLine($"{device} insert");
            else
                Console.WriteLine($"{device} reject");
        }

        public bool PrintInfo(string text, string device)
        {
            return false;
        }
        public string ReadInfo(string device) 
        {
            return device;
        }

        public void ShowDisk()
        {
            Console.WriteLine("Disk was shown");
        }
        public void ShowPrintDevice() 
        {
            Console.WriteLine("Print all device");
        }
        public bool WriteInfo(string text, string ShowDevice) 
        {
            return true;
        }

    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Comp comp = new Comp(10,15);
            Flash flash= new Flash();
            HDD hdd = new HDD();
            DVD dvd = new DVD();
            CD cd = new CD();
            Monitor monitor = new Monitor();
            Printer printer = new Printer();
            comp.AddDisk(0, flash);
            comp.AddDisk(1, hdd);
            comp.AddDisk(2, dvd);
            comp.AddDisk(3, cd);
            comp.AddDevice(0, monitor);
            comp.AddDevice(1, printer);




        }
    }
}