using System.Drawing;

namespace _17_polymorphism
{
    interface ICanReset
    {
        void Reset();
    }

    public class Device
    {
        public string Model { get; set; }
        public Size Size { get; set; }
        public string Color { get; set; }
        public bool IsPowerOn { get; set; }

        public void ShowStatus()
        {
            Console.WriteLine($"Device is currently {(IsPowerOn ? "ON" : "OFF")}");
        }

        // realize polymorphism by using keywords: virtual, override
        // virtual - we can override these methods in the derived classes
        public virtual void DoWork()
        {
            Console.WriteLine("...");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Model: {Model}, {Size.Height}x{Size.Width}, {Color}");
        }
    }

    public class Router : Device, ICanReset
    {
        public string WiFiGen { get; set; }
        public float Frequency { get; set; }
        public int Antennas { get; set; }

        public void Reset()
        {
            Console.WriteLine("Reseting router to the default settings...");
        }

        // override - override the base class method (polymorphism) 
        public override void DoWork()
        {
            Console.WriteLine($"Transfering data between connected devices with Wi-Fi {WiFiGen}...");
        }

        // new - hide the base class method
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Wi-Fi Generation: {WiFiGen}, {Frequency}Ghz with {Antennas} antennas");
        }
    }

    public class Printer : Device, ICanReset
    {
        public int Cartridges { get; set; }
        public int TotalPages { get; set; }

        public void Refuel()
        {
            Console.WriteLine($"Refueling the all {Cartridges} cartridges...");
        }

        public override void DoWork()
        {
            Console.WriteLine($"Printing the {TotalPages}th document...");
            ++TotalPages;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Cartridges: {Cartridges}\n" +
                $"Total printed pages: {TotalPages}");
        }

        public void Reset()
        {
            Console.WriteLine("Reseting statistics data to default values...");
            TotalPages = 0;
        }
    }

    internal class Program
    {
        static void TestWork(Device device)
        {
            Console.WriteLine(new String('-', 45));
            device.ShowInfo();
            device.ShowStatus();
            if (!device.IsPowerOn)
            {
                Console.WriteLine("Turning the device on...");
                device.IsPowerOn = true;
            }
            device.DoWork();
        }
        static void Main(string[] args)
        {
            Printer printer = new Printer()
            {
                Color = "Black",
                Cartridges = 5,
                IsPowerOn = true,
                Model = "Canon Pixma MG500",
                Size = new Size(35, 40),
                TotalPages = 129
            };

            Router router = new Router()
            {
                Color = "White",
                Frequency = 2.4F,
                WiFiGen = "5 gen",
                Antennas = 4,
                IsPowerOn = false,
                Model = "TP-Link GH6565",
                Size = new Size(15, 22)
            };

            // dynamic polymorphism
            Device device = printer;

            device.DoWork();
            router.DoWork();

            TestWork(printer);
            TestWork(router);

            // array of devices
            Device[] devices = new Device[]
            {
                printer,
                router,
                new Router()
                {
                    Frequency = 5, WiFiGen = "6 gen", Antennas = 2, Color = "Grey", Model = "Xiaomi YT"
                },
                new Printer()
                {
                    Color = "Dark Blue",
                    Cartridges = 4,
                    Model = "Samsung FG4",
                    TotalPages = 43
                }
            };

            Console.WriteLine(new String('=', 45) + "\nArray of devices:");
            foreach (var item in devices)
            {
                item.DoWork(); // invoke a specific method realizaiton
            }
        }
    }
}