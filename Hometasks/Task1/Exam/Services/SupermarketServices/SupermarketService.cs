using Exam.Common;
using Exam.Database.Enitites;
using Exam.EntityFramework.Repository;
using Exam.Services.Response;

namespace Exam.Services.SupermarketServices
{
    public class SupermarketService : ISupermarketService
    {
        private readonly IGenericRepository<SupermarketEntity> _supermarketRepository;

        public SupermarketService(IGenericRepository<SupermarketEntity> supermarketRepository)
        {
            _supermarketRepository = supermarketRepository;
        }

        public Task<ResponseService<GoodsEntity>> BuyGoods(long id, float money)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseService<ProductEntity>> BuyProduct(long id, float money)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseService> Create(SupermarketEntity entity)
        {
            try
            {
                await _supermarketRepository.Create(entity);
                return ResponseService.Ok();
            }
            catch (Exception ex)
            {
                return ResponseService.Error($"SupermarketService Create exception: {ex.Message}");
            }
        }

        public async Task<ResponseService> Delete(long id)
        {
            SupermarketEntity dbRecord = await _supermarketRepository.GetById(id);
            if (dbRecord == null)
            {
                return ResponseService.Error(Errors.DELETE_ERROR);
            }
            
            dbRecord.DeletedOn = DateTime.Now;
            dbRecord.UpdatedOn = DateTime.Now;

            var result = await _supermarketRepository.Update(dbRecord);
            if (result)
            {
                return ResponseService.Ok();
            }
            else
            {
                return ResponseService.Error(Errors.UPDATE_ERROR);
            }
        }

        public async Task<ResponseService> Update(SupermarketEntity entity)
        {
            var result = await _supermarketRepository.Update(entity);
            if (result)
            {
                return ResponseService.Ok();
            }
            else
            {
                return ResponseService.Error(Errors.UPDATE_ERROR);
            }
        }
    }
}