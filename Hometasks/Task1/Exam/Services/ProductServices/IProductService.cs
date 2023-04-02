using Exam.Database.Enitites;
using Exam.Services.Response;

namespace Exam.Services.ProductServices
{
    public interface IProductService
    {
        Task<ResponseService> Create(ProductEntity entity);
        Task<ResponseService> Delete(long id);
        Task<ResponseService> Update(ProductEntity entity);

        Task<ResponseService<ProductEntity>> GetById(long id);
        Task<ResponseService<ProductEntity>> Search(string name);
        Task<List<ProductEntity>> GetAll();
        Task<List<ProductEntity>> GetBuyed();
        Task<List<ProductEntity>> GetNotBuyed();
        Task<List<ProductEntity>> GetExpired();

        Task<ResponseService<int>> Buy(long id, int count);
    }
}