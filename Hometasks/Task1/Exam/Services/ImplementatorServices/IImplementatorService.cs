using Exam.Database.Enitites;

namespace Exam.Services.ImplementatorServices
{
    public interface IImplementatorService
    {
        Task<ICollection<CheckEntity>> ImplementChecks();
        Task<ICollection<GoodsEntity>> ImplementGoods(int count);
        Task<ICollection<ProductEntity>> ImplementProduct(int count);
        Task<ICollection<SupermarketEntity>> ImplementSupermarkets(int count);
    }
}