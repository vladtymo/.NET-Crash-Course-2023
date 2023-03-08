namespace lab_09_task1
{
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
            Disk newDisk = new Disk("DDR3", 4);

            Write(neweDisk);

            DVD newDiskDVD = new DVD();
            Insert(newDiskDVD);

            Printer newPrinter= new Printer();
            Print("I can print text");

            Comp computer = new Comp(1,2);
            computer.WriteInfo("This is a string", "Printer");

        }
    }
}
