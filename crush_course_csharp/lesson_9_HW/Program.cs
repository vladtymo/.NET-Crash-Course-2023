namespace lesson_9_HW_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Comp newComp = new Comp(5, 2);
            Disk newDisk = new Disk();

            newComp.AddDisk(2, newDisk);

            IPrintInformation newDevice = new Printer();
            newComp.AddDevice(0, newDevice);

            newComp.WriteInfo("Дані про принтер", "Printer");
            newComp.PrintInfo("Дані з принтера", "Printer");
        }
    }
}