namespace DZ9_1{
internal class Program
    {
        private static void Main(string[] args)
        {
            Disk d = new Disk("memory1",200,"D");
            Disk c = new Disk("memory2",100,"C");

            CD cd = new CD();
            Flash flash = new Flash();
            DVD dvd = new DVD();
            HDD hdd = new HDD();

        
            IPrintInformation monitor = new Monitor();
            IPrintInformation printer = new Printer();
            d.Write("mdmemory1");
            Console.WriteLine(d.Read());

            Comp comp = new Comp(3,2);
            comp.addDisk(0,d);
            comp.addDisk(1,c);
            comp.addDisk(2,cd);
            comp.ShowDisk();

            comp.addDevice(0,monitor);
            comp.addDevice(1,printer);
            comp.PrintInfo();
        }
    }
}