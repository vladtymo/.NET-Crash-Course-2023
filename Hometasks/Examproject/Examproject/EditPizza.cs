using Main;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examproject
{
    public class EditPizza
    {
        private readonly Pizza_list pizza_list;

        internal EditPizza(Pizza_list pizzaList)
        {
            this.pizza_list = pizzaList;
        }
        public void Add_Pizza(string pizza)
        {
            if (pizza_list.pizza_list.Contains(pizza))
            {
                Console.WriteLine("I have this pizza in list");
            }
            else
            {
                pizza_list.pizza_list.Add(pizza);
            }
        }

        public void Remove_Pizza(string pizza)
        {
            if (pizza_list.pizza_list.Contains(pizza))
            {
                pizza_list.pizza_list.Remove(pizza);
            }
            else
            {
                Console.WriteLine("I don't see this pizza in list.");
            }
        }

        public void Rename_Pizza(string pizza_old, string pizza_new)
        {
            if (pizza_list.pizza_list.Contains(pizza_old))
            {
                int index = pizza_list.pizza_list.FindIndex(pizza => pizza==pizza_old);
                if (index != -1)
                {
                    pizza_list.pizza_list[index] = pizza_new;
                }
            }
            else
            {
                Console.WriteLine("I don't see this pizza in list.");
            }
        }

        public void Add_Filling(string filling)
        {
            if (pizza_list.pizza_fillings.Contains(filling))
            {
                Console.WriteLine("I have this filling in pizza");
            }
            else
            {
                pizza_list.pizza_fillings.Add(filling);
            }
        }

        public void Remove_Filling(string filling)
        {
            if (pizza_list.pizza_fillings.Contains(filling))
            {
                pizza_list.pizza_fillings.Remove(filling);
            }
            else
            {
                Console.WriteLine("I dont see this filling in pizza in list.");
            }
        }

        public void Rename_Filling(string filling_old, string filling_new)
        {
            if (pizza_list.pizza_fillings.Contains(filling_old))
            {
                int index = pizza_list.pizza_fillings.FindIndex(pizza => pizza == filling_old);
                if (index != -1)
                {
                    pizza_list.pizza_fillings[index] = filling_new;
                }
            }
            else
            {
                Console.WriteLine("I don't see this filling in pizza in list.");
            }
        }
    }
}
