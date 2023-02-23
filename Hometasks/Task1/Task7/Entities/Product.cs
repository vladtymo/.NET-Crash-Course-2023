using Task7.Enums;

namespace Task7.Entities
{
    public class Product
    {
        private readonly DateTime _manufactureDate;

        public string Name { get; set; }
        public CategoryType Type { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return $"Data type: {this.GetType()}; Name: {Name}; Type: {Type.ToString()}; Price: {Price}";
        }
    }
}