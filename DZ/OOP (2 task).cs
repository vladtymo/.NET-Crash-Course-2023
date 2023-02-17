using System;
using System.IO;

namespace Code_Coach_Challenge
{

    public class Furniture
    {
        private readonly double height;
        private readonly double width;
        private readonly string material;
        private const string color = "white";
        private double? cost = null;
        private int amountChairs=5;
        private int amountBeds = 3;
         private string name;
        private int amountToBuy=0;

        public Furniture()
        {
            this.height = 100;
            this.width = 90;
            this.material = "wood";
            this.cost = 5000;
            this.name = "bed";
            this.amountToBuy = 4;
            
            Console.WriteLine($" The height is {height}," +
               $"\n width is {width}," +
               $"\n material is {material}" +
               $"\n color is {color}" +
               $"\n and the cost is {cost}" +
               $"\n amount: {amountChairs}");
            
        }
        public Furniture(string name,double height, double width, string material, double cost,int amountToBuy)
        {
            this.height = height;
            this.width = width;
            this.material = material;
            this.cost = cost;
            this.name = name;
            this.amountToBuy = amountToBuy;
        }


        
        public void showInfo()
        {
            if(amountToBuy<= amountChairs && name == "chair")
            {
               amountChairs = amountChairs - amountToBuy;
               Console.WriteLine($" The height is {height}," +
               $"\n width is {width}," +
               $"\n material is {material}" +
               $"\n color is {color}" +
               $"\n and the cost is {cost}" +
               $"\n amount: {amountChairs}");
            }
            else
            {
                Console.WriteLine("Sorry kitty, we don't have this amount of chairs :(");
            }
           
        }

       

    }



    class Program
    {
        static void Main(string[] args)
        {

            Furniture chair = new Furniture("chair",100, 80, "wood", 3500,1);
            Furniture exampleFurniture = new Furniture();

            Furniture[] furnitures = { chair, exampleFurniture };
            furnitures[0].showInfo();
           

        }


    }
}