using System.Text.Json.Serialization;
public enum BurgerType{Basic =1,Double,Tribble}
[Serializable]
public class KrabsBurger : Item{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public BurgerType Type { get; set; }
    static Dictionary<BurgerType,decimal> prices = new Dictionary<BurgerType, decimal>{
        {BurgerType.Basic,1.50m},
        {BurgerType.Double,2.22m},
        {BurgerType.Tribble,3.33m}
    };
    public KrabsBurger() : base("KrabsBurger", 0, "Best burger in the world") { }
    public KrabsBurger(BurgerType type) :base("KrabsBurger",0,"Best burger in the world")
    {
        this.Type = type;
        if (prices.TryGetValue(type, out decimal p))
        {
            Price = p;
        }
        else
        {
            Console.WriteLine($"{type} size is not available");
        }

    }
    public override string ToString()
    {
        return $"{Name}({Type}): {Price}$";
    }
}