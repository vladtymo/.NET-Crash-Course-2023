using Exam.Database.Enitites;
using Exam.Services.Response;

namespace Exam.Services.GoodsServices
{
    public interface IGoodsService
    {
        Task<ResponseService> Create(GoodsEntity entity);
        Task<ResponseService> Delete(long id);
        Task<ResponseService> Update(GoodsEntity entity);

        Task<ResponseService<GoodsEntity>> GetById(long id);
        Task<List<GoodsEntity>> GetAll();
        Task<List<GoodsEntity>> GetBuyed();
        Task<List<GoodsEntity>> GetNotBuyed();

        Task<ResponseService<int>> AppendGoods(int id, int count);
        Task<ResponseService<int>> BuyGoods(int id, int count);
    }
}