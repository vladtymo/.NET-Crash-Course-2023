using Exam.Database.Enitites;
using Exam.Services.Response;
using System.Linq.Expressions;

namespace Exam.Services.ProductServices
{
    public interface IProductService
    {
        Task<ResponseService> Create(ProductEntity entity);
        Task<ResponseService> Delete(long id);
        Task<ResponseService> Update(ProductEntity entity);

        Task<ResponseService<ProductEntity>> GetById(long id);
        Task<ICollection<ProductEntity>> GetByName(string name); // TODO Implementation
        Task<ICollection<ProductEntity>> GetAll();
        Task<ICollection<ProductEntity>> GetAll<TKey>(Expression<Func<ProductEntity, TKey>> direction);
        Task<ICollection<ProductEntity>> GetBuyed();
        Task<ICollection<ProductEntity>> GetNotBuyed();
        Task<ICollection<ProductEntity>> GetExpired();

        Task<ResponseService<int>> Buy(long id, int count);
    }
}