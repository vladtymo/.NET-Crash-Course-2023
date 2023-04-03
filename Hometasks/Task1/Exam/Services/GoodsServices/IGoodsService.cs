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
        Task<ResponseService<GoodsEntity>> Search(string name);
        Task<ICollection<GoodsEntity>> GetAll();
        Task<ICollection<GoodsEntity>> GetBuyed();
        Task<ICollection<GoodsEntity>> GetNotBuyed();

        Task<ResponseService<int>> Append(int id, int count);
        Task<ResponseService<int>> Buy(int id, int count);
    }
}