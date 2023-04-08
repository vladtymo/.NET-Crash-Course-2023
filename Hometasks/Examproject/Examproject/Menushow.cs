using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examproject
{
    enum Menu
    {
        Standart = 1, CreatePizza, AddPizza, SubtractPizza, EditPizza, AddFilling, SubtractFilling, EditFilling, SavePizza, SaveFilling,
        LoadPizza, LoadFilling, InfoAllPizza, SearchPizzaFilling, OrderPizza, Pay
    }
    public class Menushow
    {
        public void menushow()
        {
            Console.WriteLine($"Please, switch what are you doing: \n" +
                $"{(int)Menu.Standart} - Standart pizza.\n" + 
                $"{(int)Menu.CreatePizza} - Create your pizza.\n" +
                $"{(int)Menu.AddPizza} - Add your pizza to database.\n" +
                $"{(int)Menu.SubtractPizza} - Subtract your pizza in database.\n" +
                $"{(int)Menu.EditPizza} - Edit your pizza in database.\n" +
                $"{(int)Menu.AddFilling} - Add your filling in pizza to database.\n" +
                $"{(int)Menu.SubtractFilling} - Subtract your filling in pizza in database.\n" +
                $"{(int)Menu.EditFilling} - Edit your filling in pizza in database.\n" +
                $"{(int)Menu.SavePizza} - Save your info about pizza in database.\n" +
                $"{(int)Menu.SaveFilling} - Save your info about fiiling in pizza in database.\n" +
                $"{(int)Menu.LoadPizza} - Load your info about pizza in database.\n" +
                $"{(int)Menu.LoadFilling} - Load your info about fiiling in pizza in database.\n" +
                $"{(int)Menu.InfoAllPizza} - Show all pizza's.\n" +
                $"{(int)Menu.SearchPizzaFilling} - Search info about pizza for fillings.\n" +
                $"{(int)Menu.OrderPizza} - Show your order.\n" +
                $"{(int)Menu.Pay} - Create payment check.\n");
        }
    }
}
