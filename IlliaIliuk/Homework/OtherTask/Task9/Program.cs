namespace OtherTask.Task9
{
    internal class Program
    {
        static void Main()
        {
            Comp comp = new(2, 2);

            comp.AddDisk(0, new Flash());
            comp.AddDisk(1, new CD());


            comp.AddDevice(0, new Printer());
            comp.AddDevice(1, new Monitor());

            Console.WriteLine(comp.Disks[0].GetName());
            Console.WriteLine(comp.Disks[1].GetName());
            Console.WriteLine(comp.PrintDevice[0].GetName());
            Console.WriteLine(comp.PrintDevice[1].GetName());
            Console.WriteLine(comp.ReadInfo("f"));
        }
        
    }
}
