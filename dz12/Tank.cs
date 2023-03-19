public class Tank : CombatVehicle{
    int ReloadTime{get;set;}
    int Aim{get;set;}
    int Thickness{get;set;}
    public Tank(string type, string model, int health) : base(type, model, health){
        Random rand = new Random();
        ReloadTime = rand.Next(1, 101);
        Aim = rand.Next(1, 101);
        Thickness = rand.Next(1, 101);
    }
    public new void ShowInfo(){
        base.ShowInfo();
        Console.WriteLine($"ReloadTime : {ReloadTime} Aim: {Aim} Thickness: {Thickness}");
    }
    public override int Attack(){
        return (int)(100*Aim/ReloadTime);
    }
    
    public override void Defence(int damage){
        int d = damage - Thickness;
        Health -= d < 0 ? damage : d;
    }
}