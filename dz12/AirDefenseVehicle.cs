public class AirDefenseVehicle : CombatVehicle{
    int Range{get;set;}
    int ShootSpeed{get;set;}
    int Mobility{get;set;}
    public AirDefenseVehicle(string type, string model, int health) : base(type, model, health){
        Random rand = new Random();
        Range = rand.Next(1, 101);
        ShootSpeed = rand.Next(1, 101);
        Mobility = rand.Next(1,11);
    }
    public new void ShowInfo(){
        base.ShowInfo();
        Console.WriteLine($"Range : {Range} ShootSpeed: {ShootSpeed} Mobility: {Mobility}");
    }
    public override int Attack(){
        return 150+Range*(ShootSpeed/10);
    }
    
    public override void Defence(int damage){
        Health -= damage/Mobility;
    }
}