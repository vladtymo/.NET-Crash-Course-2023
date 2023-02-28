class Fish : Animal
{
    public bool IsSaltwater { get; set; }

    public Fish(string species, double speed,double weight, string? environment,bool isSaltwater)
        :base(species,speed,weight,environment)
    {
        this.IsSaltwater = isSaltwater;
    }
    public void amIInsaltyOrNotWater(){
        Console.WriteLine("I am in" + ((this.IsSaltwater) ? "salty water" : "NOT salty water" + "\n"));
    }

    public void MakeNewSound()
    {
        Console.WriteLine("The fish is silent.");
    }
}