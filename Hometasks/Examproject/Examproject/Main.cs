using System;
using Examproject;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Main
{
    class Pizza_list
    {
        public List<string> pizza_list = new List<string>();
        public List<string> pizza_fillings = new List<string>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Menushow menushow = new Menushow();
            Pizza_list pizza_ = new Pizza_list();
            EditPizza editPizza = new EditPizza(pizza_);

            CheckFile checkFile = new CheckFile();
            if (File.Exists("Pizza.json") == false) {
                checkFile.Create();
            }

            //menushow.menushow();

            editPizza.Add_Pizza("Margarita");
            editPizza.Add_Filling("Chilli");
            editPizza.Add_Pizza("Acnhor");
            editPizza.Add_Filling("Solomka");

            SaveaboutPizza saver = new SaveaboutPizza();
            saver.Save();
        }
    }
}