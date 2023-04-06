using Exam.Database.Enitites;
using Exam.Services.Response;

namespace Exam.Services.ImplementatorServices
{
    public interface IImplementatorService
    {
        Task<ResponseService<ICollection<CheckEntity>>> ImplementChecks(long supermarketId, bool append = false);
        Task<ResponseService<ICollection<GoodsEntity>>> ImplementGoods(int count, long supermarketId, bool append = false);
        Task<ResponseService<ICollection<ProductEntity>>> ImplementProduct(int count, long supermarketId, bool append = false);
        Task<ResponseService<ICollection<SupermarketEntity>>> ImplementSupermarkets(int count, bool append = false);
    }
}