public abstract class CombatVehicle {
    public string Type{get;set;}
    public string Model{get;set;}
    public int Health{get;set;}
    
    public CombatVehicle(string type,string model,int health){
        Type = type;
        Model = model;
        Health = health;
    }
    
    public bool isDestroyed(){
        return Health <= 0;
    }
    
    public void ShowInfo(){
        Console.WriteLine($"Type: {Type} Model: {Model} Health: {Health}");
    }
    
    public abstract int Attack();
    public abstract void Defence(int damage);
}