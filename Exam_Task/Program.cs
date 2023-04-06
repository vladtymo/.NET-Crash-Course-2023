using System.Collections.Generic;

namespace Exam_Task
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Supermarket supermarket = new Supermarket();
            supermarket.ShowDB();
            supermarket.DisplayGoodsByCategory();
            supermarket.SearchGoods("Молоко 30%");
            supermarket.db_Goods.AddGoods(new Food_Product("Чiпси Люкс", 55.8M, 100, "Снеки"));
            supermarket.db_Goods.RemoveGoods("Sonex", "Textile");
            supermarket.db_Goods.SaveGoodsToFile("db.json");
            Supermarket supermarket2 = new Supermarket();
            supermarket2.db_Goods.LoadGoodsFromFile("db.json");
            supermarket2.SellGoods("Чiпси Люкс", 3);
            supermarket2.ShowDB();
        }
    }
}