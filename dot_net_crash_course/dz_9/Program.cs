namespace dz_9
{
    interface IRemoveableDisk
    {
        public bool HasDisk { get; }
        public void Insert();

        public void Reject();
    }

    interface IDisk
    {
        public string Read();

        public void Write(string text);
    }

    class Disk : IDisk
    {
        private int memSize;

        public int MemSize
        {
            get { return memSize; }
            set { memSize = value; }
        }

        private string memory;

        public string Memory
        {
            get { return memory; }
            set { memory = value; }
        }

        public string GetName()
        {
            return "Name: Disk";
        }

        public string Read()
        {
            return "Reading successed!";
        }

        public void Write(string text)
        {
            Console.WriteLine(text);
        }

        public Disk()
        {
            memSize = 0;
            memory = "";
        }
        public Disk(string memory, int memSize)
        {
            this.memory = memory;
            this.memSize = memSize;
        }
    }

    class CD : Disk, IRemoveableDisk
    {
        private bool hasDisk;
        public bool HasDisk { get { return hasDisk; } }

        new public string GetName()
        {
            return "Name: CD";
        }

        public void Insert()
        {
            hasDisk = true;
        }

        public void Reject()
        {
            hasDisk = false;
        }

    }

    class Flash : Disk, IRemoveableDisk
    {
        private bool hasDisk;
        public bool HasDisk { get { return hasDisk; } }

        new public string GetName()
        {
            return "Name: Flash";
        }

        public void Insert()
        {
            hasDisk = true;
        }

        public void Reject()
        {
            hasDisk = false;
        }
    }

    class HDD : Disk
    {
        new public string GetName()
        {
            return "Name: HDD";
        }
    }

    class DVD : Disk, IRemoveableDisk
    {
        private bool hasDisk;
        public bool HasDisk { get { return hasDisk; } }

        new public string GetName()
        {
            return "Name: DVD";
        }

        public void Insert()
        {
            hasDisk = true;
        }

        public void Reject()
        {
            hasDisk = false;
        }
    }

    interface IPrintInformation
    {
        public string GetName();

        public void Print(string str)
        {

            Console.WriteLine(str);
        }
    }

    class Printer : IPrintInformation
    {
        public string GetName()
        {
            return "Name: Printer";
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }

    class Monitor : IPrintInformation
    {
        public string GetName()
        {
            return "Name: Monitor";
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
            printDevice[index] = si;
            Console.WriteLine("Device added.");
        }

        public void AddDisk(int index, Disk d)
        {
            disks[index] = d;
            Console.WriteLine("Disk added.");
        }

        public bool CheckDisk(string device)
        {
            for (int i = 0 ; i < disks.Length; i++)
            {
                if (disks[i].Memory == device)
                {
                    Console.WriteLine("Disk exist in array");
                }
                else
                {
                    Console.WriteLine("Disk doesn't exist in array");
                }
            }
            
            return false;
        }

        public void InsertReject(string device, bool b)
        {
            Console.WriteLine("InsertReject");

        }

        public bool PrintInfo(string text, string device)
        {
            return false;
        }

        public string ReadInfo(string device)
        {
            return null;
        }

        public void ShowDisk()
        {
            foreach (Disk i in disks)
            {
                Console.WriteLine(i.GetName());
            }
        }

        public void ShowPrintDevice()
        {
            foreach (IPrintInformation i in printDevice)
            {
                Console.WriteLine(i.GetName());
            }
        }

        public bool WriteInfo(string text, string showDevice)
        {
            return false;
        }

        public Comp(int d, int pd)
        {
            countDisk = d;
            countPrintDevice = pd;
            disks = new Disk[countDisk];
            printDevice = new IPrintInformation[countPrintDevice];
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Comp computer = new Comp(5,2);

            Disk disk = new Disk();
            HDD hdd = new HDD();
            CD cd = new CD();
            Flash flash = new Flash();
            DVD dvd = new DVD();

            Monitor monitor = new Monitor();
            Printer printer = new Printer();

            disk.Write("Disk Write");
            dvd.Write("DVD Write");

            computer.AddDisk(0, disk);
            computer.AddDisk(1, hdd);
            computer.AddDisk(2, cd);
            computer.AddDisk(3, flash);
            computer.AddDisk(4, dvd);

            computer.AddDevice(0, monitor);
            computer.AddDevice(1, printer);

            computer.ShowDisk();
            computer.ShowPrintDevice();


        }
    }
}