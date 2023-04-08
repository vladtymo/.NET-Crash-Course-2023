using Main;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examproject
{
    public class SaveaboutPizza
    {

        public void Save()
        {

            Pizza_list pizza = new Pizza_list();

            foreach (var item in pizza.pizza_fillings)
            {
                Console.WriteLine(item);
            }
            try
            {
                string json = File.ReadAllText("Pizza.json");
                JObject data = JObject.Parse(json);

                JArray Pizzas = (JArray)data["Pizza"];
                foreach (var item in pizza.pizza_list)
                {
                    if (!Pizzas.Any(p => p["name"].ToString() == item))
                    {
                        JObject newPizza = new JObject();
                        newPizza["name"] = item;
                        Pizzas.Add(newPizza);
                    }
                }

                JArray Pizza_filling = (JArray)data["Fillings"];
                foreach (var item in pizza.pizza_fillings)
                {
                    if (!Pizza_filling.Any(p => p["name"].ToString() == item))
                    {
                        JObject newFilling = new JObject();
                        newFilling["name"] = item;
                        Pizza_filling.Add(newFilling);
                    }
                }

                json = data.ToString();
                File.WriteAllText("Pizza.json", json);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while saving data to file: " + ex.Message);
            }

        }
    }
}
