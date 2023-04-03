using Exam.Database.Enitites;
using Exam.Services.CheckServices;
using Exam.Services.GoodsServices;
using Exam.Services.ProductServices;
using Exam.Services.SupermarketServices;

namespace Exam.Services.ImplementatorServices
{
    public class ImplementatorService : IImplementatorService
    {
        private readonly ICheckService _checkService;
        private readonly IGoodsService _goodsService;
        private readonly IProductService _productService;
        private readonly ISupermarketService _supermarketService;

        public ImplementatorService(ICheckService checkService,
            IGoodsService goodsService,
            IProductService productService,
            ISupermarketService supermarketService)
        {
            _checkService = checkService;
            _goodsService = goodsService;
            _productService = productService;
            _supermarketService = supermarketService;
        }

        public Task<ICollection<CheckEntity>> ImplementChecks()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<GoodsEntity>> ImplementGoods(int count)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ProductEntity>> ImplementProduct(int count)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<SupermarketEntity>> ImplementSupermarkets(int count)
        {
            throw new NotImplementedException();
        }
    }
}