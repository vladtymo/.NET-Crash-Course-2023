using System.Collections;

namespace _15_system_interfaces
{
    public class Kettle : IComparable<Kettle>, ICloneable
    {
        public string Model { get; set; }
        public int Weight { get; set; }
        public double Capacity { get; set; }

        public Kettle(string model, int weight, double capacity)
        {
            Model = model;
            Weight = weight;
            Capacity = capacity;
        }

        public int CompareTo(Kettle? other)
        {
            /* return value: 
                 0  - this is equals to other
                 >0 - this is bigger than other
                 <0 - this is not bigger than other
            */
            if (other == null) return 1;
            return this.Capacity.CompareTo(other.Capacity) * -1;
        }

        public override string ToString()
        {
            return $"Kettle {Model}, weight: {Weight}g, Capacity: {Capacity}ml";
        }

        public object Clone()
        {
            // shallow copy - copy all value types and references
            var copy = (Kettle)this.MemberwiseClone();

            // deep copy - copy all data in the reference types
            copy.Model = (string)this.Model.Clone();
            //...

            return copy;
        }
    }

    public class Kitchen : IEnumerable
    {
        private Kettle[] objects = null;
        private string[] products = null;

        public Kitchen()
        {
            objects = new[]
            {
                new Kettle("Tefal", 750, 1.5),
                new Kettle("Bosch", 500, 0.7),
                new Kettle("Samsung", 430, 1.0),
                new Kettle("Vitek", 990, 3.3)
            };
        }

        public IEnumerator GetEnumerator()
        {
            return objects.GetEnumerator();
        }

        public void SortObjects()
        {
            // Sort() requires IComperable interface implementation
            Array.Sort(objects);
        }

        public void ShowObjects()
        {
            foreach (var item in objects)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Kitchen kitchen = new Kitchen();

            kitchen.SortObjects();
            kitchen.ShowObjects();

            // cycle foreach requires IEnumerable interface implementation
            foreach (Kettle item in kitchen)
            {
                Console.WriteLine(item.Model);
            }

            Kettle kettle = new Kettle("Bosch", 770, 2.2);

            // ICloneable interdface for creating a deep copy
            Kettle copy = (Kettle)kettle.Clone();

            kettle.Capacity += 0.5;

            Console.WriteLine("Original capacity: " + kettle.Capacity + "ml");
            Console.WriteLine("Copy capacity: " + copy.Capacity  + "ml");
        }
    }
}