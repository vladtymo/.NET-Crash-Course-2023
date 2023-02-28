class Reptile : Animal
{
    public bool IsColdBlooded { get; set; }

    public Reptile(string species, double speed,double weight, string? environment,bool isColdBlooded)
        :base(species,speed,weight,environment)
    {
        this.IsColdBlooded = isColdBlooded;
    }
    public void amIColdOrWarmBloodet(){
        Console.WriteLine("I am" + ((this.IsColdBlooded) ? "Cold Blooded" : "Warm Blooded") + "\n");
    }
    public void MakeNewSound()
    {
        Console.WriteLine("The reptile is hissing.");
    }
    

}