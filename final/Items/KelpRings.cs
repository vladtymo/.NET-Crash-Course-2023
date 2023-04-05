public class KelpRings : Item{
    
    decimal KelpRingsPrice = 1.30m;
    decimal sausePrice = 0.30m;
    public bool sause = false;
    public KelpRings() : base("Kelp Rings", 0, "Best kelp Rings in the world") { }
    public KelpRings(bool sause):base("Kelp Rings",0,"))")
    {
        this.sause = sause; 
        Price = sause ? KelpRingsPrice : KelpRingsPrice+sausePrice; 
    }
    public override string ToString()
    {
        string s = sause ? "with sause" : "without sause";
        return $"{Name}({s}): {Price}$";
    }
}