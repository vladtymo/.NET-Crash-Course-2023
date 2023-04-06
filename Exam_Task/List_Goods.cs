using System.Text.Json;

namespace Exam_Task
{
    public class List_Goods
    {
        public List<Goods> GoodsList { get; set; } = new List<Goods>();
        public void AddGoods(Goods goods)
        {
            var existingGoods = GoodsList.FirstOrDefault(p => p.Name == goods.Name && p.Category == goods.Category);
            if (existingGoods != null)
            {
                existingGoods.Quantity += goods.Quantity;
            }
            else
            {
                GoodsList.Add(goods);
            }
        }
        public void SaveGoodsToFile(string fileName)
        {
            string json = JsonSerializer.Serialize(GoodsList);
            File.WriteAllText(fileName, json);
            Console.WriteLine($"________________________DbSaves({fileName})__________________");
        }
        public void LoadGoodsFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                GoodsList = JsonSerializer.Deserialize<List<Goods>>(json);
                Console.WriteLine($"________________________DbLoad({fileName})__________________");
            }
        }
        public void ShowList()
        {
            Console.WriteLine("________________ShowList_________________");
            foreach (Goods g in GoodsList)
            {
                g.ShowInfo();
                Console.WriteLine();
            }
        }
        public void RemoveGoods(string name, string category)
        {
            Goods foundGoods = null;
            foreach (Goods goods in GoodsList)
            {
                if (goods.Name == name && goods.Category == category)
                {
                    foundGoods = goods;
                    break;
                }
            }

            if (foundGoods != null)
            {
                GoodsList.Remove(foundGoods);
                Console.WriteLine("Товар '{0}'з категорiї '{1}' знайдено i видалено з бази данних.", name, category);
            }
            else
            {
                Console.WriteLine("Товар '{0}'з категорiї '{1}' не знайдено в базi данних", name, category);
            }
        }
    }
}