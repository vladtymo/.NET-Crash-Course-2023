internal class CD : Disk, IRemovableDisk {
    private bool hasDisk;
    public bool HasDisk {
        get; set;
    }
    public CD()
        :base("m",2,"CD")
    {
       
    }

    public new string GetName() {
        return base.GetName();
    }
    public void Insert() {
        this.hasDisk = true;
    }
    public void Reject() {
        this.hasDisk = false;
    }
}
