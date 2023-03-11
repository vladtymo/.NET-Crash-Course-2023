using System;

public interface IRemoveableDisk {
    public bool HasDisk {get;}

    public void Insert();
    public void Reject();
}

public interface IDisk{
    public string Read();
    public void Write(string text);
}

public interface IPrintInformation{
    public string GetName();
    public void Print(string str);
}

public class Comp{
    private int _countDisk;
    private int _countPrintDevice;
    private Disk[] _disks;
    private IPrintInformation[] _printDevice;

    public Comp(int d, int pd){
        _countDisk = d;
        _countPrintDevice = pd;
        _disks = new Disk[d];
        _printDevice = new IPrintInformation[pd];
    }

    public void AddDevice(int index, IPrintInformation si){
        _printDevice[index]= si;
    }

    public void AddDisk(int index, Disk d){
        _disks[index] = d;
    }

    public bool CheckDisk(string device){
        foreach (var disk in _disks){
            if(disk != null && disk.GetName() == device){
                return true;
            }
        }
        return false;
    }

    public void InsertReject(string device, bool b){
        foreach(var disk in _disks){
            if(disk != null && disk.GetName() == device){
                if(b){
                    if(disk is IRemoveableDisk removableDisk){
                        removableDisk.Insert();
                    }
                }
                else {
                    if(disk is IRemoveableDisk removableDisk){
                        removableDisk.Reject();
                    }
                }
            }
        }
    }

    public bool PrintInfo(string text, string device){
        foreach (var printDevice in _printDevice){
            if(printDevice != null && printDevice.GetName() == device){
                printDevice.Print(text);
                return true;
            }
        }
        return false;
    }

    public string ReadInfo(string device){
        foreach (var disk in _disks){
            if(disk != null && disk.GetName() == device){
                return disk.Read();
            }
        }
        return null;
    }

    public void ShowDisk(){
        Console.WriteLine("Disks: ");
        foreach(var disk in _disks){
            if(disk != null){
                Console.WriteLine(disk.GetName());
            }
        }
    }

    public void ShowPrintDevice(){
        Console.WriteLine("Devices: ");
        foreach(var printDevice in _printDevice){
            if(printDevice != null){
                Console.WriteLine(printDevice.GetName());
            }
        }
    }

    public bool WriteInfo(string text, string showDevice){
        foreach (var disk in _disks){
            if(disk != null && disk.GetName() == showDevice){
                disk.Write(text);
                return true;
            }
        }
        return false;
    }
}

public class Disk : IDisk{
    private string _memory;
    private int _memSize;

    public string Memory{
        get{return _memory;}
        set{_memory = value;}
    }

    public int MemSize{
        get{return _memSize; }
        set{_memSize = value;}
    }

    public Disk(){}

    public Disk(string memory, int memSize){
        memory = _memory;
        memSize = _memSize;
    }

    public string GetName(){
        return "Disk";
    }

    public string Read(){
        return _memory;
    }

    public void Write(string text){
        _memory = text;
    }
}

public class CD : Disk, IRemoveableDisk{
    private bool _hasDisk;
    public bool HasDisk{get;}

    public new string GetName(){
        return "CD";
    }

    public void Insert(){
        _hasDisk = true;
    }

    public void Reject(){
        _hasDisk = false;
    }
}

public class Flash : Disk, IRemoveableDisk{
    private bool _hasDisk;
    public bool HasDisk{get;}

    public new string GetName(){
        return "Flash";
    }
    public void Insert(){
        _hasDisk = true;
    }

    public void Reject(){
        _hasDisk = false;
    }
}

public class HDD : Disk{
    public new string GetName(){
        return "HDD";
    }
}

public class DVD : Disk, IRemoveableDisk{
    private bool _hasDisk;
    public bool HasDisk{get{return _hasDisk;}}

    public new string GetName(){
        return "DVD";
    }

    public void Insert(){
        _hasDisk = true;
    }

    public void Reject(){
        _hasDisk = false;
    }
}

class lesson_10_1{
    static void Main() {
        var comp = new Comp(2, 1);
        var cd = new CD();
        comp.AddDisk(0, cd);
        var flash = new Flash();
        comp.AddDisk(1, flash);
        comp.InsertReject("CD", true);
        comp.WriteInfo("Hello, CD!", "CD");
        var text = comp.ReadInfo("CD");
        Console.WriteLine(text);  
        comp.InsertReject("CD", false);
        comp.PrintInfo("Printing from C#", "Printer");
        comp.ShowDisk(); 
        comp.ShowPrintDevice(); 
    }
}