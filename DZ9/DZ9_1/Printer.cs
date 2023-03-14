class Printer : IPrintInformation{

    public string GetName(){return "printer";}
    public void Print(string str){
        Console.WriteLine(str);
    }
}