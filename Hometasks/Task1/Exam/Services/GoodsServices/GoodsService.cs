using Exam.Common;
using Exam.Database.Enitites;
using Exam.EntityFramework.Repository;
using Exam.Services.Response;
using Microsoft.EntityFrameworkCore;

namespace Exam.Services.GoodsServices
{
    public class GoodsService : IGoodsService
    {
        private readonly IGenericRepository<GoodsEntity> _goodsRepository;

        public GoodsService(IGenericRepository<GoodsEntity> goodsRepository)
        {
            _goodsRepository = goodsRepository;
        }

        public async Task<ResponseService<int>> AppendGoods(int id, int count)
        {
            GoodsEntity dbRecord = await _goodsRepository.GetById(id);
            if(dbRecord == null)
            {
                return ResponseService<int>.Error(Errors.NOT_FOUND_ERROR);
            }

            dbRecord.Count += count;

            var result = await _goodsRepository.Update(dbRecord);
            if(result)
            {
                return ResponseService<int>.Error(Errors.UPDATE_ERROR);
            }
            else
            {
                return ResponseService<int>.Ok(dbRecord.Count);
            }
        }

        public async Task<ResponseService<int>> BuyGoods(int id, int count)
        {
            GoodsEntity dbRecord = await _goodsRepository.GetById(id);
            if (dbRecord == null)
            {
                return ResponseService<int>.Error(Errors.NOT_FOUND_ERROR);
            }

            if (dbRecord.Count < count)
            {
                return ResponseService<int>.Error(Errors.BUY_ERROR);
            }

            dbRecord.Count -= count;

            var result = await _goodsRepository.Update(dbRecord);
            if (result)
            {
                return ResponseService<int>.Error(Errors.UPDATE_ERROR);
            }

            return ResponseService<int>.Ok(dbRecord.Count);
        }

        public async Task<ResponseService> Create(GoodsEntity entity)
        {
            try
            {
                await _goodsRepository.Create(entity);
            }
            catch (Exception ex)
            {
                return ResponseService.Error($"GoodsService Create exception: {ex.Message}")
            }

            return ResponseService.Ok();
        }

        public async Task<ResponseService> Delete(long id)
        {
            GoodsEntity dbRecord = await _goodsRepository.GetById(id);
            if(dbRecord == null)
            {
                return ResponseService.Error(Errors.NOT_FOUND_ERROR);
            }

            try
            {
                await _goodsRepository.Delete(dbRecord);
                return ResponseService.Ok();
            }
            catch (Exception ex)
            {
                return ResponseService.Error($"GoodsService Delete exception: {ex.Message}");
            }
        }

        public async Task<List<GoodsEntity>> GetAll()
        {
            return await _goodsRepository.GetAsQueryable()
                .ToListAsync();
        }

        public async Task<List<GoodsEntity>> GetBuyed()
        {
            return await _goodsRepository.GetAsQueryable(goods => goods.Count == 0)
                .ToListAsync();
        }

        public async Task<ResponseService<GoodsEntity>> GetById(long id)
        {
            GoodsEntity dbRecord = await _goodsRepository.GetById(id);
            if(dbRecord == null)
            {
                return ResponseService<GoodsEntity>.Error(Errors.NOT_FOUND_ERROR);
            }

            return ResponseService<GoodsEntity>.Ok(dbRecord);
        }

        public async Task<List<GoodsEntity>> GetNotBuyed()
        {
            return await _goodsRepository.GetAsQueryable(goods => goods.Count > 0)
                .ToListAsync();
        }

        public async Task<ResponseService> Update(GoodsEntity entity)
        {
            var result = await _goodsRepository.Update(entity);

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