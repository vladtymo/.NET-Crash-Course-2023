using Exam.Common;
using Exam.Database.Enitites;
using Exam.EntityFramework.Repository;
using Exam.Services.Response;
using Microsoft.EntityFrameworkCore;

namespace Exam.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<ProductEntity> _productRepository;

        public ProductService(IGenericRepository<ProductEntity> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ResponseService<int>> Buy(long id, int count)
        {
            ProductEntity dbRecord = await _productRepository.GetById(id);
            if (dbRecord == null)
            {
                return ResponseService<int>.Error(Errors.NOT_FOUND_ERROR);
            }

            if (dbRecord.Count < count)
            {
                return ResponseService<int>.Error(Errors.BUY_ERROR);
            }

            dbRecord.Count -= count;

            var result = await _productRepository.Update(dbRecord);
            if (result)
            {
                return ResponseService<int>.Ok(dbRecord.Count);
            }
            else
            {
                return ResponseService<int>.Error(Errors.UPDATE_ERROR);
            }
        }

        public async Task<ResponseService> Create(ProductEntity entity)
        {
            try
            {
                await _productRepository.Create(entity);
                return ResponseService.Ok();
            }
            catch (Exception ex)
            {
                return ResponseService.Error($"ProductService Create exception: {ex.Message}");
            }
        }

        public async Task<ResponseService> Delete(long id)
        {
            ProductEntity dbRecord = await _productRepository.GetById(id);
            if(dbRecord == null)
            {
                return ResponseService.Error(Errors.NOT_FOUND_ERROR);
            }

            dbRecord.DeletedOn = DateTime.Now;
            dbRecord.UpdatedOn = DateTime.Now;

            var result = await _productRepository.Update(dbRecord);
            if (result)
            {
                return ResponseService.Ok();
            }
            else
            {
                return ResponseService.Error(Errors.UPDATE_ERROR);
            }
        }

        public async Task<ICollection<ProductEntity>> GetAll()
        {
            return await _productRepository.GetAsQueryable()
                .OrderBy(product => product.Category)
                .ToListAsync();
        }

        public async Task<ICollection<ProductEntity>> GetBuyed()
        {
            return await _productRepository
                .GetAsQueryable(product => product.Count == 0)
                .ToListAsync();
        }

        public async Task<ResponseService<ProductEntity>> GetById(long id)
        {
            ProductEntity dbRecord = await _productRepository.GetById(id);
            if(dbRecord == null)
            {
                return ResponseService<ProductEntity>.Error(Errors.NOT_FOUND_ERROR);
            }

            return ResponseService<ProductEntity>.Ok(dbRecord);
        }

        public async Task<ICollection<ProductEntity>> GetExpired()
        {
            return await _productRepository
                .GetAsQueryable(product => 
                    product.ExpirationDate.Year == DateTime.Now.Year &&
                    product.ExpirationDate.Month == DateTime.Now.Month &&
                    product.ExpirationDate.Day == DateTime.Now.Day)
                .ToListAsync();
        }

        public async Task<ICollection<ProductEntity>> GetNotBuyed()
        {
            return await _productRepository.GetAsQueryable(product => product.Count > 0)
                .ToListAsync();
        }

        public async Task<ICollection<ProductEntity>> GetByName(string name)
        {
            return await _productRepository.GetAsQueryable(product => product.Name == name)
                .ToListAsync();
        }

        public async Task<ResponseService> Update(ProductEntity entity)
        {
            var result = await _productRepository.Update(entity);
            if(result)
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