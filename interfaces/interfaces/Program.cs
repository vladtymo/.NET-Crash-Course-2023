namespace crash_course_oop_intarfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD();
            DVD dvd = new DVD();
            Flash flash= new Flash();
            HDD hdd = new HDD();

            Printer printer= new Printer();
            Monitor monitor = new Monitor();

            IPrintInformation[] printDevices = { printer, monitor };
            Disk[] disks = { cd, dvd, flash, hdd };

            Comp comp = new Comp(3, 1, disks, printDevices);
            bool isChecked = comp.CheckDisk("Disk");
            Console.WriteLine(isChecked ? "This disk is existing" : "No information about this disk");
            comp.ShowDisk();
            comp.AddDevice(1, printDevices[0]);
            comp.InsertReject("Flash", true);
            comp.PrintInfo("it is DVD disk for saving video datas", dvd.GetName());
            comp.ShowPrintDevice();

        }
    }
}