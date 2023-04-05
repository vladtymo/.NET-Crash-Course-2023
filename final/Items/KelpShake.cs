public class KelpShake : Item{
    static decimal KelpShakePrice = 2.00m;
    public KelpShake()
        :base("Kelp Shake",KelpShakePrice,"Poseidons Shake")
    {}
    public override string ToString()
    {
        return $"{Name}: {Price}$";
    }
}