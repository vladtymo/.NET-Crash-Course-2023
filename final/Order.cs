public enum Options{Exit=1,AddItem,RemoveItem,ShowOrder,ShowTotalPrice,CreateOrder}
public class Order{
    Dictionary<Item,int> Items = new Dictionary<Item, int>();
    public void AddItem(Item item, int count){
        if (Items.ContainsKey(item))
        {
            Items[item]+= count;
        }
        else
        {
            Items.Add(item,count);
        }
    }
    public void RemoveItem(){
        int i = 1;
        foreach (KeyValuePair<Item, int> items in Items)
        {
            System.Console.WriteLine($"[{i}] Item: {items.Key} Count: {items.Value}");
            ++i;
        }
        System.Console.Write("Select item to remove: ");
        int itemChoice = int.Parse(Console.ReadLine());
        System.Console.Write("Select count to remove: ");
        int itemCount = int.Parse(Console.ReadLine());
        KeyValuePair<Item, int> selectedItem = Items.ElementAt(itemChoice - 1);
        if (itemCount < selectedItem.Value)
        {
            Items[selectedItem.Key] -= itemCount;
        }
        else
        {
            Items.Remove(selectedItem.Key);
        }
    }
    public decimal Total(){
        decimal total = 0;       
        foreach (KeyValuePair<Item, int> items in Items)
        {
            total += items.Key.Price * items.Value;
        }
        Console.WriteLine("------------Your Total Price ------------");
        Console.WriteLine($"Total price: {total}$");
        Console.WriteLine("----------------------------------------");
        return total;
    }
    public void ShowOrder(){
        Console.WriteLine("------------Your Order ------------");
        foreach (KeyValuePair<Item, int> items in Items)
        {
            Console.WriteLine($"Item: {items.Key} Count: {items.Value}");
        }
    }
    public void CreateOrder(){
        Console.WriteLine("################################");
        Console.WriteLine("##         Your check         ##");
        Console.WriteLine("################################");
        ShowOrder();
        Total();
        Dictionary<Item,int> Items = new Dictionary<Item, int>();

    }

}


