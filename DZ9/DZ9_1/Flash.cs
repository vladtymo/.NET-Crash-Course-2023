internal class Flash : Disk,IRemovableDisk{
    private bool hasDisk;
    public bool HasDisk {
        get; set;
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
