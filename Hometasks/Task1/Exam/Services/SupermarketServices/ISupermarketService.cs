using Exam.Database.Enitites;
using Exam.Services.Response;

namespace Exam.Services.SupermarketServices
{
    public interface ISupermarketService
    {
        public Task<ResponseService> Create(SupermarketEntity entity);
        public Task<ResponseService> Update(SupermarketEntity entity);
        public Task<ResponseService> Delete(SupermarketEntity entity);
    }
}