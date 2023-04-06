namespace Exam_Task
{
    class Supermarket
    {
        public List_Goods db_Goods = new List_Goods() 
        { 
            GoodsList = new List<Goods>() {
                new Food_Product("Молоко 30%",55.4M,20,"Кисломолочний продукт"),new Household_Chemicals("Fairy",41.85M,35,"Засiб для миття посуду"),
                new Textile("Home Line",80M,10,"Махровий рушник"),new Food_Product("Сир Молокiя",40M,15,"Кисломолочний продукт"),
                new Household_Chemicals("Savex",230.36M,10,"Пральний порошок"), new Textile("Sonex",635.99M,100,"Подушка"),
                new Food_Product("Хлiб \"Крафтяр\"",8.90M,40,"Хлiбобулочний вирiб"),new Household_Chemicals("ECO Nom",41.99M,30,"Освiжувач повiтря"),
                new Textile("Декор-Iн",1766,5,"Комплект штор"),
            }
        };
        public void ShowDB()
        {
            db_Goods.ShowList();
        }
       public void DisplayGoodsByCategory()
            {
                var GoodsByCategory = db_Goods.GoodsList.OrderBy(g => g.Category).GroupBy(g => g.Category);
                foreach (var group in GoodsByCategory)
                {
                    Console.WriteLine($"\nCategory: {group.Key}\n");

                    foreach (var g in group)
                    {
                        Console.WriteLine($"Назва товару: {g.Name}\t Цiна: {g.Price}\t Кiлькiсть:{g.Quantity}\t");
                    }
                }
        }
        public void SearchGoods(string name)
        {
            Console.WriteLine("____________SearchGoods_____________");
            var goods = db_Goods.GoodsList;
            var foundGoods = goods.Where(p => p.Name.ToLower().Contains(name.ToLower()));
            foreach (var g in foundGoods)
            {
                g.ShowInfo();
            }
        }
        public void SellGoods(string goodsName, int quantity)
        {
            
            Goods goods = null;
            foreach (var g in db_Goods.GoodsList)
            {
                if (g.Name == goodsName)
                {
                    goods = g;
                    break;
                }
            }

            if (goods != null && goods.Quantity >= quantity)
            {
                
                goods.Quantity -= quantity;

                Console.WriteLine("******************* Чек ***********************");
                Console.WriteLine("Назва товару: " + goods.Name);
                Console.WriteLine("Цiна: " + goods.Price);
                Console.WriteLine("Кiлькiсть: " + quantity);
                Console.WriteLine("Загальна вартiсть: " + goods.Price * quantity);
                Console.WriteLine("***********************************************");
            }
            else
            {
                Console.WriteLine("Товар не знайдено або кiлькiсть товару недостатня");
            }
        }

    }
}