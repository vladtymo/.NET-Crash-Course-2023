internal class Comp 
{
    private int countDisk;
    private int countPriceDevice;
    private Disk[] disks;
    private IPrintInformation[] printDevices;

    public Comp(int d, int pd)
    {
        this.countDisk = d;
        this.countPriceDevice = pd;
        this.disks = new Disk[d];
        this.printDevices = new IPrintInformation[pd];
    }
    public void addDevice(int index,IPrintInformation si){
        printDevices[index] = si;
    }
    public void addDisk(int index,Disk d){
        disks[index] = d;
    }
    public bool CheckDisk(string device){
        foreach (Disk disk in disks)
        {
           if(disk.GetName() == device){return true;};
        }
        return false;
    }
    public void InsertReject(string device, bool b) 
    {
        foreach(IRemovableDisk disk in disks)
        {
            if (disk.GetName() == device)
            {
                if (b)
                {
                    disk.Insert();
                }
                else
                {
                    disk.Reject();
                }
            }
        }
    }
    public void PrintInfo() 
    {
        foreach (IPrintInformation printDevice in printDevices)
        {
            printDevice.Print(printDevice.GetName());
                
        }
        
    }
    public string ReadInfo(string device) 
    {
        foreach (Disk disk in disks)
        {
            if (disk.GetName() == device){return disk.Read();}
        }
        return "Error, can't find device";
    }
    public void ShowDisk()
    {
        foreach (Disk disk in disks)
        {
            Console.WriteLine(disk.GetName());
        }  
    }
    public bool WriteInfo(string text, string device)
    {
        foreach (Disk disk in disks)
        {
            if (disk.GetName() == device){
                disk.Write(text); 
                return true;
            }
                
        }
        return false;
    }
}