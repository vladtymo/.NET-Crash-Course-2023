public class CompareByPrice : IComparer<Item>{
    public int Compare(Item? x, Item? y){
        if (x == null || y == null){return 0;}
        else return x.Price.CompareTo(y.Price);
    }
}
