using Exam.Common;
using Exam.Database.Enitites;
using Exam.EntityFramework.Repository;
using Exam.Services.Response;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Exam.Services.CheckServices
{
    public class CheckService : ICheckService
    {
        private readonly IGenericRepository<CheckEntity> _checkRepository;

        public CheckService(IGenericRepository<CheckEntity> checkRepository)
        {
            _checkRepository = checkRepository;
        }

        public async Task<ResponseService> Create(CheckEntity entity)
        {
            try
            {
                await _checkRepository.Create(entity);
                return ResponseService.Ok();
            }
            catch (Exception ex)
            {
                return ResponseService.Error($"CheckService Create exception: {ex.Message}");
            }
        }

        public async Task<ResponseService> Delete(long id)
        {
            CheckEntity dbRecord = await _checkRepository.GetById(id);
            if (dbRecord == null)
            {
                return ResponseService.Error(Errors.NOT_FOUND_ERROR);
            }

            dbRecord.DeletedOn = DateTime.Now;
            return await Update(dbRecord);
        }

        public async Task<ICollection<CheckEntity>> GetAll()
        {
            return await _checkRepository.GetAsQueryable()
                .ToListAsync();
        }

        public async Task<ResponseService<string>> GetAsString(long id, char separator)
        {
            CheckEntity dbRecord = await _checkRepository.GetById(id);
            if (dbRecord == null)
            {
                return ResponseService<string>.Error(Errors.NOT_FOUND_ERROR);
            }

            string result = string.Empty;

            foreach (GoodsEntity goods in dbRecord.Goods)
            {
                result += $"{goods.Name} {dbRecord.Goods.Count(goods => goods.Name == goods.Name)}{separator}";
            }
            foreach (ProductEntity product in dbRecord.Products)
            {
                result += $"{product.Name} {dbRecord.Products.Count(product => product.Name == product.Name)}{separator}";
            }

            return ResponseService<string>.Ok(result);
        }

        public async Task<ICollection<CheckEntity>> GetBy(Expression<Func<CheckEntity, bool>> expression)
        {
            return await _checkRepository.GetAsQueryable(expression)
                .ToListAsync();
        }

        public async Task<ResponseService<CheckEntity>> GetById(long id)
        {
            CheckEntity dbRecord = await _checkRepository.GetById(id);

            if (dbRecord == null) 
            {
                return ResponseService<CheckEntity>.Error(Errors.NOT_FOUND_ERROR);
            }

            return ResponseService<CheckEntity>.Ok(dbRecord);
        }

        public async Task<ResponseService> Update(CheckEntity entity)
        {
            entity.UpdatedOn = DateTime.Now;
            var result = await _checkRepository.Update(entity);

            if (result)
            {
                return ResponseService.Ok();
            }

            return ResponseService.Error(Errors.UPDATE_ERROR);
        }
    }
}