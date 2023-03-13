using System;
using System.Reflection;

//Task 1
//namespace project
//{
//    internal interface IDisk
//    {
//        void Read();
//        void Write();
//    }

//    internal interface IRemoveableDisk
//    {
//        bool HasDisk { get; }
//        void Insert();
//        void Reject();
//    }

//    internal interface IPrintInformation
//    {
//        void GetName();
//        void Print(string str);
//    }

//    class Disk : IDisk
//    {
//        private string memory;
//        private int memSize;
//        public string Memory { get; set; }
//        public int MemSize { get; set; }

//        public Disk() { }

//        public Disk(string memory, int memSize)
//        {
//            this.memory = memory;
//            this.memSize = memSize;
//        }

//        public string GetName(string name)
//        {
//            return name;
//        }

//        public void Read()
//        {
//            Console.WriteLine("WOW");
//        }

//        public void Write()
//        {
//            Console.WriteLine("LOL");
//        }
//    }

//    class CD : Disk, IRemoveableDisk
//    {
//        private bool hasDisk;
//        public bool HasDisk { get; set; }

//        public void GetName()
//        {
//            Console.WriteLine("Name");
//        }

//        public void Insert()
//        {
//            Console.WriteLine("Insert");
//        }

//        public void Reject()
//        {
//            Console.WriteLine("Reject");
//        }
//    }

//    class Flash : Disk, IRemoveableDisk
//    {
//        private bool hasDisk;
//        public bool HasDisk { get; set; }

//        public void GetName()
//        {
//            Console.WriteLine("Name");
//        }

//        public void Insert()
//        {
//            Console.WriteLine("Insert");
//        }

//        public void Reject()
//        {
//            Console.WriteLine("Reject");
//        }
//    }

//    class HDD : Disk
//    {
//        public void GetName()
//        {
//            Console.WriteLine("Name");
//        }
//    }

//    class DVD : Disk, IRemoveableDisk
//    {
//        private bool hasDisk;
//        public bool HasDisk { get; set; }

//        public void GetName()
//        {
//            Console.WriteLine("Name");
//        }

//        public void Insert()
//        {
//            Console.WriteLine("Insert");
//        }

//        public void Reject()
//        {
//            Console.WriteLine("Reject");
//        }
//    }

//    class Printer : IPrintInformation
//    {
//        public void GetName()
//        {
//            Console.WriteLine("Name");
//        }

//        public void Print(string str)
//        {
//            Console.WriteLine(str);
//        }
//    }

//    class Monitor : IPrintInformation
//    {
//        public void GetName()
//        {
//            Console.WriteLine("Name");
//        }

//        public void Print(string str)
//        {
//            Console.WriteLine(str);
//        }
//    }

//    class Comp
//    {
//        private int countDisk;
//        private int countPrintDevice;
//        private Disk[] disks;
//        private IPrintInformation[] printDevice;

//        public void AddDevice(int index, IPrintInformation si)
//        {
//            Console.WriteLine("Added device!!!");
//        }

//        public void AddDisk(int index, Disk d)
//        {
//            Console.WriteLine("Added disk!!!");
//        }

//        public bool CheckDisk(string device)
//        {
//            return true;
//        }

//        public Comp(int d, int pd)
//        {
//            this.countDisk = d;
//            this.countPrintDevice = pd;
//        }

//        public void InsetReject(string device, bool b)
//        {
//            Console.WriteLine("InsertReject");
//        }

//        public bool PrintInfo(string text, string device)
//        {
//            Console.WriteLine("Printed TEXT");
//            return true;
//        }

//        public static string ReadInfo(string device)
//        {
//            Console.WriteLine("Rad Info");
//            return device;
//        }

//        public void ShowDisk()
//        {
//            Console.WriteLine("Show Disk");
//        }

//        public void ShowPrintDevice()
//        {
//            Console.WriteLine("Show Print Device");
//        }

//        public bool WriteInfo(string text, string showDevice)
//        {
//            Console.WriteLine(text);
//            return true;
//        }
//    }
//    internal class Program
//    {
//        static void Read(IDisk item)
//        {
//            item.Read();
//        }

//        static void Write(IDisk item)
//        {
//            item.Write();
//        }

//        static void Insert(IRemoveableDisk item)
//        {
//            item.Insert();
//        }

//        static void Reject(IRemoveableDisk item)
//        {
//            item.Reject();
//        }

//        static void GetName(IPrintInformation item)
//        {
//            item.GetName();
//        }

//        static void Print(string str)
//        {
//            Console.WriteLine(str);
//        }

//        static void Main(string[] args)
//        {
//            Disk disk = new Disk("DDR4", 4);
//            //IDisk idisk = new IDisk(disk);
//            Write(disk);
//            DVD diskDVD = new DVD();
//            Insert(diskDVD);
//            Printer printer = new Printer();
//            Print("alks");
//            Comp comp = new Comp(1, 2);
//            comp.WriteInfo("wdqwdq", "Printer");
//        }
//    }
//}

//Task 2
namespace project
{
    internal interface IPrintable
    {
        void PrintInfo();
    }

    internal interface IShowSpeed
    {
        double MaxSpeed { get; }
        void SpeedInfo();
    }

    internal interface IShowPrice
    {
        double Price { get; }
        void PriceInfo();
    }

    class Transport : IPrintable
    {
        public double MaxSpeed { get; set; }
        public double Power { get; set; }
        public double Price { get; set; }
        public Transport() { }

        public Transport(double maxSpeed, double power, double price)
        {
            this.MaxSpeed = maxSpeed;
            this.Power = power;
            this.Price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Transport has {Power}wt, its max speed is {MaxSpeed}, and price = {Price}");
        }
    }

    class Car : Transport, IPrintable, IShowSpeed, IShowPrice
    {
        public string Model { get; set; }
        public DateOnly DateOfRelease { get; }
        public string TypeOfTransport { get; }

        public Car(string model, DateOnly dateOfRelease, double MaxSpeed, double Power, double Price, string typeOfTransport) : base(MaxSpeed, Power, Price)
        {
            Model = model;
            DateOfRelease = dateOfRelease;
            TypeOfTransport = typeOfTransport;
        }

        public void PrintInfo()
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"{Model} is released on {DateOfRelease} and this is {TypeOfTransport}");
            base.PrintInfo();
            Console.WriteLine(new String('-', 40));
        }

        public void SpeedInfo()
        {
            if (MaxSpeed > 250) Console.WriteLine($"Wow, this is so fast. Speed of {Model} are {MaxSpeed}");
            else Console.WriteLine($"This is normal speed. Speed of {Model} are {MaxSpeed}");
        }

        public void PriceInfo()
        {
            if (Price > 50000) Console.WriteLine($"Wow, this is luxury transport. The price of {Model} are {Price}");
            else Console.WriteLine($"This is normal price. The price of {Model} are {Price}");
        }
    }

    class Plane : Transport, IPrintable, IShowSpeed, IShowPrice
    {
        public string Model { get; set; }
        public DateOnly DateOfRelease { get; }
        public string TypeOfTransport { get; }

        public Plane(string model, DateOnly dateOfRelease, double MaxSpeed, double Power, double Price, string typeOfTransport) : base(MaxSpeed, Power, Price)
        {
            Model = model;
            DateOfRelease = dateOfRelease;
            TypeOfTransport = typeOfTransport;
        }

        public void PrintInfo()
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"{Model} is released on {DateOfRelease} and this is {TypeOfTransport}");
            base.PrintInfo();
            Console.WriteLine(new String('-', 40));
        }

        public void SpeedInfo()
        {
            if (MaxSpeed > 250) Console.WriteLine($"Wow, this is so fast. Speed of {Model} are {MaxSpeed}");
            else Console.WriteLine($"This is normal speed. Speed of {Model} are {MaxSpeed}");
        }

        public void PriceInfo()
        {
            if (Price > 50000) Console.WriteLine($"Wow, this is luxury transport. The price of {Model} are {Price}");
            else Console.WriteLine($"This is normal price. The price of {Model} are {Price}");
        }
    }

    class Motocycle : Transport, IPrintable, IShowSpeed, IShowPrice
    {
        public string Model { get; set; }
        public DateOnly DateOfRelease { get; }
        public string TypeOfTransport { get; }

        public Motocycle(string model, DateOnly dateOfRelease, double MaxSpeed, double Power, double Price, string typeOfTransport) : base(MaxSpeed, Power, Price)
        {
            Model = model;
            DateOfRelease = dateOfRelease;
            TypeOfTransport = typeOfTransport;
        }

        public void PrintInfo()
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"{Model} is released on {DateOfRelease} and this is {TypeOfTransport}");
            base.PrintInfo();
            Console.WriteLine(new String('-', 40));
        }

        public void SpeedInfo()
        {
            if (MaxSpeed > 250) Console.WriteLine($"Wow, this is so fast. Speed of {Model} are {MaxSpeed}");
            else Console.WriteLine($"This is normal speed. Speed of {Model} are {MaxSpeed}");
        }

        public void PriceInfo()
        {
            if (Price > 50000) Console.WriteLine($"Wow, this is luxury transport. The price of {Model} are {Price}");
            else Console.WriteLine($"This is normal price. The price of {Model} are {Price}");
        }
    }

    class Horse : Transport, IPrintable, IShowSpeed, IShowPrice
    {
        public string Breed { get; set; }
        public DateOnly DateOfBirth { get; }
        public string TypeOfTransport { get; }

        public Horse(string breed, DateOnly dateOfBirth, double MaxSpeed, double Power, double Price, string typeOfTransport) : base(MaxSpeed, Power, Price)
        {
            Breed = breed;
            DateOfBirth = dateOfBirth;
            TypeOfTransport = typeOfTransport;
        }

        public void PrintInfo()
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"{Breed} is bored on {DateOfBirth} and this is {TypeOfTransport}");
            base.PrintInfo();
            Console.WriteLine(new String('-', 40));
        }

        public void SpeedInfo()
        {
            if (MaxSpeed > 250) Console.WriteLine($"Wow, this is so fast. Speed of {Breed} are {MaxSpeed}");
            else Console.WriteLine($"This is normal speed. Speed of {Breed} are {MaxSpeed}");
        }

        public void PriceInfo()
        {
            if (Price > 50000) Console.WriteLine($"Wow, this is luxury transport. The price of {Breed} are {Price}");
            else Console.WriteLine($"This is normal price. The price of {Breed} are {Price}");
        }
    }

    internal class Program
    {
        static void PrintInfo(IPrintable item)
        {
            item.PrintInfo();
        }

        static void ShowFaster(IShowSpeed item, IShowSpeed item2, IShowSpeed item3, IShowSpeed item4)
        {
            Console.WriteLine("Function shows the fastest transport!");
            if (item.MaxSpeed > item2.MaxSpeed && item.MaxSpeed > item3.MaxSpeed && item.MaxSpeed > item4.MaxSpeed)
                item.SpeedInfo();
            else if (item2.MaxSpeed > item.MaxSpeed && item2.MaxSpeed > item3.MaxSpeed && item2.MaxSpeed > item4.MaxSpeed)
                item2.SpeedInfo();
            else if (item3.MaxSpeed > item.MaxSpeed && item3.MaxSpeed > item2.MaxSpeed && item3.MaxSpeed > item4.MaxSpeed)
                item3.SpeedInfo();
            else if (item4.MaxSpeed > item.MaxSpeed && item4.MaxSpeed > item2.MaxSpeed && item4.MaxSpeed > item3.MaxSpeed)
                item4.SpeedInfo();
        }

        static void ShowCheapest(IShowPrice item, IShowPrice item2, IShowPrice item3, IShowPrice item4)
        {
            Console.WriteLine("Function shows the cheapest transport!");
            if (item.Price < item2.Price && item.Price < item3.Price && item.Price < item4.Price)
                item.PriceInfo();
            else if (item2.Price < item.Price && item2.Price < item3.Price && item2.Price < item4.Price)
                item2.PriceInfo();
            else if (item3.Price < item.Price && item3.Price < item2.Price && item3.Price < item4.Price)
                item3.PriceInfo();
            else if (item4.Price < item.Price && item4.Price < item2.Price && item4.Price < item3.Price)
                item4.PriceInfo();
        }
        static void Main(string[] args)
        {
            Car car = new Car("Audi", new DateOnly(2010, 12, 02), 260, 12, 50000, "Car");
            Plane plane = new Plane("Boeing", new DateOnly(2000, 12, 24), 1000, 53, 14000000, "Plane");
            Motocycle motocycle = new Motocycle("Yamaha", new DateOnly(2010, 05, 14), 240, 25, 25000, "Moto");
            Horse horse = new Horse("Horse", new DateOnly(2003, 12, 24), 40, 1, 4000, "Horse");

            PrintInfo(car);
            Console.WriteLine();
            ShowFaster(car, plane, motocycle, horse);
            Console.WriteLine();
            ShowCheapest(car, plane, motocycle, horse);
        }
    }
}