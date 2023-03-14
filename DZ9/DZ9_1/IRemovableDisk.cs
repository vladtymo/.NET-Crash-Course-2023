internal interface IRemovableDisk{
    public bool HasDisk { get; }
    public string GetName();
    public void Insert();
    public void Reject(); 
}