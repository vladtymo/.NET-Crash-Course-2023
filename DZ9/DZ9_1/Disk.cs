internal class Disk : IDisk{
    private string name;
    private string memory;
    private int memSize;
    public string Memory{get;set;}
    public int MemSize{get;set;}
    public Disk(){
        this.memory = "";
        this.memSize = 0;
        this.name = "no name";
    }
    public Disk(string memory,int memSize, string name){
        this.memory = memory;
        this.memSize = memSize;
        this.name = name;
    }

    public string Read(){
        return this.memory;
    }
    public void Write(string text){
        this.memory = text;
    }

    
    public string GetName()
    {
        return this.name;
    }


}