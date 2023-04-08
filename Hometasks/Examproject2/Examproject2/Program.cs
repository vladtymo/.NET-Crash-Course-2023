using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace PizzaOrderingSystem
{
    public interface IPizza
    {
        string Name { get; set; }
        List<string> Ingredients { get; set; }
        decimal Price { get; set; }
        string GetInfo();
    }

    public class Pizza : IPizza
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public decimal Price { get; set; }

        public string GetInfo()
        {
            return $"Name: {Name}, Ingredients: {string.Join(", ", Ingredients)}, Price: {Price:C}";
        }
    }

    public class StandardPizza : Pizza
    {
        public StandardPizza()
        {
            Name = "Standard Pizza";
            Ingredients = new List<string> { "Tomato sauce", "Mozzarella cheese" };
            Price = 10.00m;
        }
    }

    public class CustomPizza : Pizza
    {
        public CustomPizza(string name, List<string> ingredients, decimal price)
        {
            Name = name;
            Ingredients = ingredients;
            Price = price;
        }
    }

    public class PizzaDatabase
    {
        private List<IPizza> _pizzas = new List<IPizza>();

        public void AddPizza(IPizza pizza)
        {
            _pizzas.Add(pizza);
        }

        public void RemovePizza(IPizza pizza)
        {
            _pizzas.Remove(pizza);
        }

        public void UpdatePizza(IPizza oldPizza, IPizza newPizza)
        {
            int index = _pizzas.IndexOf(oldPizza);
            _pizzas[index] = newPizza;
        }

        public void SaveToFile(string filename)
        {
            string json = JsonSerializer.Serialize(_pizzas);
            File.WriteAllText(filename, json);
        }

        public void LoadFromFile(string filename)
        {
            string json = File.ReadAllText(filename);
            _pizzas = JsonSerializer.Deserialize<List<IPizza>>(json);
        }

        public List<IPizza> GetPizzas()
        {
            return _pizzas;
        }

        public List<IPizza> SearchPizzas(List<string> ingredients)
        {
            return _pizzas.Where(pizza => pizza.Ingredients.Intersect(ingredients).Any()).ToList();
        }
    }

    public class Ingredient
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Ingredient(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }


    public class ProductDatabase
    {
        private List<string> _products = new List<string>();

        public void AddProduct(string product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(string product)
        {
            _products.Remove(product);
        }

        public void UpdateProduct(string oldProduct, string newProduct)
        {
            int index = _products.IndexOf(oldProduct);
            _products[index] = newProduct;
        }

        public List<string> GetProducts()
        {
            return _products;
        }
    }
    public class Order
    {
        public Pizza Pizza { get; set; }
        public List<Ingredient> ExtraToppings { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public Order(Pizza pizza, List<Ingredient> extraToppings, int quantity)
        {
            Pizza = pizza;
            ExtraToppings = extraToppings;
            Quantity = quantity;
            TotalPrice = CalculateTotalPrice();
        }

        private decimal CalculateTotalPrice()
        {
            decimal extraToppingsPrice = 0;
            foreach (var topping in ExtraToppings)
            {
                extraToppingsPrice += topping.Price;
            }
            decimal totalPrice = Pizza.Price + extraToppingsPrice;
            return totalPrice * Quantity;
        }

        public void PrintOrder()
        {
            Console.WriteLine("Order:");
            Console.WriteLine($"{Pizza.Name} Pizza ({Quantity})");
            Console.WriteLine("Toppings:");
            foreach (var topping in Pizza.Ingredients)
            {
                Console.WriteLine($"- {topping}");
            }
            if (ExtraToppings.Count > 0)
            {
                Console.WriteLine("Extra Toppings:");
                foreach (var topping in ExtraToppings)
                {
                    Console.WriteLine($"- {topping.Name}");
                }
            }
            Console.WriteLine($"Total Price: ${TotalPrice}");
        }

        public void Pay(decimal amountPaid)
        {
            if (amountPaid < TotalPrice)
            {
                Console.WriteLine("Insufficient payment. Please pay the full amount.");
            }
            else
            {
                decimal change = amountPaid - TotalPrice;
                Console.WriteLine($"Payment received. Change: ${change}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pizzaDb = new PizzaDatabase();
            var standardPizza = new StandardPizza();
            pizzaDb.AddPizza(standardPizza);

            var customPizza = new CustomPizza("Custom Pizza", new List<string> { "Tomato sauce", "Mozzarella cheese", "Pepperoni" }, 12.00m);
            pizzaDb.AddPizza(customPizza);

            var searchIngredients = new List<string> { "Pepperoni", "Mushrooms" };
            var searchResults = pizzaDb.SearchPizzas(searchIngredients);
            Console.WriteLine($"Search results ({searchResults.Count}):");
            foreach (var pizza in searchResults)
            {
                Console.WriteLine(pizza.GetInfo());
            }

            var orderPizza = customPizza;
            var orderToppings = new List<Ingredient> { new Ingredient("Extra Cheese", 1.50m) };
            var orderQuantity = 2;
            var order = new Order(orderPizza, orderToppings, orderQuantity);

            order.PrintOrder();
            order.Pay(30.00m);

            string filename = "pizzas.json";
            pizzaDb.SaveToFile(filename);
        }
    }
}