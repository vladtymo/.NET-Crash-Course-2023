using System.Text.Json.Serialization;
public enum SodaVolume{Volume0_33,Volume0_5,Volume1,Volume1_5};
[Serializable]
public class Soda : Item{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SodaVolume volume { get; set; }
    static Dictionary<SodaVolume,decimal> prices = new Dictionary<SodaVolume, decimal>{
        {SodaVolume.Volume0_33,0.5m},
        {SodaVolume.Volume0_5,0.7m},
        {SodaVolume.Volume1,1.2m},
        {SodaVolume.Volume1_5,2.5m}
    };
    public Soda() : base("Soda", 0, "Best soda in the world") { }
    public Soda(SodaVolume volume) :base("Soda",0,"Best soda in the world")
    {
        this.volume = volume;
        if (prices.TryGetValue(volume, out decimal p))
        {
            Price = p;
        }
        else
        {
            Console.WriteLine($"{volume} size is not available");
        }

    }
    public override string ToString()
    {
        return $"{Name}({volume.ToString().Substring(6)}L): {Price}$";
    }
}