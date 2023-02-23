internal enum CategoryType { Drinks, Chemical, Food, Other}
internal class Product
{
    public readonly DateTime ManufactureDate;
    public Product()
    {
        ManufactureDate = DateTime.Now;
    }

    public Product(DateTime manufactureDate, string? name, CategoryType category, decimal price)
    {
        ManufactureDate = manufactureDate;
        Name = name;
        this.category = category;
        Price = price;
    }

    public String? Name { get; set; }
    public CategoryType category { get; set; }
    public decimal Price { get; set; }

    public override String ToString() => $"{Name} price {Price}";
}