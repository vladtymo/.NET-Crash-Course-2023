public class ArmoredCar : CombatVehicle{
    int CountAmmo{get;set;}
    int Speed{get;set;}
    public ArmoredCar(string type, string model, int health) : base(type, model, health){
        Random rand = new Random();
        CountAmmo = rand.Next(1, 101);
        Speed = rand.Next(1, 101);
    }
    public new void ShowInfo(){
        base.ShowInfo();
        Console.WriteLine($"CountAmmo : {CountAmmo} Speed: {Speed}");
    }
    public override int Attack(){
        return 50*CountAmmo;
    }
    
    public override void Defence(int damage){
        int d = damage - Speed/2;
        Health -= d < 0 ? damage : d;
    }
}