namespace dz_7
{
    enum CategoryType { Toys, Food, Clothing };

    internal class Product
    {
        public string Name { get; set; }
        //readonly private DateTime ManufactureDate;
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Category: {Category}, Price: {Price}";
        }
    }
}
