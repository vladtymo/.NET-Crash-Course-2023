using Exam.Database.Enitites;
using Exam.Services.Response;
using System.Linq.Expressions;

namespace Exam.Services.CheckServices
{
    public interface ICheckService
    {
        Task<ResponseService> Create(CheckEntity entity);
        Task<ResponseService> Update(CheckEntity entity);
        Task<ResponseService> Delete(long id);

        Task<ResponseService<CheckEntity>> GetById(long id);
        Task<ICollection<CheckEntity>> GetBy(Expression<Func<CheckEntity, bool>> expression);
        Task<ICollection<CheckEntity>> GetAll();
        Task<ResponseService<string>> GetAsString(long id, char separator);
    }
}