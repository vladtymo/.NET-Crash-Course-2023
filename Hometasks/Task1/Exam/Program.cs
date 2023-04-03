using Exam.Database.Enitites;
using Exam.EntityFramework;
using Exam.EntityFramework.Repository;
using Exam.Services.CheckServices;
using Exam.Services.GoodsServices;
using Exam.Services.ImplementatorServices;
using Exam.Services.ProductServices;
using Exam.Services.SupermarketServices;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            IGenericRepository<CheckEntity> checkRepository = new GenericRepository<CheckEntity>(dbContext);
            IGenericRepository<GoodsEntity> goodsRepository = new GenericRepository<GoodsEntity>(dbContext);
            IGenericRepository<ProductEntity> productRepository = new GenericRepository<ProductEntity>(dbContext);
            IGenericRepository<SupermarketEntity> supermarketRepository = new GenericRepository<SupermarketEntity>(dbContext);

            ICheckService checkService = new CheckService(checkRepository);
            IGoodsService goodsService = new GoodsService(goodsRepository);
            IProductService productService = new ProductService(productRepository);

            ISupermarketService supermarketService = new SupermarketService(supermarketRepository, 
                checkService, 
                goodsService, 
                productService);

            IImplementatorService implementatorService = new ImplementatorService(checkService,
                goodsService,
                productService,
                supermarketService);

            Console.WriteLine("Done!");
        }
    }
}