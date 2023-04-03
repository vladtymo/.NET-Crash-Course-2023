using Exam.Database.Enitites;
using Exam.Services.Response;

namespace Exam.Services.SupermarketServices
{
    public interface ISupermarketService
    {
        public Task<ResponseService> Create(SupermarketEntity entity);
        public Task<ResponseService> Update(SupermarketEntity entity);
        public Task<ResponseService> Delete(long id);

        public Task<ResponseService<GoodsEntity>> BuyGoods(long id, float money);
        public Task<ResponseService<ProductEntity>> BuyProduct(long id, float money);
    }
}