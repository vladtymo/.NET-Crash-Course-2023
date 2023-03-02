using System.Collections.Generic;
using System.Data;

namespace HomeWork7
{
    interface IPrintInformation
    {
        string GetName();
        void Print(string str);
    }
    class Printer : IPrintInformation
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
        public string GetName()
        {
            return "Name is Printer #1";
        }
    }
    class Monitor : IPrintInformation
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
        public string GetName()
        {
            return "Name is Monitor #1";
        }
    }

    interface IDisk
    {
        void Write(string text);
        string Read();
    }
    class Disk : IDisk
    {
        string memory;
        int memSize;
        public string Memory { get; set; }
        public int MemSize { get; set; }
        public Disk()
        {
            this.memory = "Patriot memory 1x";
            this.memSize = 16000;
        }
        public Disk(string memory, int memSize)
        {
            this.memory = memory;
            this.memSize = memSize;
        }
        public string GetName()
        {
            return memory;
        }
        public string Read()
        {
            return "I read disk information";
        }
        public void Write(string text)
        {
            Console.WriteLine($"I write disk information: {text}");
        }
    }
    class Comp
    {
        int countDisk;
        int countPrintDevice;
        Disk[] disks;
        IPrintInformation printDevice;
        public void AddDevice(int index, IPrintInformation device)
        {
            if (index >= 0 && index < countPrintDevice)
            {
                Console.WriteLine("Add new device");
            }
            else
            {
                Console.WriteLine("Invalid index");
            }

        }
        public void AddDisk(int index, Disk d)
        {
            if (index >= 0 && index < countDisk)
            {
                disks[index] = d;
                Console.WriteLine($"Add new disk at index {index}");
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
        public bool CheckDisk(string device)
        {
            foreach (Disk d in disks)
            {
                if (d != null && d.GetName() == device)
                {
                    return true;
                }
            }
            return false;
        }
        public Comp(int d, int pd)
        {
            disks = new Disk[d]; // Initialize the disks array
            for (int i = 0; i < d; i++)
            {
                disks[i] = new Disk(); // Initialize each disk object
            }
            countDisk = d;
            countPrintDevice = pd;
        }
        public void InsertReject(string device, bool b)
        {
            if (CheckDisk(device))
            {
                if (b)
                {
                    Console.WriteLine($"Disk {device} inserted");
                }
                else
                {
                    Console.WriteLine($"Disk {device} rejected");
                }
            }
            else
            {
                Console.WriteLine($"Disk {device} not found");
            }
        }
        public bool PrintInfo(string text, string device)
        {
            if (text != null && text.Length > 0 && device != null && CheckDisk(device))
            {
                printDevice.Print(text);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string ReadInfo(string device)
        {
            if (device != null && CheckDisk(device))
            {
                return disks[0].Read();
            }
            else
            {
                return null;
            }
        }
        public void ShowDisk()
        {
            Console.WriteLine("i show disk ");
        }
        public void ShowPrintDevice()
        {
            Console.WriteLine("I show you information");
        }
        public bool WriteInfo(string text, string showDevice)
        {
            if (text != null && text.Length > 0)
            {
                disks[0].Write(text);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    interface IRemovableDisk
    {
        public bool HasDisk { get; }
        public void Insert();
        public void Reject();
    }
    class CD : IRemovableDisk
    {
        bool hasDisk;
        public bool HasDisk { get; private set; }
        public string GetName()
        {
            Console.WriteLine("Name is CD");
            return "CD";
        }
        public void Insert()
        {
            Console.WriteLine("Insert CD");
            HasDisk = true;
        }

        public void Reject()
        {
            Console.WriteLine("Reject CD");
            HasDisk = false;
        }
    }
    class Flash : IRemovableDisk

    {
        private bool hasDisk;
        public bool HasDisk
        {
            get { return hasDisk; }
            set { hasDisk = value; } // Встановлюємо значення приватної змінної
        }
        public string GetName()
        {
            return "Name is Flash";
        }
        public void Insert()
        {
            Console.WriteLine("We inserted flash");
            HasDisk = true;
        }
        public void Reject()
        {
            Console.WriteLine("Flash rejected");
            HasDisk = false;
        }
    }
    class HDD
    {
        public string GetName()
        {
            return "Name is HDD";
        }
    }
    class DVD : IRemovableDisk
    {
        public bool HasDisk { get; private set; }

        public string GetName()
        {
            return "name is DVD";
        }
        public void Insert()
        {
            Console.WriteLine("We inserted DVD");
            HasDisk = true;
        }
        public void Reject()
        {
            Console.WriteLine("DVD rejected");
            HasDisk = false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Comp comp = new Comp(5, 2);
            CD cd = new CD();
            Flash flash = new Flash();
            HDD hdd = new HDD();
            DVD dvd = new DVD();

            comp.AddDisk(0, new Disk("Samsung", 256));
            comp.AddDisk(1, new Disk("Seagate", 512));

            comp.AddDevice(0, new Printer());
            comp.AddDevice(1, new Monitor());

            comp.InsertReject("Samsung", true);
            comp.InsertReject("Seagate", false);

            cd.Insert();
            flash.Insert();
            dvd.Insert();

            Console.WriteLine(comp.WriteInfo("Information written to Samsung disk", "Samsung"));

            if (cd.HasDisk)
            {
                Console.WriteLine("CD has a disk");
            }
            else
            {
                Console.WriteLine("CD doesn't have a disk");
            }

            if (flash.HasDisk)
            {
                Console.WriteLine("Flash has a disk");
            }
            else
            {
                Console.WriteLine("Flash doesn't have a disk");
            }

            if (dvd.HasDisk)
            {
                Console.WriteLine("DVD has a disk");
            }
            else
            {
                Console.WriteLine("DVD doesn't have a disk");
            }
        }
    }
}