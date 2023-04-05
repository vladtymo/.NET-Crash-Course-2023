using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class UniversityJsonConverter : JsonConverter<Item>
{
    public override bool CanConvert(Type typeToConvert) =>
        typeof(Item).IsAssignableFrom(typeToConvert);

    public override Item Read(ref Utf8JsonReader reader, 
        Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();
        reader.Read();
        if (reader.TokenType != JsonTokenType.PropertyName)
            throw new JsonException();
        string? propertyName = reader.GetString();
        if (propertyName != "ItemType")
            throw new JsonException();
        reader.Read();
        if (reader.TokenType != JsonTokenType.String)
            throw new JsonException();
        var itemType = reader.GetString();
        Item item;
        switch (itemType)
        {
            case "Krabsburger":
                item = new KrabsBurger();
                break;
            case "Soda":
                item = new Soda();
                break;
            case "KelpRings":
                item = new KelpRings();
                break;
            case "KelpShake":
                item = new KelpShake();
                break;
            default:
                throw new JsonException();
        };



        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
                return item;
            if (reader.TokenType == JsonTokenType.PropertyName)
            {
                propertyName = reader.GetString();
                reader.Read();
                switch (propertyName)
                {
                    case "Name":
                        item.Name = reader.GetString();
                        break;
                    case "Price":
                        item.Price = reader.GetDecimal();
                        break;
                    case "Description":
                        item.Description = reader.GetString();
                        break;
                    case "Type":
                       
                        if(item is KrabsBurger){
                            string type = reader.GetString();
                            switch(type){
                                case "Basic":
                                    ((KrabsBurger)item).Type = BurgerType.Basic;
                                    break;
                                case "Double":
                                    ((KrabsBurger)item).Type = BurgerType.Double;
                                    break;
                                case "Tribble":
                                    ((KrabsBurger)item).Type = BurgerType.Tribble;
                                    break;
                            }
                        }else{
                            throw new JsonException();
                        }
                        break;
                    case "volume":
                        if(item is Soda){
                            string volume = reader.GetString();
                            switch(volume){
                                case "Volume0_33":
                                    ((Soda)item).volume = SodaVolume.Volume0_33;
                                    break;
                                case "Volume0_5":
                                    ((Soda)item).volume = SodaVolume.Volume0_5;
                                    break;
                                case "Volume1":
                                    ((Soda)item).volume = SodaVolume.Volume1;
                                    break;
                                case "Volume1_5":
                                    ((Soda)item).volume = SodaVolume.Volume1_5;
                                    break;
                            }
                        }else{
                            throw new JsonException();
                        }
                        break;
                    case "sause":
                        bool hasSause = reader.GetBoolean();
                        if (item is KelpRings)
                            ((KelpRings)item).sause = hasSause;
                        else
                            throw new JsonException();
                        break;
                }
                    
            }
        }
        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, 
        Item item, JsonSerializerOptions options)
    { 
        writer.WriteStartObject();
        
        if (item is KrabsBurger krabsBurger)
        {
            writer.WriteString("ItemType", "Krabsburger");
            writer.WriteString("Name", item.Name);
            writer.WriteNumber("Price",item.Price);
            writer.WriteString("Description", item.Description);
            writer.WriteString("Type", krabsBurger.Type.ToString());
        }
        else if (item is Soda soda)
        {
            writer.WriteString("ItemType", "Soda");
            writer.WriteString("Name", item.Name);
            writer.WriteNumber("Price", item.Price);
            writer.WriteString("Description", item.Description);
            writer.WriteString("volume", soda.volume.ToString());
        }else if(item is KelpRings kelpRings){
            writer.WriteString("ItemType", "KelpRings");
            writer.WriteString("Name", item.Name);
            writer.WriteNumber("Price", item.Price);
            writer.WriteString("Description", item.Description);
            writer.WriteBoolean("sause", kelpRings.sause);
        }else if(item is KelpShake kelpShake){
            writer.WriteString("ItemType", "KelpShake");
            writer.WriteString("Name", item.Name);
            writer.WriteNumber("Price", item.Price);
            writer.WriteString("Description", item.Description);
        }
        writer.WriteEndObject();
    }
}
