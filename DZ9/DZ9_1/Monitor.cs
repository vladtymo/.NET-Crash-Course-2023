class Monitor : IPrintInformation{
    public string GetName(){return "Monitor";}
    public void Print(string str){
        Console.WriteLine(str);
    }
}