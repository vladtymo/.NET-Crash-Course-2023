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
        Task<ICollection<ProductEntity>> GetAll();
        Task<ICollection<ProductEntity>> GetBuyed();
        Task<ICollection<ProductEntity>> GetNotBuyed();
        Task<ICollection<ProductEntity>> GetExpired();

        Task<ResponseService<int>> Buy(long id, int count);
    }
}