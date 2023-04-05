
using System.Text.Json.Serialization;
using System.Collections;

public abstract class Item{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public Item(string name,decimal price,string description){
        Name = name;
        Price = price;
        Description = description;
    }

    public override string ToString()
    {
        return $"Name:{Name} Price: {Price}";
    }
}