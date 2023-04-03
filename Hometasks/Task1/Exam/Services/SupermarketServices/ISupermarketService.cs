using Exam.Database.Enitites;
using Exam.Services.Response;

namespace Exam.Services.SupermarketServices
{
    public interface ISupermarketService
    {
        Task<ResponseService> Create(SupermarketEntity entity);
        Task<ResponseService> Update(SupermarketEntity entity);
        Task<ResponseService> Delete(long id);

        Task<ResponseService<long>> OpenCheck(long supermarketId);
        Task<ResponseService<float>> CloseCheck(long id);
        
        Task<ResponseService<float>> BuyGoods(long checkId, params GoodsEntity[] goods);
        Task<ResponseService<float>> BuyGoods(long checkId, params int[] goodsIds);
        Task<ResponseService<float>> BuyProducts(long checkId, params ProductEntity[] products);
        Task<ResponseService<float>> BuyProducts(long checkId, params long[] ProductsIds);
    }
}