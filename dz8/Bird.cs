
public class Bird : Animal{
    public bool CanFly {get;set;}

    public Bird(string species, double speed,double weight, string? environment,bool fly)
        :base(species,speed,weight,environment)
    {
        this.CanFly = fly;
    }

    public void Fly(){
        Console.WriteLine("I" + ((this.CanFly) ? "can :)" : "can't :(") + "fly\n");
    }
    public void MakeNewSound()
    {
        Console.WriteLine("The bird is chirping.");
    }
}