
using Exam_task.Interface;

namespace Exam_task
{
    internal class Supermarket : IDeleted
    {
        private List<Goods> goods;
        private List<Product> products;
        public string Name { get; set; }

        public Supermarket(List<Goods> goods, List<Product> products, string name)
        {
            this.goods = goods;
            this.products = products;
            Name = name;
        }

        private bool Cheking(IComparable item, IComparable check)
        {
            for (int i = 0; this.goods.Count > i; i++)
            {
                if (item.Name == this.Name)


            }
            return 
        }
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void AddGoods(Goods goods)
        {

            this.goods.Add(goods);
            Console.WriteLine("");
        }
    }
}
