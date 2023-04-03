using Exam.Database.Enitites;
using Exam.Services.Response;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Exam.Services.SupermarketServices
{
    public interface ISupermarketService
    {
        Task<ResponseService> Create(SupermarketEntity entity);
        Task<ResponseService> Update(SupermarketEntity entity);
        Task<ResponseService> Delete(long id);

        Task<ResponseService<SupermarketEntity>> GetById(long id);
        Task<ICollection<SupermarketEntity>> GetByName(string name);
        Task<ICollection<SupermarketEntity>> GetByGoodsName(string name);
        Task<ICollection<SupermarketEntity>> GetByProductName(string name);
        Task<ICollection<SupermarketEntity>> GetAll();

        Task<ResponseService<long>> OpenCheck(long supermarketId);
        Task<ResponseService<float>> CloseCheck(long id);
        
        Task<ResponseService> DeriverGoods(long id, ICollection<GoodsEntity> goods);
        Task<ResponseService> DeriverProducts(long id, ICollection<ProductEntity> products);

        Task<ResponseService<float>> BuyGoods(long checkId, params GoodsEntity[] goods);
        Task<ResponseService<float>> BuyGoods(long checkId, params int[] goodsIds);
        Task<ResponseService<float>> BuyProducts(long checkId, params ProductEntity[] products);
        Task<ResponseService<float>> BuyProducts(long checkId, params long[] ProductsIds);
    }
}