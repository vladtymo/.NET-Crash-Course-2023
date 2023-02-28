namespace lessonTask_properties
{
    internal class Product
    {
        public string Name { get; set; }
        private readonly DateTime ManufactureDate;
        public enum CategoryType { };
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }
        public Product(DateTime manufactureDate)
        {
            ManufactureDate = manufactureDate;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nManufacture Date: {ManufactureDate.ToLongDateString()}\n" +
                $"Category: {Category}\nPrice: {Price}";
        }
    }
}
