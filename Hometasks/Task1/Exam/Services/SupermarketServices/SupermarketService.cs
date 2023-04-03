using Exam.Common;
using Exam.Database.Enitites;
using Exam.EntityFramework.Repository;
using Exam.Services.CheckServices;
using Exam.Services.GoodsServices;
using Exam.Services.ProductServices;
using Exam.Services.Response;

namespace Exam.Services.SupermarketServices
{
    public class SupermarketService : ISupermarketService
    {
        private readonly IGenericRepository<SupermarketEntity> _supermarketRepository;
        private readonly ICheckService _checkService;
        private readonly IGoodsService _goodsService;
        private readonly IProductService _productService;
        
        public SupermarketService(IGenericRepository<SupermarketEntity> supermarketRepository,
            ICheckService checkService,
            IGoodsService goodsService,
            IProductService productService)
        {
            _supermarketRepository = supermarketRepository;
            _checkService = checkService;
            _goodsService = goodsService;
            _productService = productService;
        }

        public async Task<ResponseService<float>> BuyGoods(long checkId, params GoodsEntity[] goods)
        {
            var response = await _checkService.GetById(checkId);
            if (response.IsError)
            {
                return ResponseService<float>.Error(response.ErrorMessage);
            }

            CheckEntity dbRecord = response.Value;

            foreach (GoodsEntity _goods in goods)
            {
                _goods.CheckFK = dbRecord.Id;

                var goodsUpdateResult = await _goodsService.Update(_goods);
                if (goodsUpdateResult.IsError)
                {
                    return ResponseService<float>.Error(goodsUpdateResult.ErrorMessage);
                }

                dbRecord.Amount += _goods.Price;
            }

            var chechUpdateResult = await _checkService.Update(dbRecord);
            if (chechUpdateResult.IsError)
            {
                return ResponseService<float>.Error(chechUpdateResult.ErrorMessage);
            }

            return ResponseService<float>.Ok(dbRecord.Amount);
        }

        public async Task<ResponseService<float>> BuyGoods(long checkId, params int[] goodsIds)
        {
            var result = 0f;

            foreach (long id in goodsIds)
            {
                var response = await _goodsService.GetById(id);
                if (response.IsError)
                {
                    return ResponseService<float>.Error(response.ErrorMessage);
                }

                var buyResult = await BuyGoods(checkId, response.Value);
                if (buyResult.IsError)
                {
                    return buyResult;
                }
                result = buyResult.Value;
            }

            return ResponseService<float>.Ok(result);
        }

        public async Task<ResponseService<float>> BuyProducts(long checkId, params ProductEntity[] products)
        {
            var result = await _checkService.GetById(checkId);
            if (result.IsError)
            {
                return ResponseService<float>.Error(result.ErrorMessage);
            }

            CheckEntity dbRecord = result.Value;

            foreach (ProductEntity product in products)
            {
                product.CheckFK = dbRecord.Id;

                var productUpdateResult = await _productService.Update(product);
                if (productUpdateResult.IsError)
                {
                    return ResponseService<float>.Error(productUpdateResult.ErrorMessage);
                }

                dbRecord.Amount += product.Price;
            }

            var chechUpdateResult = await _checkService.Update(dbRecord);
            if (chechUpdateResult.IsError)
            {
                return ResponseService<float>.Error(chechUpdateResult.ErrorMessage);
            }

            return ResponseService<float>.Ok(dbRecord.Amount);
        }

        public async Task<ResponseService<float>> BuyProducts(long checkId, params long[] productsIds)
        {
            float result = 0f;

            foreach (long id in productsIds)
            {
                var getResul = await _productService.GetById(id);
                if (getResul.IsError)
                {
                    return ResponseService<float>.Error(getResul.ErrorMessage);
                }

                ProductEntity dbRecord = getResul.Value;

                var buyResult = await BuyProducts(checkId, dbRecord);
                if (buyResult.IsError)
                {
                    return buyResult;
                }
            }

            return ResponseService<float>.Ok(result);
        }

        public async Task<ResponseService<float>> CloseCheck(long id)
        {
            var response = await _checkService.GetById(id);
            if (response.IsError)
            {
                return ResponseService<float>.Error(response.ErrorMessage);
            }

            CheckEntity dbRecord = response.Value;
            dbRecord.IsClosed = true;

            var updateResult = await _checkService.Update(dbRecord);
            if (updateResult.IsError)
            {
                return ResponseService<float>.Error(updateResult.ErrorMessage);
            }

            return ResponseService<float>.Ok(dbRecord.Amount);
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
                return ResponseService.Error(Errors.NOT_FOUND_ERROR);
            }

            dbRecord.DeletedOn = DateTime.Now;

            return await Update(dbRecord);
        }

        public async Task<ResponseService<long>> OpenCheck(long supermarketId)
        {
            CheckEntity dbRecord = new CheckEntity()
            {
                CreatedOn = DateTime.Now,
                IsClosed = false,
                SupermarketFK = supermarketId,
            };

            var response = await _checkService.Create(dbRecord);
            if (response.IsError)
            {
                return ResponseService<long>.Error(response.ErrorMessage);
            }

            return ResponseService<long>.Ok(dbRecord.Id);
        }

        public async Task<ResponseService> Update(SupermarketEntity entity)
        {
            entity.UpdatedOn = DateTime.Now;
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