using Exam.Database.Enitites;
using Exam.EntityFramework;
using Exam.EntityFramework.Repository;
using Exam.Services.CheckServices;
using Exam.Services.GoodsServices;
using Exam.Services.ImplementatorServices;
using Exam.Services.OpenAIServices;
using Exam.Services.ProductServices;
using Exam.Services.SupermarketServices;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Method();
            Console.ReadLine();
        }

        static async void Method()
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

            IGPTService gptService = new GPTService();

            IImplementatorService implementatorService = new ImplementatorService(checkService,
                goodsService,
                productService,
                supermarketService,
                gptService);

            // Filling the Database with Data
            var supermarketResult = await implementatorService.ImplementSupermarkets(1, true);
            SupermarketEntity supermarket = supermarketResult.Value.First();

            var productResult = await implementatorService.ImplementProduct(20, supermarket.Id, true);
            ICollection<ProductEntity> products = productResult.Value;

            var goodsResult = await implementatorService.ImplementGoods(5, supermarket.Id, true);
            ICollection<GoodsEntity> goods = goodsResult.Value;

            foreach (ProductEntity product in products)
            {
                Console.WriteLine($"Type: {product.GetType()}\nName: {product.Name}\nCategory: {product.Category}\nDescription: {product.Description}\nPrice: {product.Price}\nExpiration: {product.ExpirationDate}\n\n");
            }

            foreach (GoodsEntity _goods in goods)
            {
                Console.WriteLine($"Type: {_goods.GetType()}\nName: {_goods.Name}\nDescription: {_goods.Description}\nCategory: {_goods.Category}\nPrice: {_goods.Price}\nCount: {_goods.Count}\n\n");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            products = await productService.GetAll(product => product.Category);
            foreach (var product in products)
            {
                Console.WriteLine($"Type: {product.GetType().Name}\nName: {product.Name}\nCategory: {product.Category}\nDescription: {product.Description}\nPrice: {product.Price}\nExpiration: {product.ExpirationDate}\n\n");
            }
        }
    }
}